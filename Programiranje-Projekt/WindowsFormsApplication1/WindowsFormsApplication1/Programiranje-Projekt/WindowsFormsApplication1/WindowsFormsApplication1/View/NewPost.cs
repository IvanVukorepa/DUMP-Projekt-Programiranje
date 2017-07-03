using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.View
{
    public partial class NewPost : Form
    {
        private Form1 _form;
        public NewPost(Form1 form)
        {
            InitializeComponent();
            _form = form;
            lbl_UserCreatingPost.Text = $"You are posting as {_form.LoggedInUser.Username}";
        }

        public NewPost(Form1 form, Post post)
        {
            InitializeComponent();
            _form = form;
            lbl_UserCreatingPost.Text = $"You are posting as {_form.LoggedInUser.Username}";
            richTextBox_NewPostTitle.Text = post.Title;
            richTextBox_NewPostMessage.Text = post.Message;
            btn_ConfirmNewPost.Text = "Edit";
        }

        private void btn_ConfirmNewPost_Click(object sender, EventArgs e)
        {
            if (richTextBox_NewPostTitle.Text == "" || richTextBox_NewPostMessage.Text == "")
                MessageBox.Show("A post must have both a title and a message");
            else
            {
                _form.PostController.CreatePost(richTextBox_NewPostTitle.Text, richTextBox_NewPostMessage.Text, _form.LoggedInUser);
                _form.PostController.ListAllPosts();
                this.Close();
            }
        }
    }
}
