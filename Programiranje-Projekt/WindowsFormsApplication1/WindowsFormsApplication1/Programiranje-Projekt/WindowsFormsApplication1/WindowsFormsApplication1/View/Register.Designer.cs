namespace WindowsFormsApplication1.View
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_usernameRegister = new System.Windows.Forms.TextBox();
            this.textBox_passwordRegister = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(49, 52);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(78, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "First name:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(49, 91);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(78, 17);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Last name:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(49, 136);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(77, 17);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(49, 174);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(73, 17);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(159, 49);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(128, 22);
            this.textBox_firstName.TabIndex = 4;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(159, 88);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(128, 22);
            this.textBox_lastName.TabIndex = 5;
            // 
            // textBox_usernameRegister
            // 
            this.textBox_usernameRegister.Location = new System.Drawing.Point(159, 134);
            this.textBox_usernameRegister.Name = "textBox_usernameRegister";
            this.textBox_usernameRegister.Size = new System.Drawing.Size(128, 22);
            this.textBox_usernameRegister.TabIndex = 6;
            // 
            // textBox_passwordRegister
            // 
            this.textBox_passwordRegister.Location = new System.Drawing.Point(159, 171);
            this.textBox_passwordRegister.Name = "textBox_passwordRegister";
            this.textBox_passwordRegister.Size = new System.Drawing.Size(128, 22);
            this.textBox_passwordRegister.TabIndex = 7;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(288, 217);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(102, 58);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 348);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.textBox_passwordRegister);
            this.Controls.Add(this.textBox_usernameRegister);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.MaximumSize = new System.Drawing.Size(482, 395);
            this.MinimumSize = new System.Drawing.Size(482, 395);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_usernameRegister;
        private System.Windows.Forms.TextBox textBox_passwordRegister;
        private System.Windows.Forms.Button btn_register;
    }
}