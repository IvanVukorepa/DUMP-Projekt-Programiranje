using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Controllers
{
    public class PostController
    {
        private Form1 _form;

        public PostController(Form1 form)
        {
            _form = form;
        }

        public void CreatePost(string title, string message, User creator)
        {
            Post newPost = new Post(title, message, creator, DateTime.Now);
            _form.RepositoryController.AddPost(newPost);
        }

        public void ListAllPosts()
        {
            int num = 0;
            _form.RepositoryController.GetAllPosts().ForEach(x=>DisplayPost(x, num++));
        }

        public void ListAllFavorites()
        {
            int num = 0;
            _form.RepositoryController.GetAllPosts().Where(x=>_form.LoggedInUser.Favorites.Contains(x)).ToList().ForEach(x => DisplayPost(x, num++));
        }

        public void ListAllSearchedByUsers(string str)
        {
            int num = 0;
            _form.RepositoryController.GetAllPosts().Where(x => x.Creator.Username.Contains(str)).ToList().ForEach(x => DisplayPost(x, num++));
        }

        public void ListAllSearchedByTitles(string str)
        {
            int num = 0;
            _form.RepositoryController.GetAllPosts().Where(x => x.Title.Contains(str)).ToList().ForEach(x => DisplayPost(x, num++));
        }

        public void RemoveAllPostsFromForm()
        {
            List<Control> temp = new List<Control>(); ;
            foreach (Control control in _form.Controls)
            {
                if (control.Left < 500 && control.Top > 120)
                    temp.Add(control);
            }
            temp.ForEach(x=>_form.Controls.Remove(x));
        }

        public void DisplayPost(Post post, int num)
        {
            GroupBox groupBox = new GroupBox()
            {
                Location = new System.Drawing.Point(25, num*80+130),
                Name = "groupBox",
                MaximumSize = new Size(450, 75),
                Size = new Size(450, 75),
            };
            _form.Controls.Add(groupBox);

            Label title = new Label()
            {
                Location = new System.Drawing.Point(35,num*80+140),
                Name = "lbl_title",
                MaximumSize = new Size(430, 40),
                Size = new Size(430, 40),
                Text = post.Title
            };
            _form.Controls.Add(title);
            title.BringToFront();
            title.Click += (sender, e) => _form.ViewFullPost(sender, e, post);
            Label details = new Label()
            {
                Location = new System.Drawing.Point(35, num * 80 + 182),
                Name = "lbl_title",
                MaximumSize = new Size(430, 12),
                Size = new Size(430, 12),
                Text = $"Posted by: {post.Creator.Username}, Date:{post.Time}"
            };
            _form.Controls.Add(details);
            details.BringToFront();

            Button btn_Delete = new Button()
            {
                Size = new Size(55,25),
                Name="btn_Delete",
                Location = new Point(groupBox.Right,groupBox.Bottom-25),
                Text="Delete",
            };
            
            Button btn_Edit = new Button()
            {
                Size = new Size(55, 25),
                Name = "btn_Edit",
                Location = new Point(groupBox.Right, groupBox.Bottom - 50),
                Text = "Edit"
            };

            Button btn_Favorite = new Button()
            {
                Size = new Size(55, 25),
                Name = "btn_Favorite",
                Location = new Point(groupBox.Right, groupBox.Bottom - 75),
                Text = "Favorite"
            };

            _form.Controls.Add(btn_Delete);
            _form.Controls.Add(btn_Edit);
            _form.Controls.Add(btn_Favorite);

            btn_Delete.Click += (sender, e) => _form.DeletePost(sender,e, post, _form.LoggedInUser);
            btn_Edit.Click += (sender, e) => _form.EditPost(sender, e, post, _form.LoggedInUser);
            btn_Favorite.Click += (sender,e) => _form.AddToFavorites(sender, e, post, _form.LoggedInUser);
        }
    }
}
