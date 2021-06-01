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
            this.SuspendLayout();
            // 
            // librarianBtn
            // 
            this.librarianBtn.Location = new System.Drawing.Point(162, 292);
            this.librarianBtn.Name = "librarianBtn";
            this.librarianBtn.Size = new System.Drawing.Size(106, 46);
            this.librarianBtn.TabIndex = 0;
            this.librarianBtn.Text = "Librarian";
            this.librarianBtn.UseVisualStyleBackColor = true;
            // 
            // tutorBtn
            // 
            this.tutorBtn.Location = new System.Drawing.Point(390, 292);
            this.tutorBtn.Name = "tutorBtn";
            this.tutorBtn.Size = new System.Drawing.Size(99, 46);
            this.tutorBtn.TabIndex = 1;
            this.tutorBtn.Text = "Tutor";
            this.tutorBtn.UseVisualStyleBackColor = true;
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(614, 292);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(101, 46);
            this.studentBtn.TabIndex = 2;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            // 
            // welcoming
            // 
            this.welcoming.AutoSize = true;
            this.welcoming.Location = new System.Drawing.Point(95, 72);
            this.welcoming.Name = "welcoming";
            this.welcoming.Size = new System.Drawing.Size(305, 20);
            this.welcoming.TabIndex = 3;
            this.welcoming.Text = "Welcom to Learning Commons at WelTec:";
            // 
            // choosingUser
            // 
            this.choosingUser.AutoSize = true;
            this.choosingUser.Location = new System.Drawing.Point(183, 173);
            this.choosingUser.Name = "choosingUser";
            this.choosingUser.Size = new System.Drawing.Size(352, 20);
            this.choosingUser.TabIndex = 4;
            this.choosingUser.Text = "Please choose user type to start (who are you ?):";
            // 
            // LibraryAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 424);
            this.Controls.Add(this.choosingUser);
            this.Controls.Add(this.welcoming);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.tutorBtn);
            this.Controls.Add(this.librarianBtn);
            this.Name = "LibraryAppForm";
            this.Text = "Library App";
            this.Load += new System.EventHandler(this.LibraryAppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button librarianBtn;
        private System.Windows.Forms.Button tutorBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Label welcoming;
        private System.Windows.Forms.Label choosingUser;
    }
}

