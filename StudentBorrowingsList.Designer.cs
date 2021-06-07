
namespace LibraryAppWeltec
{
    partial class StudentBorrowingsList
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
            this.yearBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isRenewed = new System.Windows.Forms.Label();
            this.dueDate = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isRenewedBox = new System.Windows.Forms.TextBox();
            this.dueDateBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.tutorList = new System.Windows.Forms.GroupBox();
            this.studentlistbox = new System.Windows.Forms.ListBox();
            this.penaltyBox = new System.Windows.Forms.TextBox();
            this.PenatlyLabel = new System.Windows.Forms.Label();
            this.overduedayslabel = new System.Windows.Forms.Label();
            this.overdueDaysBox = new System.Windows.Forms.TextBox();
            this.tutorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(476, 214);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(173, 26);
            this.yearBox.TabIndex = 32;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(476, 132);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(173, 26);
            this.authorBox.TabIndex = 31;
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(476, 90);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(173, 26);
            this.isbnBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "ISBN";
            // 
            // isRenewed
            // 
            this.isRenewed.AutoSize = true;
            this.isRenewed.Location = new System.Drawing.Point(386, 334);
            this.isRenewed.Name = "isRenewed";
            this.isRenewed.Size = new System.Drawing.Size(77, 20);
            this.isRenewed.TabIndex = 26;
            this.isRenewed.Text = "Renewed";
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Location = new System.Drawing.Point(386, 284);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(75, 20);
            this.dueDate.TabIndex = 25;
            this.dueDate.Text = "Due date";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(385, 172);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(43, 20);
            this.type.TabIndex = 24;
            this.type.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Entries";
            // 
            // isRenewedBox
            // 
            this.isRenewedBox.Location = new System.Drawing.Point(476, 334);
            this.isRenewedBox.Name = "isRenewedBox";
            this.isRenewedBox.Size = new System.Drawing.Size(173, 26);
            this.isRenewedBox.TabIndex = 21;
            // 
            // dueDateBox
            // 
            this.dueDateBox.Location = new System.Drawing.Point(476, 279);
            this.dueDateBox.Name = "dueDateBox";
            this.dueDateBox.Size = new System.Drawing.Size(173, 26);
            this.dueDateBox.TabIndex = 20;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(477, 172);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(173, 26);
            this.typeBox.TabIndex = 19;
            // 
            // tutorList
            // 
            this.tutorList.Controls.Add(this.studentlistbox);
            this.tutorList.Location = new System.Drawing.Point(52, 62);
            this.tutorList.Name = "tutorList";
            this.tutorList.Size = new System.Drawing.Size(269, 361);
            this.tutorList.TabIndex = 18;
            this.tutorList.TabStop = false;
            this.tutorList.Text = "Borrowing List";
            // 
            // studentlistbox
            // 
            this.studentlistbox.FormattingEnabled = true;
            this.studentlistbox.ItemHeight = 20;
            this.studentlistbox.Location = new System.Drawing.Point(13, 26);
            this.studentlistbox.Name = "studentlistbox";
            this.studentlistbox.Size = new System.Drawing.Size(241, 304);
            this.studentlistbox.TabIndex = 0;
            this.studentlistbox.SelectedIndexChanged += new System.EventHandler(this.studentlistbox_SelectedIndexChanged);
            // 
            // penaltyBox
            // 
            this.penaltyBox.Location = new System.Drawing.Point(477, 445);
            this.penaltyBox.Margin = new System.Windows.Forms.Padding(2);
            this.penaltyBox.Name = "penaltyBox";
            this.penaltyBox.Size = new System.Drawing.Size(173, 26);
            this.penaltyBox.TabIndex = 33;
            this.penaltyBox.TextChanged += new System.EventHandler(this.penaltyBox_TextChanged);
            // 
            // PenatlyLabel
            // 
            this.PenatlyLabel.AutoSize = true;
            this.PenatlyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PenatlyLabel.Location = new System.Drawing.Point(352, 445);
            this.PenatlyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PenatlyLabel.Name = "PenatlyLabel";
            this.PenatlyLabel.Size = new System.Drawing.Size(119, 20);
            this.PenatlyLabel.TabIndex = 34;
            this.PenatlyLabel.Text = "Penalty amount";
            // 
            // overduedayslabel
            // 
            this.overduedayslabel.AutoSize = true;
            this.overduedayslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.overduedayslabel.Location = new System.Drawing.Point(354, 403);
            this.overduedayslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.overduedayslabel.Name = "overduedayslabel";
            this.overduedayslabel.Size = new System.Drawing.Size(106, 20);
            this.overduedayslabel.TabIndex = 35;
            this.overduedayslabel.Text = "Days overdue";
            // 
            // overdueDaysBox
            // 
            this.overdueDaysBox.Location = new System.Drawing.Point(476, 403);
            this.overdueDaysBox.Margin = new System.Windows.Forms.Padding(2);
            this.overdueDaysBox.Name = "overdueDaysBox";
            this.overdueDaysBox.Size = new System.Drawing.Size(173, 26);
            this.overdueDaysBox.TabIndex = 36;
            // 
            // StudentBorrowingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 571);
            this.Controls.Add(this.overdueDaysBox);
            this.Controls.Add(this.overduedayslabel);
            this.Controls.Add(this.PenatlyLabel);
            this.Controls.Add(this.penaltyBox);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentBorrowingsList";
            this.Text = "Student Borrowings List";
            this.tutorList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label isRenewed;
        private System.Windows.Forms.Label dueDate;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isRenewedBox;
        private System.Windows.Forms.TextBox dueDateBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.GroupBox tutorList;
        private System.Windows.Forms.ListBox studentlistbox;
        private System.Windows.Forms.TextBox penaltyBox;
        private System.Windows.Forms.Label PenatlyLabel;
        private System.Windows.Forms.Label overduedayslabel;
        private System.Windows.Forms.TextBox overdueDaysBox;
    }
}