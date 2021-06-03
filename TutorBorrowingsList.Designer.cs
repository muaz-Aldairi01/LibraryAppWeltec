namespace LibraryAppWeltec
{
    partial class TutorBorrowingsList
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
            this.tutorList = new System.Windows.Forms.GroupBox();
            this.tutorlistbox = new System.Windows.Forms.ListBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.dueDateBox = new System.Windows.Forms.TextBox();
            this.isRenewedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.dueDate = new System.Windows.Forms.Label();
            this.isRenewed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.tutorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tutorList
            // 
            this.tutorList.Controls.Add(this.tutorlistbox);
            this.tutorList.Location = new System.Drawing.Point(93, 99);
            this.tutorList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tutorList.Name = "tutorList";
            this.tutorList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tutorList.Size = new System.Drawing.Size(359, 451);
            this.tutorList.TabIndex = 0;
            this.tutorList.TabStop = false;
            this.tutorList.Text = "Borrowing List";
            // 
            // tutorlistbox
            // 
            this.tutorlistbox.FormattingEnabled = true;
            this.tutorlistbox.ItemHeight = 25;
            this.tutorlistbox.Location = new System.Drawing.Point(8, 44);
            this.tutorlistbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tutorlistbox.Name = "tutorlistbox";
            this.tutorlistbox.Size = new System.Drawing.Size(320, 379);
            this.tutorlistbox.TabIndex = 0;
            this.tutorlistbox.SelectedIndexChanged += new System.EventHandler(this.tutorListBox_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(630, 301);
            this.typeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(229, 31);
            this.typeBox.TabIndex = 1;
            // 
            // dueDateBox
            // 
            this.dueDateBox.Location = new System.Drawing.Point(630, 382);
            this.dueDateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dueDateBox.Name = "dueDateBox";
            this.dueDateBox.Size = new System.Drawing.Size(229, 31);
            this.dueDateBox.TabIndex = 2;
            // 
            // isRenewedBox
            // 
            this.isRenewedBox.Location = new System.Drawing.Point(630, 425);
            this.isRenewedBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isRenewedBox.Name = "isRenewedBox";
            this.isRenewedBox.Size = new System.Drawing.Size(229, 31);
            this.isRenewedBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 568);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 568);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(522, 301);
            this.type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(60, 25);
            this.type.TabIndex = 6;
            this.type.Text = "Type";
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Location = new System.Drawing.Point(522, 382);
            this.dueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(99, 25);
            this.dueDate.TabIndex = 7;
            this.dueDate.Text = "Due date";
            // 
            // isRenewed
            // 
            this.isRenewed.AutoSize = true;
            this.isRenewed.Location = new System.Drawing.Point(522, 425);
            this.isRenewed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isRenewed.Name = "isRenewed";
            this.isRenewed.Size = new System.Drawing.Size(102, 25);
            this.isRenewed.TabIndex = 8;
            this.isRenewed.Text = "Renewed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Year";
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(630, 143);
            this.isbnBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(229, 31);
            this.isbnBox.TabIndex = 15;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(630, 199);
            this.authorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(229, 31);
            this.authorBox.TabIndex = 16;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(630, 251);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(229, 31);
            this.yearBox.TabIndex = 17;
            this.yearBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // TutorBorrowingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 649);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isRenewed);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isRenewedBox);
            this.Controls.Add(this.dueDateBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.tutorList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TutorBorrowingsList";
            this.Text = "Tutor Borrowings List";
            this.tutorList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tutorList;
        private System.Windows.Forms.ListBox tutorlistbox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox dueDateBox;
        private System.Windows.Forms.TextBox isRenewedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label dueDate;
        private System.Windows.Forms.Label isRenewed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox yearBox;
    }
}