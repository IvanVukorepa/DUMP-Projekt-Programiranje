using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Comment
    {
        public string Text { get; set; }
        public User Creator { get; set; }
        public DateTime Time { get; set; }
        public Post Post { get; set; }

        public Comment()
        {

        }
        public Comment(string text, User user, DateTime time, Post post)
        {
            Text = text;
            Creator = user;
            Time = time;
            Post = post;
        }
    }
}
