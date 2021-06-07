namespace LibraryAppWeltec
{
    partial class librarianForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.noResultBookLabel = new System.Windows.Forms.Label();
            this.resultBookLabel = new System.Windows.Forms.Label();
            this.searchlbl_l = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveChanges = new System.Windows.Forms.Button();
            this.removeMediabtn = new System.Windows.Forms.Button();
            this.addMediabtn = new System.Windows.Forms.Button();
            this.addArticlebtn = new System.Windows.Forms.Button();
            this.removeArticlebtn = new System.Windows.Forms.Button();
            this.removeBookbtn = new System.Windows.Forms.Button();
            this.addBookbtn = new System.Windows.Forms.Button();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.searchBox_l = new System.Windows.Forms.TextBox();
            this.AvailableArticles_l = new System.Windows.Forms.GroupBox();
            this.articlelistbox_l = new System.Windows.Forms.ListBox();
            this.AvailableMedia_l = new System.Windows.Forms.GroupBox();
            this.medialistbox_l = new System.Windows.Forms.ListBox();
            this.AvailableBooks_l = new System.Windows.Forms.GroupBox();
            this.booklistbox_l = new System.Windows.Forms.ListBox();
            this.resultArticlelabel = new System.Windows.Forms.Label();
            this.noResultArticleLabel = new System.Windows.Forms.Label();
            this.resultMediaLabel = new System.Windows.Forms.Label();
            this.noResultMediaLabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.AvailableArticles_l.SuspendLayout();
            this.AvailableMedia_l.SuspendLayout();
            this.AvailableBooks_l.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1132, 469);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 25);
            this.label13.TabIndex = 54;
            this.label13.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1132, 408);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 53;
            this.label12.Text = "Author";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1132, 341);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 52;
            this.label11.Text = "ISBN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1132, 278);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 51;
            this.label10.Text = "Price";
            // 
            // noResultBookLabel
            // 
            this.noResultBookLabel.AutoSize = true;
            this.noResultBookLabel.ForeColor = System.Drawing.Color.Red;
            this.noResultBookLabel.Location = new System.Drawing.Point(616, 49);
            this.noResultBookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noResultBookLabel.Name = "noResultBookLabel";
            this.noResultBookLabel.Size = new System.Drawing.Size(295, 25);
            this.noResultBookLabel.TabIndex = 50;
            this.noResultBookLabel.Text = "No Result Found in Books list";
            this.noResultBookLabel.Visible = false;
            // 
            // resultBookLabel
            // 
            this.resultBookLabel.AutoSize = true;
            this.resultBookLabel.Location = new System.Drawing.Point(621, 49);
            this.resultBookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultBookLabel.Name = "resultBookLabel";
            this.resultBookLabel.Size = new System.Drawing.Size(290, 25);
            this.resultBookLabel.TabIndex = 49;
            this.resultBookLabel.Text = "Results found in Books list    ";
            this.resultBookLabel.Visible = false;
            // 
            // searchlbl_l
            // 
            this.searchlbl_l.AutoSize = true;
            this.searchlbl_l.Location = new System.Drawing.Point(192, 89);
            this.searchlbl_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchlbl_l.Name = "searchlbl_l";
            this.searchlbl_l.Size = new System.Drawing.Size(80, 25);
            this.searchlbl_l.TabIndex = 48;
            this.searchlbl_l.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(959, 591);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(835, 591);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "entries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 591);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 591);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "entries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 591);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 591);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "entries";
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(1289, 532);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(164, 52);
            this.saveChanges.TabIndex = 41;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // removeMediabtn
            // 
            this.removeMediabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeMediabtn.Location = new System.Drawing.Point(816, 729);
            this.removeMediabtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeMediabtn.Name = "removeMediabtn";
            this.removeMediabtn.Size = new System.Drawing.Size(173, 66);
            this.removeMediabtn.TabIndex = 40;
            this.removeMediabtn.Text = "Remove Media";
            this.removeMediabtn.UseVisualStyleBackColor = true;
            this.removeMediabtn.Click += new System.EventHandler(this.removeMediabtn_Click);
            // 
            // addMediabtn
            // 
            this.addMediabtn.ForeColor = System.Drawing.Color.Green;
            this.addMediabtn.Location = new System.Drawing.Point(816, 651);
            this.addMediabtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addMediabtn.Name = "addMediabtn";
            this.addMediabtn.Size = new System.Drawing.Size(173, 51);
            this.addMediabtn.TabIndex = 39;
            this.addMediabtn.Text = "Add Media";
            this.addMediabtn.UseVisualStyleBackColor = true;
            this.addMediabtn.Click += new System.EventHandler(this.addMediabtn_Click);
            // 
            // addArticlebtn
            // 
            this.addArticlebtn.ForeColor = System.Drawing.Color.Green;
            this.addArticlebtn.Location = new System.Drawing.Point(479, 651);
            this.addArticlebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addArticlebtn.Name = "addArticlebtn";
            this.addArticlebtn.Size = new System.Drawing.Size(169, 51);
            this.addArticlebtn.TabIndex = 38;
            this.addArticlebtn.Text = "Add Article";
            this.addArticlebtn.UseVisualStyleBackColor = true;
            this.addArticlebtn.Click += new System.EventHandler(this.addArticlebtn_Click);
            // 
            // removeArticlebtn
            // 
            this.removeArticlebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeArticlebtn.Location = new System.Drawing.Point(479, 729);
            this.removeArticlebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeArticlebtn.Name = "removeArticlebtn";
            this.removeArticlebtn.Size = new System.Drawing.Size(169, 66);
            this.removeArticlebtn.TabIndex = 37;
            this.removeArticlebtn.Text = "Remove Article";
            this.removeArticlebtn.UseVisualStyleBackColor = true;
            this.removeArticlebtn.Click += new System.EventHandler(this.removeArticlebtn_Click);
            // 
            // removeBookbtn
            // 
            this.removeBookbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeBookbtn.Location = new System.Drawing.Point(123, 729);
            this.removeBookbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeBookbtn.Name = "removeBookbtn";
            this.removeBookbtn.Size = new System.Drawing.Size(167, 66);
            this.removeBookbtn.TabIndex = 36;
            this.removeBookbtn.Text = "Remove Book";
            this.removeBookbtn.UseVisualStyleBackColor = true;
            this.removeBookbtn.Click += new System.EventHandler(this.removeBookbtn_Click);
            // 
            // addBookbtn
            // 
            this.addBookbtn.ForeColor = System.Drawing.Color.Green;
            this.addBookbtn.Location = new System.Drawing.Point(123, 651);
            this.addBookbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBookbtn.Name = "addBookbtn";
            this.addBookbtn.Size = new System.Drawing.Size(167, 51);
            this.addBookbtn.TabIndex = 35;
            this.addBookbtn.Text = "Add Book";
            this.addBookbtn.UseVisualStyleBackColor = true;
            this.addBookbtn.Click += new System.EventHandler(this.addBookbtn_Click);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(1277, 469);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(187, 31);
            this.yearBox.TabIndex = 34;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(1277, 408);
            this.authorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(187, 31);
            this.authorBox.TabIndex = 33;
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(1277, 341);
            this.isbnBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(187, 31);
            this.isbnBox.TabIndex = 32;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(1277, 278);
            this.priceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(187, 31);
            this.priceBox.TabIndex = 31;
            // 
            // searchBox_l
            // 
            this.searchBox_l.Location = new System.Drawing.Point(311, 86);
            this.searchBox_l.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox_l.Name = "searchBox_l";
            this.searchBox_l.Size = new System.Drawing.Size(263, 31);
            this.searchBox_l.TabIndex = 30;
            this.searchBox_l.TextChanged += new System.EventHandler(this.searchBox_l_TextChanged);
            // 
            // AvailableArticles_l
            // 
            this.AvailableArticles_l.Controls.Add(this.articlelistbox_l);
            this.AvailableArticles_l.Location = new System.Drawing.Point(439, 196);
            this.AvailableArticles_l.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailableArticles_l.Name = "AvailableArticles_l";
            this.AvailableArticles_l.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailableArticles_l.Size = new System.Drawing.Size(267, 378);
            this.AvailableArticles_l.TabIndex = 28;
            this.AvailableArticles_l.TabStop = false;
            this.AvailableArticles_l.Text = "Available Articles";
            // 
            // articlelistbox_l
            // 
            this.articlelistbox_l.FormattingEnabled = true;
            this.articlelistbox_l.ItemHeight = 25;
            this.articlelistbox_l.Location = new System.Drawing.Point(20, 49);
            this.articlelistbox_l.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.articlelistbox_l.Name = "articlelistbox_l";
            this.articlelistbox_l.Size = new System.Drawing.Size(223, 304);
            this.articlelistbox_l.TabIndex = 3;
            this.articlelistbox_l.SelectedIndexChanged += new System.EventHandler(this.articlelistbox_l_SelectedIndexChanged);
            // 
            // AvailableMedia_l
            // 
            this.AvailableMedia_l.Controls.Add(this.medialistbox_l);
            this.AvailableMedia_l.Location = new System.Drawing.Point(792, 196);
            this.AvailableMedia_l.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailableMedia_l.Name = "AvailableMedia_l";
            this.AvailableMedia_l.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailableMedia_l.Size = new System.Drawing.Size(279, 378);
            this.AvailableMedia_l.TabIndex = 29;
            this.AvailableMedia_l.TabStop = false;
            this.AvailableMedia_l.Text = "Available Media ";
            // 
            // medialistbox_l
            // 
            this.medialistbox_l.FormattingEnabled = true;
            this.medialistbox_l.ItemHeight = 25;
            this.medialistbox_l.Location = new System.Drawing.Point(24, 49);
            this.medialistbox_l.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medialistbox_l.Name = "medialistbox_l";
            this.medialistbox_l.Size = new System.Drawing.Size(225, 304);
            this.medialistbox_l.TabIndex = 4;
            this.medialistbox_l.SelectedIndexChanged += new System.EventHandler(this.medialistbox_l_SelectedIndexChanged);
            // 
            // AvailableBooks_l
            // 
            this.AvailableBooks_l.Controls.Add(this.booklistbox_l);
            this.AvailableBooks_l.Location = new System.Drawing.Point(97, 196);
            this.AvailableBooks_l.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailableBooks_l.Name = "AvailableBooks_l";
            this.AvailableBooks_l.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailableBooks_l.Size = new System.Drawing.Size(267, 391);
            this.AvailableBooks_l.TabIndex = 27;
            this.AvailableBooks_l.TabStop = false;
            this.AvailableBooks_l.Text = "Available Books";
            // 
            // booklistbox_l
            // 
            this.booklistbox_l.FormattingEnabled = true;
            this.booklistbox_l.ItemHeight = 25;
            this.booklistbox_l.Location = new System.Drawing.Point(8, 49);
            this.booklistbox_l.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.booklistbox_l.Name = "booklistbox_l";
            this.booklistbox_l.Size = new System.Drawing.Size(229, 304);
            this.booklistbox_l.TabIndex = 2;
            this.booklistbox_l.SelectedIndexChanged += new System.EventHandler(this.booklistbox_l_SelectedIndexChanged);
            // 
            // resultArticlelabel
            // 
            this.resultArticlelabel.AutoSize = true;
            this.resultArticlelabel.Location = new System.Drawing.Point(621, 86);
            this.resultArticlelabel.Name = "resultArticlelabel";
            this.resultArticlelabel.Size = new System.Drawing.Size(295, 25);
            this.resultArticlelabel.TabIndex = 55;
            this.resultArticlelabel.Text = "Results found in Articles list   ";
            this.resultArticlelabel.Visible = false;
            // 
            // noResultArticleLabel
            // 
            this.noResultArticleLabel.AutoSize = true;
            this.noResultArticleLabel.ForeColor = System.Drawing.Color.Red;
            this.noResultArticleLabel.Location = new System.Drawing.Point(617, 86);
            this.noResultArticleLabel.Name = "noResultArticleLabel";
            this.noResultArticleLabel.Size = new System.Drawing.Size(299, 25);
            this.noResultArticleLabel.TabIndex = 56;
            this.noResultArticleLabel.Text = "No Result found in Articles list";
            this.noResultArticleLabel.Visible = false;
            // 
            // resultMediaLabel
            // 
            this.resultMediaLabel.AutoSize = true;
            this.resultMediaLabel.Location = new System.Drawing.Point(621, 124);
            this.resultMediaLabel.Name = "resultMediaLabel";
            this.resultMediaLabel.Size = new System.Drawing.Size(283, 25);
            this.resultMediaLabel.TabIndex = 57;
            this.resultMediaLabel.Text = "Results in Media list             ";
            this.resultMediaLabel.Visible = false;
            // 
            // noResultMediaLabel
            // 
            this.noResultMediaLabel.AutoSize = true;
            this.noResultMediaLabel.ForeColor = System.Drawing.Color.Red;
            this.noResultMediaLabel.Location = new System.Drawing.Point(616, 124);
            this.noResultMediaLabel.Name = "noResultMediaLabel";
            this.noResultMediaLabel.Size = new System.Drawing.Size(287, 25);
            this.noResultMediaLabel.TabIndex = 58;
            this.noResultMediaLabel.Text = "No Result found in Media list";
            this.noResultMediaLabel.Visible = false;
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(1121, 229);
            this.infoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoBox.Name = "infoBox";
            this.infoBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoBox.Size = new System.Drawing.Size(109, 320);
            this.infoBox.TabIndex = 59;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info";
            // 
            // librarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 866);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchlbl_l);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.removeMediabtn);
            this.Controls.Add(this.addMediabtn);
            this.Controls.Add(this.addArticlebtn);
            this.Controls.Add(this.removeArticlebtn);
            this.Controls.Add(this.removeBookbtn);
            this.Controls.Add(this.addBookbtn);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.searchBox_l);
            this.Controls.Add(this.AvailableArticles_l);
            this.Controls.Add(this.AvailableMedia_l);
            this.Controls.Add(this.AvailableBooks_l);
            this.Controls.Add(this.noResultArticleLabel);
            this.Controls.Add(this.noResultMediaLabel);
            this.Controls.Add(this.noResultBookLabel);
            this.Controls.Add(this.resultBookLabel);
            this.Controls.Add(this.resultArticlelabel);
            this.Controls.Add(this.resultMediaLabel);
            this.Controls.Add(this.infoBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "librarianForm";
            this.Text = "Librarian Form";
            this.Load += new System.EventHandler(this.librarianForm_Load);
            this.AvailableArticles_l.ResumeLayout(false);
            this.AvailableMedia_l.ResumeLayout(false);
            this.AvailableBooks_l.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label noResultBookLabel;
        private System.Windows.Forms.Label resultBookLabel;
        private System.Windows.Forms.Label searchlbl_l;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button removeMediabtn;
        private System.Windows.Forms.Button addMediabtn;
        private System.Windows.Forms.Button addArticlebtn;
        private System.Windows.Forms.Button removeArticlebtn;
        private System.Windows.Forms.Button removeBookbtn;
        private System.Windows.Forms.Button addBookbtn;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox searchBox_l;
        private System.Windows.Forms.GroupBox AvailableArticles_l;
        private System.Windows.Forms.ListBox articlelistbox_l;
        private System.Windows.Forms.GroupBox AvailableMedia_l;
        private System.Windows.Forms.ListBox medialistbox_l;
        private System.Windows.Forms.GroupBox AvailableBooks_l;
        private System.Windows.Forms.ListBox booklistbox_l;
        private System.Windows.Forms.Label resultArticlelabel;
        private System.Windows.Forms.Label noResultArticleLabel;
        private System.Windows.Forms.Label resultMediaLabel;
        private System.Windows.Forms.Label noResultMediaLabel;
        private System.Windows.Forms.GroupBox infoBox;
    }
}