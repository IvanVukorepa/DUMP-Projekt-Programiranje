using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controllers;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.View;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RepositoryController = new RepositoryController(this);
            UserController = new UserController(this);
            PostController = new PostController(this);
            LoggedInUser = new User();
            LoggedInUser = null;
            SetComboBoxItems();
            WellcomePost();
        }

        public RepositoryController RepositoryController;
        public UserController UserController;
        public PostController PostController;
        public User LoggedInUser;

        private void WellcomePost()
        {
            User admin = new User("Administrator", "", "Admin", "Admin");
            RepositoryController.AddUser(admin);
            string Title = "Wellcome to this message board(click to see more)";
            string Message = "Wellcome to this message board where you can read, post and comment, to see othe posts in detail click on their title";
            Post wellcomePost = new Post(Title, Message, admin, DateTime.Now);
            RepositoryController.AddPost(wellcomePost);
            PostController.ListAllPosts();
        }
        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            SignIn SignInScreen = new SignIn(this);
            SignInScreen.ShowDialog();          
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            btn_SignIn.Visible = true;
            btn_LogOut.Visible = false;
            lbl_user.Visible = false;
            lbl_user.Text = "";
            LoggedInUser.LoggedIn = false;
            LoggedInUser = null;
        }

        public void SetLogIn(string username)
        {
            btn_SignIn.Visible = false;
            btn_LogOut.Visible = true;
            lbl_user.Visible = true;
            LoggedInUser = RepositoryController.GetAllUsers().Where(x=>x.Username==username).First();
            lbl_user.Text = LoggedInUser.ToString();
        }

        private void btn_newPost_Click(object sender, EventArgs e)
        {
            if (LoggedInUser == null)
            {
                MessageBox.Show("You must be logged in to post");
                return;
            }
            NewPost newPost = new NewPost(this);
            newPost.ShowDialog();
        }

        public void ViewFullPost(object sender, EventArgs e, Post post)
        {
            FullPost fullPost = new FullPost(post, this);
            fullPost.ShowDialog();
        }

        public void SetComboBoxItems()
        {
            comboBox_Search.Items.Add("Titles");
            comboBox_Search.Items.Add("Usernames");

            comboBox_Filter.Items.Add("No filter");
            comboBox_Filter.Items.Add("Favorites");
        }

        public void DeletePost(object sender, EventArgs e, Post post, User user)
        {
            if (post.Creator == user || (user!=null && user.Username=="Admin"))
            {
                RepositoryController.DeletePost(post);
                PostController.RemoveAllPostsFromForm();
                PostController.ListAllPosts();               
            }
            else
                MessageBox.Show("You can only delete your posts");
        }

        public void EditPost(object sender, EventArgs e, Post post, User user)
        {
            if (post.Creator != user)
            {
                MessageBox.Show("You can only edit your posts");
                return;
            }
            NewPost editPost = new NewPost(this, post);
            editPost.ShowDialog();
            RepositoryController.DeletePost(post);
            PostController.RemoveAllPostsFromForm();
            PostController.ListAllPosts();
        }

        public void AddToFavorites(object sender, EventArgs e, Post post, User user)
        {
            if (user == null)
            {
                MessageBox.Show("You must be logged in to favorite posts");
                return;
            }
            else if (user.Favorites.Contains(post))
            {
                MessageBox.Show("You already favotired this post");
                return;
            }
            user.Favorites.Add(post);
        }

        private void comboBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            PostController.RemoveAllPostsFromForm();
            if (comboBox_Filter.SelectedItem.ToString() == "Favorites")
                PostController.ListAllFavorites();
            else if (comboBox_Filter.SelectedItem.ToString() == "No filter")
                PostController.ListAllPosts();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (comboBox_Search.SelectedItem == null)
            {
                MessageBox.Show("You need to select one item from the drop down menu");
                return;
            }
            if (comboBox_Search.SelectedItem.ToString() == "Titles")
            {
                PostController.RemoveAllPostsFromForm();
                PostController.ListAllSearchedByTitles(txt_Search.Text);
            }
            else if (comboBox_Search.SelectedItem.ToString() == "Usernames")
            {
                PostController.RemoveAllPostsFromForm();
                PostController.ListAllSearchedByUsers(txt_Search.Text);
            }
        }
    }
}
