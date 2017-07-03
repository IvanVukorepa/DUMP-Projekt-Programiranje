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
using WindowsFormsApplication1.Controllers;

namespace WindowsFormsApplication1.View
{
    public partial class FullPost : Form
    {
        private Post _post;
        private Form1 _form;
        private CommentsController CommentsController;
        public FullPost(Post post, Form1 form)
        {
            InitializeComponent();
            _post = post;
            _form = form;
            CommentsController = new CommentsController(this, _form);    
            SetUpInfo(post);
            SetUpComments();
        }

        public void SetUpInfo(Post post)
        {
            lbl_Title.Text = post.Title;

            lbl_CreatorInfo.Location = new Point(lbl_CreatorInfo.Left, lbl_Title.Bottom + 10);
            lbl_CreatorInfo.Text = post.Creator.FirstName + " " + post.Creator.LastName + " " + post.Creator.Username;

            lbl_DateInfo.Location = new Point(lbl_DateInfo.Left, lbl_CreatorInfo.Bottom + 10);
            lbl_DateInfo.Text = post.Time.ToString();

            lbl_Message.Location = new Point(lbl_Message.Left, lbl_DateInfo.Bottom + 10);
            lbl_Message.Text = post.Message;
        }

        public void SetUpComments()
        {
            lbl_Comments.Location = new Point(lbl_Comments.Left, lbl_Message.Bottom + 20);
            txt_Comment.Location = new Point(lbl_Comments.Left, lbl_Comments.Bottom);
            btn_AddComment.Location = new Point(txt_Comment.Right+10, txt_Comment.Top);
            CommentsController.ListAllComments(_post);
        }

        private void btn_AddComment_Click(object sender, EventArgs e)
        {
            if (_form.LoggedInUser == null)
            {
                MessageBox.Show("You must be logged in to comment");
                return;
            }
            else if (txt_Comment.Text == "")
            {
                MessageBox.Show("Enter your comment in the textbox");
                return;
            }
            CommentsController.AddComment(txt_Comment.Text, _form.LoggedInUser, DateTime.Now, _post);
            txt_Comment.Text = "";
            CommentsController.ListAllComments(_post);
        }
    }
}
