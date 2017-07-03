using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public List<Post> MyPosts;
        public List<Comment> MyComments;
        public List<Post> Favorites;

        public User()
        {
            MyPosts = new List<Post>();
            MyComments = new List<Comment>();
        }
        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            LoggedIn = false;
            MyPosts = new List<Post>();
            MyComments = new List<Comment>();
            Favorites = new List<Post>();
        }
        public override string ToString()
        {
            return $"signed in as {FirstName} {LastName},\nusername: {Username}";
        }
    }
}
