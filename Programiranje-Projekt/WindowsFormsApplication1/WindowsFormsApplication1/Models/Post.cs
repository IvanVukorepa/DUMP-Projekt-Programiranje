using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public User Creator { get; set; }
        public DateTime Time { get; set; }
        public List<Comment> Comments;

        public Post()
        {
            Comments = new List<Comment>();
        }
        public Post(string title, string message, User creator, DateTime dateTime)
        {
            Title = title;
            Message = message;
            Creator = creator;
            Time = dateTime;
            Comments = new List<Comment>();
        }
    }
}
