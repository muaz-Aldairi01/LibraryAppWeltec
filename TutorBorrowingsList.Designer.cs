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
            this.tutorList.Location = new System.Drawing.Point(70, 79);
            this.tutorList.Name = "tutorList";
            this.tutorList.Size = new System.Drawing.Size(269, 361);
            this.tutorList.TabIndex = 0;
            this.tutorList.TabStop = false;
            this.tutorList.Text = "Borrowing List";
            // 
            // tutorlistbox
            // 
            this.tutorlistbox.FormattingEnabled = true;
            this.tutorlistbox.ItemHeight = 20;
            this.tutorlistbox.Location = new System.Drawing.Point(6, 35);
            this.tutorlistbox.Name = "tutorlistbox";
            this.tutorlistbox.Size = new System.Drawing.Size(241, 304);
            this.tutorlistbox.TabIndex = 0;
            this.tutorlistbox.SelectedIndexChanged += new System.EventHandler(this.tutorListBox_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(669, 275);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(173, 26);
            this.typeBox.TabIndex = 1;
            // 
            // dueDateBox
            // 
            this.dueDateBox.Location = new System.Drawing.Point(669, 339);
            this.dueDateBox.Name = "dueDateBox";
            this.dueDateBox.Size = new System.Drawing.Size(173, 26);
            this.dueDateBox.TabIndex = 2;
            // 
            // isRenewedBox
            // 
            this.isRenewedBox.Location = new System.Drawing.Point(669, 392);
            this.isRenewedBox.Name = "isRenewedBox";
            this.isRenewedBox.Size = new System.Drawing.Size(173, 26);
            this.isRenewedBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(542, 278);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(43, 20);
            this.type.TabIndex = 6;
            this.type.Text = "Type";
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Location = new System.Drawing.Point(524, 339);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(75, 20);
            this.dueDate.TabIndex = 7;
            this.dueDate.Text = "Due date";
            // 
            // isRenewed
            // 
            this.isRenewed.AutoSize = true;
            this.isRenewed.Location = new System.Drawing.Point(515, 395);
            this.isRenewed.Name = "isRenewed";
            this.isRenewed.Size = new System.Drawing.Size(96, 20);
            this.isRenewed.TabIndex = 8;
            this.isRenewed.Text = "Is renewed?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Year";
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(669, 87);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(173, 26);
            this.isbnBox.TabIndex = 15;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(669, 145);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(173, 26);
            this.authorBox.TabIndex = 16;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(669, 212);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(173, 26);
            this.yearBox.TabIndex = 17;
            this.yearBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // TutorBorrowingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 519);
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