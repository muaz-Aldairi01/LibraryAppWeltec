namespace LibraryAppWeltec
{
    partial class LibraryAppForm
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
            this.librarianBtn = new System.Windows.Forms.Button();
            this.tutorBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.welcoming = new System.Windows.Forms.Label();
            this.choosingUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // librarianBtn
            // 
            this.librarianBtn.ForeColor = System.Drawing.Color.Black;
            this.librarianBtn.Location = new System.Drawing.Point(216, 365);
            this.librarianBtn.Margin = new System.Windows.Forms.Padding(4);
            this.librarianBtn.Name = "librarianBtn";
            this.librarianBtn.Size = new System.Drawing.Size(141, 58);
            this.librarianBtn.TabIndex = 0;
            this.librarianBtn.Text = "Librarian";
            this.librarianBtn.UseVisualStyleBackColor = true;
            this.librarianBtn.Click += new System.EventHandler(this.librarianBtn_Click);
            // 
            // tutorBtn
            // 
            this.tutorBtn.Location = new System.Drawing.Point(520, 365);
            this.tutorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.tutorBtn.Name = "tutorBtn";
            this.tutorBtn.Size = new System.Drawing.Size(132, 58);
            this.tutorBtn.TabIndex = 1;
            this.tutorBtn.Text = "Tutor";
            this.tutorBtn.UseVisualStyleBackColor = true;
            this.tutorBtn.Click += new System.EventHandler(this.tutorBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(819, 365);
            this.studentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(135, 58);
            this.studentBtn.TabIndex = 2;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // welcoming
            // 
            this.welcoming.AutoSize = true;
            this.welcoming.Location = new System.Drawing.Point(328, 142);
            this.welcoming.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcoming.Name = "welcoming";
            this.welcoming.Size = new System.Drawing.Size(420, 25);
            this.welcoming.TabIndex = 3;
            this.welcoming.Text = "Welcome to Learning Commons at WelTec";
            // 
            // choosingUser
            // 
            this.choosingUser.AutoSize = true;
            this.choosingUser.Location = new System.Drawing.Point(304, 192);
            this.choosingUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.choosingUser.Name = "choosingUser";
            this.choosingUser.Size = new System.Drawing.Size(470, 25);
            this.choosingUser.TabIndex = 4;
            this.choosingUser.Text = "Please choose user type to start (who are you?)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryAppWeltec.Properties.Resources.weltec;
            this.pictureBox1.Location = new System.Drawing.Point(883, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LibraryAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choosingUser);
            this.Controls.Add(this.welcoming);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.tutorBtn);
            this.Controls.Add(this.librarianBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibraryAppForm";
            this.Text = "Library App";
            this.Load += new System.EventHandler(this.LibraryAppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button librarianBtn;
        private System.Windows.Forms.Button tutorBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Label welcoming;
        private System.Windows.Forms.Label choosingUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

