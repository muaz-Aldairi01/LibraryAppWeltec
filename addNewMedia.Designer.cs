namespace LibraryAppWeltec
{
    partial class addNewMedia
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
            this.addnewMediaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addnewMediaCancel = new System.Windows.Forms.Button();
            this.addnewMediaOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addnewMediaBox
            // 
            this.addnewMediaBox.Location = new System.Drawing.Point(409, 119);
            this.addnewMediaBox.Name = "addnewMediaBox";
            this.addnewMediaBox.Size = new System.Drawing.Size(249, 26);
            this.addnewMediaBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter the name for new media";
            // 
            // addnewMediaCancel
            // 
            this.addnewMediaCancel.Location = new System.Drawing.Point(455, 190);
            this.addnewMediaCancel.Name = "addnewMediaCancel";
            this.addnewMediaCancel.Size = new System.Drawing.Size(130, 47);
            this.addnewMediaCancel.TabIndex = 9;
            this.addnewMediaCancel.Text = "Cancel";
            this.addnewMediaCancel.UseVisualStyleBackColor = true;
            this.addnewMediaCancel.Click += new System.EventHandler(this.addnewMediaCancel_Click);
            // 
            // addnewMediaOk
            // 
            this.addnewMediaOk.Location = new System.Drawing.Point(219, 190);
            this.addnewMediaOk.Name = "addnewMediaOk";
            this.addnewMediaOk.Size = new System.Drawing.Size(144, 47);
            this.addnewMediaOk.TabIndex = 8;
            this.addnewMediaOk.Text = "Ok";
            this.addnewMediaOk.UseVisualStyleBackColor = true;
            this.addnewMediaOk.Click += new System.EventHandler(this.addnewMediaOk_Click);
            // 
            // addNewMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.addnewMediaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnewMediaCancel);
            this.Controls.Add(this.addnewMediaOk);
            this.Name = "addNewMedia";
            this.Text = "Add New Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addnewMediaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnewMediaCancel;
        private System.Windows.Forms.Button addnewMediaOk;
    }
}