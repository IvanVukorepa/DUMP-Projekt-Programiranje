namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_newPost = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(173, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(371, 58);
            this.Title.TabIndex = 0;
            this.Title.Text = "Message board";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Location = new System.Drawing.Point(799, 12);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(138, 55);
            this.btn_SignIn.TabIndex = 1;
            this.btn_SignIn.Text = "Sign in";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(799, 12);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(138, 55);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Visible = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(571, 31);
            this.lbl_user.MaximumSize = new System.Drawing.Size(200, 40);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(0, 17);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Visible = false;
            // 
            // btn_newPost
            // 
            this.btn_newPost.Location = new System.Drawing.Point(24, 97);
            this.btn_newPost.Name = "btn_newPost";
            this.btn_newPost.Size = new System.Drawing.Size(119, 39);
            this.btn_newPost.TabIndex = 7;
            this.btn_newPost.Text = "Create post";
            this.btn_newPost.UseVisualStyleBackColor = true;
            this.btn_newPost.Click += new System.EventHandler(this.btn_newPost_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(736, 178);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(201, 22);
            this.txt_Search.TabIndex = 8;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(733, 148);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(53, 17);
            this.lbl_Search.TabIndex = 9;
            this.lbl_Search.Text = "Search";
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Location = new System.Drawing.Point(816, 148);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Search.TabIndex = 10;
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Location = new System.Drawing.Point(733, 252);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(39, 17);
            this.lbl_Filter.TabIndex = 11;
            this.lbl_Filter.Text = "Filter";
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(799, 249);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(138, 24);
            this.comboBox_Filter.TabIndex = 12;
            this.comboBox_Filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(862, 206);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(970, 503);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.comboBox_Filter);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.comboBox_Search);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_newPost);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.Title);
            this.MaximumSize = new System.Drawing.Size(988, 550);
            this.MinimumSize = new System.Drawing.Size(988, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_newPost;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.ComboBox comboBox_Search;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.Button btn_Search;
    }
}

