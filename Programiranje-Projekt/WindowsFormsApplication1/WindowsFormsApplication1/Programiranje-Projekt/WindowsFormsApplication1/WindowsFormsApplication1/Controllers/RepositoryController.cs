using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Models;


namespace WindowsFormsApplication1.Controllers
{
    public class RepositoryController
    {
        private Repository Repository = new Repository();        
        private Form1 _form;

        public RepositoryController(Form1 form)
        {
            _form = form;
        }

        public void AddUser(User user)
        {
            Repository.AllUsers.Add(user);
        }

        public bool CheckUsernameAvailability(string username)
        {
            return Repository.AllUsers.FirstOrDefault(x => x.Username == username) == null ? true : false;
        }
        public bool CheckUserLogInInput(string username, string password)
        {
            return Repository.AllUsers.FirstOrDefault(x=>x.Username==username && x.Password==password)==null ?  false: true;      
        }

        public void LogIn(string username, string password)
        {
            (Repository.AllUsers.Where(x => x.Username == username)).First().LoggedIn = true;
            _form.SetLogIn(username);
        }

        public List<User> GetAllUsers()
        {
            return Repository.AllUsers;
        }

        public void AddPost(Post post)
        {
            Repository.AllPosts.Add(post);
            post.Creator.MyPosts.Add(post);
        }

        public List<Post> GetAllPosts()
        {
            return Repository.AllPosts;
        }

        public List<Comment> GetPostComments(Post post)
        {
            return Repository.AllPosts.Where(x => x == post).First().Comments;
        }

        public void AddComment(Comment comment, Post post, User user)
        {
            user.MyComments.Add(comment);
            post.Comments.Add(comment);
        }

        public void DeletePost(Post post)
        {
            Repository.AllPosts.Remove(post);
            post.Creator.MyPosts.Remove(post);
        }
    }
}
