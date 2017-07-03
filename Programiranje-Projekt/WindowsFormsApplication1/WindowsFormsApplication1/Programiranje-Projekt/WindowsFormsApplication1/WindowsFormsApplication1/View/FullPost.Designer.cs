namespace WindowsFormsApplication1.View
{
    partial class FullPost
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.lbl_CreatorInfo = new System.Windows.Forms.Label();
            this.lbl_DateInfo = new System.Windows.Forms.Label();
            this.lbl_Comments = new System.Windows.Forms.Label();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.btn_AddComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(41, 44);
            this.lbl_Title.MaximumSize = new System.Drawing.Size(550, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(35, 17);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Title";
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(41, 168);
            this.lbl_Message.MaximumSize = new System.Drawing.Size(550, 0);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(65, 17);
            this.lbl_Message.TabIndex = 1;
            this.lbl_Message.Text = "Message";
            // 
            // lbl_CreatorInfo
            // 
            this.lbl_CreatorInfo.AutoSize = true;
            this.lbl_CreatorInfo.Location = new System.Drawing.Point(41, 104);
            this.lbl_CreatorInfo.MaximumSize = new System.Drawing.Size(550, 0);
            this.lbl_CreatorInfo.Name = "lbl_CreatorInfo";
            this.lbl_CreatorInfo.Size = new System.Drawing.Size(55, 17);
            this.lbl_CreatorInfo.TabIndex = 2;
            this.lbl_CreatorInfo.Text = "Creator";
            // 
            // lbl_DateInfo
            // 
            this.lbl_DateInfo.AutoSize = true;
            this.lbl_DateInfo.Location = new System.Drawing.Point(41, 132);
            this.lbl_DateInfo.MaximumSize = new System.Drawing.Size(550, 0);
            this.lbl_DateInfo.Name = "lbl_DateInfo";
            this.lbl_DateInfo.Size = new System.Drawing.Size(38, 17);
            this.lbl_DateInfo.TabIndex = 3;
            this.lbl_DateInfo.Text = "Date";
            // 
            // lbl_Comments
            // 
            this.lbl_Comments.AutoSize = true;
            this.lbl_Comments.Location = new System.Drawing.Point(44, 235);
            this.lbl_Comments.MaximumSize = new System.Drawing.Size(550, 0);
            this.lbl_Comments.Name = "lbl_Comments";
            this.lbl_Comments.Size = new System.Drawing.Size(78, 17);
            this.lbl_Comments.TabIndex = 4;
            this.lbl_Comments.Text = "Comments:";
            // 
            // txt_Comment
            // 
            this.txt_Comment.Location = new System.Drawing.Point(47, 276);
            this.txt_Comment.Multiline = true;
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(350, 25);
            this.txt_Comment.TabIndex = 5;
            // 
            // btn_AddComment
            // 
            this.btn_AddComment.Location = new System.Drawing.Point(428, 276);
            this.btn_AddComment.Name = "btn_AddComment";
            this.btn_AddComment.Size = new System.Drawing.Size(90, 23);
            this.btn_AddComment.TabIndex = 6;
            this.btn_AddComment.Text = "Comment";
            this.btn_AddComment.UseVisualStyleBackColor = true;
            this.btn_AddComment.Click += new System.EventHandler(this.btn_AddComment_Click);
            // 
            // FullPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(620, 643);
            this.Controls.Add(this.btn_AddComment);
            this.Controls.Add(this.txt_Comment);
            this.Controls.Add(this.lbl_Comments);
            this.Controls.Add(this.lbl_DateInfo);
            this.Controls.Add(this.lbl_CreatorInfo);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.lbl_Title);
            this.MaximumSize = new System.Drawing.Size(638, 690);
            this.Name = "FullPost";
            this.Text = "FullPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Label lbl_CreatorInfo;
        private System.Windows.Forms.Label lbl_DateInfo;
        private System.Windows.Forms.Label lbl_Comments;
        public System.Windows.Forms.TextBox txt_Comment;
        public System.Windows.Forms.Button btn_AddComment;
    }
}