using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.View;

namespace WindowsFormsApplication1
{
    public partial class SignIn : Form
    {
        public SignIn(Form1 Form)
        {
            InitializeComponent();
            _form = Form;
        }
        private Form1 _form;
        private void lbl_register_Click(object sender, EventArgs e)
        {
            Register RegisterWindow = new Register(_form);
            RegisterWindow.ShowDialog();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (!_form.RepositoryController.CheckUsernameAvailability(textBox_username.Text))
            {
                if (!_form.UserController.LogIn(textBox_username.Text, textBox_password.Text))
                    MessageBox.Show("Login failed");
                this.Close();
            }
            else
                MessageBox.Show("User {0} does not exist", textBox_username.Text);
        }
    }
}
