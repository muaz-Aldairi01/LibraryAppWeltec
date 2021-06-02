
namespace LibraryAppWeltec
{
    partial class StudentInfoForm
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
            this.borrowedBooksBox = new System.Windows.Forms.ListBox();
            this.borrowedArticlesBox = new System.Windows.Forms.ListBox();
            this.borrowedMediaBox = new System.Windows.Forms.ListBox();
            this.dueDateBox = new System.Windows.Forms.TextBox();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.penaltyBox = new System.Windows.Forms.TextBox();
            this.renewedBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // borrowedBooksBox
            // 
            this.borrowedBooksBox.FormattingEnabled = true;
            this.borrowedBooksBox.ItemHeight = 25;
            this.borrowedBooksBox.Location = new System.Drawing.Point(24, 32);
            this.borrowedBooksBox.Name = "borrowedBooksBox";
            this.borrowedBooksBox.Size = new System.Drawing.Size(300, 479);
            this.borrowedBooksBox.TabIndex = 0;
            // 
            // borrowedArticlesBox
            // 
            this.borrowedArticlesBox.FormattingEnabled = true;
            this.borrowedArticlesBox.ItemHeight = 25;
            this.borrowedArticlesBox.Location = new System.Drawing.Point(354, 32);
            this.borrowedArticlesBox.Name = "borrowedArticlesBox";
            this.borrowedArticlesBox.Size = new System.Drawing.Size(300, 479);
            this.borrowedArticlesBox.TabIndex = 1;
            // 
            // borrowedMediaBox
            // 
            this.borrowedMediaBox.FormattingEnabled = true;
            this.borrowedMediaBox.ItemHeight = 25;
            this.borrowedMediaBox.Location = new System.Drawing.Point(683, 32);
            this.borrowedMediaBox.Name = "borrowedMediaBox";
            this.borrowedMediaBox.Size = new System.Drawing.Size(300, 479);
            this.borrowedMediaBox.TabIndex = 2;
            // 
            // dueDateBox
            // 
            this.dueDateBox.Location = new System.Drawing.Point(1220, 193);
            this.dueDateBox.Name = "dueDateBox";
            this.dueDateBox.Size = new System.Drawing.Size(188, 31);
            this.dueDateBox.TabIndex = 3;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(1084, 196);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(102, 25);
            this.dueDateLabel.TabIndex = 4;
            this.dueDateLabel.Text = "Due Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1089, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Penalty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1084, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Renewed?";
            // 
            // penaltyBox
            // 
            this.penaltyBox.Location = new System.Drawing.Point(1220, 261);
            this.penaltyBox.Name = "penaltyBox";
            this.penaltyBox.Size = new System.Drawing.Size(188, 31);
            this.penaltyBox.TabIndex = 7;
            // 
            // renewedBox
            // 
            this.renewedBox.Location = new System.Drawing.Point(1220, 124);
            this.renewedBox.Name = "renewedBox";
            this.renewedBox.Size = new System.Drawing.Size(188, 31);
            this.renewedBox.TabIndex = 8;
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 579);
            this.Controls.Add(this.renewedBox);
            this.Controls.Add(this.penaltyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.dueDateBox);
            this.Controls.Add(this.borrowedMediaBox);
            this.Controls.Add(this.borrowedArticlesBox);
            this.Controls.Add(this.borrowedBooksBox);
            this.Name = "StudentInfoForm";
            this.Text = "StudentInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox borrowedBooksBox;
        private System.Windows.Forms.ListBox borrowedArticlesBox;
        private System.Windows.Forms.ListBox borrowedMediaBox;
        private System.Windows.Forms.TextBox dueDateBox;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox penaltyBox;
        private System.Windows.Forms.TextBox renewedBox;
    }
}