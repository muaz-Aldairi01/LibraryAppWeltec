namespace LibraryAppWeltec
{
    partial class addNewBook
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
            this.addnewBooKOk = new System.Windows.Forms.Button();
            this.addnewBookCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addnewBookBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addnewBooKOk
            // 
            this.addnewBooKOk.Location = new System.Drawing.Point(170, 221);
            this.addnewBooKOk.Name = "addnewBooKOk";
            this.addnewBooKOk.Size = new System.Drawing.Size(144, 47);
            this.addnewBooKOk.TabIndex = 0;
            this.addnewBooKOk.Text = "Ok";
            this.addnewBooKOk.UseVisualStyleBackColor = true;
            this.addnewBooKOk.Click += new System.EventHandler(this.addnewBooKOk_Click);
            // 
            // addnewBookCancel
            // 
            this.addnewBookCancel.Location = new System.Drawing.Point(473, 221);
            this.addnewBookCancel.Name = "addnewBookCancel";
            this.addnewBookCancel.Size = new System.Drawing.Size(130, 47);
            this.addnewBookCancel.TabIndex = 1;
            this.addnewBookCancel.Text = "Cancel";
            this.addnewBookCancel.UseVisualStyleBackColor = true;
            this.addnewBookCancel.Click += new System.EventHandler(this.addnewBookCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the name for new book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addnewBookBox
            // 
            this.addnewBookBox.Location = new System.Drawing.Point(354, 109);
            this.addnewBookBox.Name = "addnewBookBox";
            this.addnewBookBox.Size = new System.Drawing.Size(249, 26);
            this.addnewBookBox.TabIndex = 3;
            // 
            // addNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.addnewBookBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnewBookCancel);
            this.Controls.Add(this.addnewBooKOk);
            this.Name = "addNewBook";
            this.Text = "addNewBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addnewBooKOk;
        private System.Windows.Forms.Button addnewBookCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addnewBookBox;
    }
}