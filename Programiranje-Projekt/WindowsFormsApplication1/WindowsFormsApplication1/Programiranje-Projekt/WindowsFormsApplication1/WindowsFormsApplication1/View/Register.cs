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
    public partial class Register : Form
    {
        public Register(Form1 form)
        {
            InitializeComponent();
            _form = form;
        }
        public Form1 _form;
        private void btn_register_Click(object sender, EventArgs e)
        {           
            if (textBox_firstName.Text != null && textBox_lastName.Text != null && textBox_passwordRegister.Text != null && textBox_usernameRegister.Text != null)
            {
                if (!_form.RepositoryController.CheckUsernameAvailability(textBox_usernameRegister.Text))
                    MessageBox.Show("Username already taken!");
                else
                {
                    _form.UserController.Register(textBox_firstName.Text, textBox_lastName.Text, textBox_usernameRegister.Text, textBox_passwordRegister.Text);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You need to input all the data");
            }
        }
    }
}
