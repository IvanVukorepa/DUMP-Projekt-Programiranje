using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Controllers
{
    public class UserController
    {
        private Form1 _form;

        public UserController(Form1 form)
        {
            _form = form;
        }

        public void Register(string firstName, string lastName, string username, string password)
        {
            User user = new User(firstName, lastName, username, password);
            _form.RepositoryController.AddUser(user);
        }

        public bool LogIn(string username, string password)
        {
            if (_form.RepositoryController.CheckUserLogInInput(username, password))
            {
                _form.RepositoryController.LogIn(username, password);
                return true;
            }
            return false;
        }

    }
}
