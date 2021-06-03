namespace LibraryAppWeltec
{
    partial class addNewArticle
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
            this.addnewArticleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addnewArticleCancel = new System.Windows.Forms.Button();
            this.addnewArticleOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addnewArticleBox
            // 
            this.addnewArticleBox.Location = new System.Drawing.Point(409, 80);
            this.addnewArticleBox.Name = "addnewArticleBox";
            this.addnewArticleBox.Size = new System.Drawing.Size(249, 26);
            this.addnewArticleBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the name for new article";
            // 
            // addnewArticleCancel
            // 
            this.addnewArticleCancel.Location = new System.Drawing.Point(528, 192);
            this.addnewArticleCancel.Name = "addnewArticleCancel";
            this.addnewArticleCancel.Size = new System.Drawing.Size(130, 47);
            this.addnewArticleCancel.TabIndex = 5;
            this.addnewArticleCancel.Text = "Cancel";
            this.addnewArticleCancel.UseVisualStyleBackColor = true;
            this.addnewArticleCancel.Click += new System.EventHandler(this.addnewArticleCancel_Click);
            // 
            // addnewArticleOk
            // 
            this.addnewArticleOk.Location = new System.Drawing.Point(225, 192);
            this.addnewArticleOk.Name = "addnewArticleOk";
            this.addnewArticleOk.Size = new System.Drawing.Size(144, 47);
            this.addnewArticleOk.TabIndex = 4;
            this.addnewArticleOk.Text = "Ok";
            this.addnewArticleOk.UseVisualStyleBackColor = true;
            this.addnewArticleOk.Click += new System.EventHandler(this.addnewArticleOk_Click);
            // 
            // addNewArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.addnewArticleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnewArticleCancel);
            this.Controls.Add(this.addnewArticleOk);
            this.Name = "addNewArticle";
            this.Text = "Add New Article";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addnewArticleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnewArticleCancel;
        private System.Windows.Forms.Button addnewArticleOk;
    }
}