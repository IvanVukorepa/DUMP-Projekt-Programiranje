using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsApplication1.View;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Controllers
{
    public class CommentsController
    {
        private FullPost _fullPost;
        private Form1 _form;
        public CommentsController(FullPost fullPost, Form1 form)
        {
            _fullPost = fullPost;
            _form = form;
        }

        public void ListAllComments(Post post)
        {
            int num = 0;
            int position = _fullPost.txt_Comment.Bottom + 10;
            _form.RepositoryController.GetPostComments(post).ForEach(x=>DisplayComment(x,num++, ref position));
        }

        public void AddComment(string comment, User user, DateTime time, Post post)
        {
            Comment newComment = new Comment(comment, user, time, post);
            _form.RepositoryController.AddComment(newComment, post, user);
        }

        public void DisplayComment(Comment _comment, int num, ref int position)
        {
            Label comment = new Label()
            {
                Location = new System.Drawing.Point(35, position),
                Name = $"lbl_comment+{ num.ToString()}",
                MaximumSize = new Size(350, 0),
                AutoSize = true,
                Text = $"{_comment.Creator.Username}:\n\n{_comment.Text}",
                BorderStyle = BorderStyle.FixedSingle
            };
            _fullPost.Controls.Add(comment);
            position = comment.Bottom + 5;
        }

    }
}
