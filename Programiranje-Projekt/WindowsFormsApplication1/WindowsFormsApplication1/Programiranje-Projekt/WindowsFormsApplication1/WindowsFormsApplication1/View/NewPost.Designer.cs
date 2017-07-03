namespace WindowsFormsApplication1.View
{
    partial class NewPost
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
            this.richTextBox_NewPostTitle = new System.Windows.Forms.RichTextBox();
            this.richTextBox_NewPostMessage = new System.Windows.Forms.RichTextBox();
            this.lbl_NewPostTitle = new System.Windows.Forms.Label();
            this.lbl_NewPostMessage = new System.Windows.Forms.Label();
            this.btn_ConfirmNewPost = new System.Windows.Forms.Button();
            this.lbl_UserCreatingPost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_NewPostTitle
            // 
            this.richTextBox_NewPostTitle.Location = new System.Drawing.Point(43, 59);
            this.richTextBox_NewPostTitle.Name = "richTextBox_NewPostTitle";
            this.richTextBox_NewPostTitle.Size = new System.Drawing.Size(576, 102);
            this.richTextBox_NewPostTitle.TabIndex = 0;
            this.richTextBox_NewPostTitle.Text = "";
            // 
            // richTextBox_NewPostMessage
            // 
            this.richTextBox_NewPostMessage.Location = new System.Drawing.Point(43, 229);
            this.richTextBox_NewPostMessage.Name = "richTextBox_NewPostMessage";
            this.richTextBox_NewPostMessage.Size = new System.Drawing.Size(576, 327);
            this.richTextBox_NewPostMessage.TabIndex = 1;
            this.richTextBox_NewPostMessage.Text = "";
            // 
            // lbl_NewPostTitle
            // 
            this.lbl_NewPostTitle.AutoSize = true;
            this.lbl_NewPostTitle.Location = new System.Drawing.Point(40, 29);
            this.lbl_NewPostTitle.Name = "lbl_NewPostTitle";
            this.lbl_NewPostTitle.Size = new System.Drawing.Size(39, 17);
            this.lbl_NewPostTitle.TabIndex = 2;
            this.lbl_NewPostTitle.Text = "Title:";
            // 
            // lbl_NewPostMessage
            // 
            this.lbl_NewPostMessage.AutoSize = true;
            this.lbl_NewPostMessage.Location = new System.Drawing.Point(40, 192);
            this.lbl_NewPostMessage.Name = "lbl_NewPostMessage";
            this.lbl_NewPostMessage.Size = new System.Drawing.Size(69, 17);
            this.lbl_NewPostMessage.TabIndex = 3;
            this.lbl_NewPostMessage.Text = "Message:";
            // 
            // btn_ConfirmNewPost
            // 
            this.btn_ConfirmNewPost.Location = new System.Drawing.Point(636, 481);
            this.btn_ConfirmNewPost.Name = "btn_ConfirmNewPost";
            this.btn_ConfirmNewPost.Size = new System.Drawing.Size(100, 75);
            this.btn_ConfirmNewPost.TabIndex = 4;
            this.btn_ConfirmNewPost.Text = "Post";
            this.btn_ConfirmNewPost.UseVisualStyleBackColor = true;
            this.btn_ConfirmNewPost.Click += new System.EventHandler(this.btn_ConfirmNewPost_Click);
            // 
            // lbl_UserCreatingPost
            // 
            this.lbl_UserCreatingPost.AutoSize = true;
            this.lbl_UserCreatingPost.Location = new System.Drawing.Point(633, 402);
            this.lbl_UserCreatingPost.MaximumSize = new System.Drawing.Size(100, 0);
            this.lbl_UserCreatingPost.Name = "lbl_UserCreatingPost";
            this.lbl_UserCreatingPost.Size = new System.Drawing.Size(0, 17);
            this.lbl_UserCreatingPost.TabIndex = 5;
            // 
            // NewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 585);
            this.Controls.Add(this.lbl_UserCreatingPost);
            this.Controls.Add(this.btn_ConfirmNewPost);
            this.Controls.Add(this.lbl_NewPostMessage);
            this.Controls.Add(this.lbl_NewPostTitle);
            this.Controls.Add(this.richTextBox_NewPostMessage);
            this.Controls.Add(this.richTextBox_NewPostTitle);
            this.MaximumSize = new System.Drawing.Size(771, 632);
            this.MinimumSize = new System.Drawing.Size(771, 632);
            this.Name = "NewPost";
            this.Text = "NewPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_NewPostTitle;
        private System.Windows.Forms.RichTextBox richTextBox_NewPostMessage;
        private System.Windows.Forms.Label lbl_NewPostTitle;
        private System.Windows.Forms.Label lbl_NewPostMessage;
        private System.Windows.Forms.Button btn_ConfirmNewPost;
        private System.Windows.Forms.Label lbl_UserCreatingPost;
    }
}