﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAppWeltec
{
    public partial class librarianForm : Form
    {
  
        SortedDictionary<string, Books> bookinfo = new SortedDictionary<string, Books>();

        static string[] book_headings = new string[6]; 

        Books selectedBook = new Books();


        SortedDictionary<string, Articles> articleinfo = new SortedDictionary<string, Articles>();

        static string[] article_headings = new string[6];

        Articles selectedArticle = new Articles();


        SortedDictionary<string, Media> mediainfo = new SortedDictionary<string, Media>();

        static string[] media_headings = new string[6];

        Media selectedMedia = new Media();

        public librarianForm()
        {
            InitializeComponent();

            // books
            var book_path = @"../../datafiles/Books.csv"; 
            string[] book_lines = System.IO.File.ReadAllLines(book_path);
            foreach (string line in book_lines)
            {

                if (line.StartsWith("Book-Name"))

                    book_headings = line.Split(',');

                   
                else
                {
                    string[] info = line.Split(',');

                    bookinfo.Add(info[0], new Books
                    {

                        Price = Convert.ToDouble(info[1]),
                        Isbn = info[2],
                        Author = info[3],
                        PublishedYear = Int32.Parse(info[4]),
                    });
                }
            }

            // Articles 

            var article_path = @"../../datafiles/Articles.csv";
            string[] article_lines = System.IO.File.ReadAllLines(article_path);
            foreach (string line in article_lines)
            {

                if (line.StartsWith("Article-Name"))

                    article_headings = line.Split(',');


                else
                {
                    string[] info = line.Split(',');

                    articleinfo.Add(info[0], new Articles
                    {

                        Price = Convert.ToDouble(info[1]),
                        Isbn = info[2],
                        Author = info[3],
                        PublishedYear = Int32.Parse(info[4]),
                    });
                }
            }

            // Media

            var media_path = @"../../datafiles/Media.csv";
            string[] media_lines = System.IO.File.ReadAllLines(media_path);
            foreach (string line in media_lines)
            {

                if (line.StartsWith("Media-Name"))

                    media_headings = line.Split(',');


                else
                {
                    string[] info = line.Split(',');

                    mediainfo.Add(info[0], new Media
                    {

                        Price = Convert.ToDouble(info[1]),
                        Isbn = info[2],
                        Author = info[3],
                        PublishedYear = Int32.Parse(info[4]),
                    });
                }
            }

            refreshForm(); 

        }

        private void refreshForm()
        {

            displayBooksinbooklistbox();
            displayArticlesinarticlelistbox();
            displayMediainmedialistbox();

        }



        private void displayBooksinbooklistbox()
        {

            booklistbox_l.DataSource = new BindingSource(bookinfo, null);      

            booklistbox_l.ValueMember = "Key";

        }

        private void displayArticlesinarticlelistbox()
        {

            articlelistbox_l.DataSource = new BindingSource(articleinfo, null);      

            articlelistbox_l.ValueMember = "Key";

        }

        private void displayMediainmedialistbox()
        {

            medialistbox_l.DataSource = new BindingSource(mediainfo, null);     

            medialistbox_l.ValueMember = "Key";

        }


        private void booklistbox_l_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookinfo.ContainsKey(booklistbox_l.SelectedValue.ToString()))

             
                selectedBook = bookinfo[booklistbox_l.SelectedValue.ToString()];

            
            label2.Text = booklistbox_l.Items.Count.ToString();


            

            priceBox.Text = selectedBook.Price.ToString();
            isbnBox.Text = selectedBook.Isbn;
            authorBox.Text = selectedBook.Author;
            yearBox.Text = selectedBook.PublishedYear.ToString();

        }

        private void articlelistbox_l_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (articleinfo.ContainsKey(articlelistbox_l.SelectedValue.ToString()))

              
                selectedArticle = articleinfo[articlelistbox_l.SelectedValue.ToString()];

         
            label4.Text = articlelistbox_l.Items.Count.ToString();


            priceBox.Text = selectedArticle.Price.ToString();
            isbnBox.Text = selectedArticle.Isbn;
            authorBox.Text = selectedArticle.Author;
            yearBox.Text = selectedArticle.PublishedYear.ToString();
        }

        private void medialistbox_l_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mediainfo.ContainsKey(medialistbox_l.SelectedValue.ToString()))

             
                selectedMedia = mediainfo[medialistbox_l.SelectedValue.ToString()];

            
            label6.Text = medialistbox_l.Items.Count.ToString();


            priceBox.Text = selectedMedia.Price.ToString();
            isbnBox.Text = selectedMedia.Isbn;
            authorBox.Text = selectedMedia.Author;
            yearBox.Text = selectedMedia.PublishedYear.ToString();
        }


        // Add book button
        private void addBookbtn_Click(object sender, EventArgs e)
        {

            addNewBook ab = new addNewBook();

            ab.FormClosed += new FormClosedEventHandler(addBookFormClosed);

            ab.Show(); 
        }

        void addBookFormClosed(object sender, FormClosedEventArgs e)
        {

            if (Program.newBookName != null)
                bookinfo.Add(Program.newBookName, new Books
                {
                    Price = 0,
                    Isbn = null,
                    Author = null,
                    PublishedYear = 0,
                 
                });

            Program.newBookName = null;
            displayBooksinbooklistbox();
        }

       
        // Remove book button
        private void removeBookbtn_Click(object sender, EventArgs e)
        {
            bookinfo.Remove(booklistbox_l.SelectedValue.ToString()); 
            refreshForm();
        }


        // Add article button

        private void addArticlebtn_Click(object sender, EventArgs e)
        {
            addNewArticle ab = new addNewArticle();

            ab.FormClosed += new FormClosedEventHandler(addArticleFormClosed);

            ab.Show();

        }

        void addArticleFormClosed(object sender, FormClosedEventArgs e)
        {

            if (Program.newArticleName != null)
                articleinfo.Add(Program.newArticleName, new Articles
                {
                    Price = 0,
                    Isbn = null,
                    Author = null,
                    PublishedYear = 0,

                });

            Program.newArticleName = null;
            displayArticlesinarticlelistbox();
        }

       
        // Remove article button

        private void removeArticlebtn_Click(object sender, EventArgs e)
        {
            articleinfo.Remove(articlelistbox_l.SelectedValue.ToString());
            refreshForm();
        }


        // Add media button
        private void addMediabtn_Click(object sender, EventArgs e)
        {
            addNewMedia ab = new addNewMedia();

            ab.FormClosed += new FormClosedEventHandler(addMediaFormClosed);

            ab.Show();
        }

        void addMediaFormClosed(object sender, FormClosedEventArgs e)
        {

            if (Program.newMediaName != null)
                mediainfo.Add(Program.newMediaName, new Media
                {
                    Price = 0,
                    Isbn = null,
                    Author = null,
                    PublishedYear = 0,

                });

            Program.newMediaName = null;
            displayMediainmedialistbox();
        }


        // Remove media button

        private void removeMediabtn_Click(object sender, EventArgs e)
        {
            mediainfo.Remove(medialistbox_l.SelectedValue.ToString());
            refreshForm();
        }


        // save changes button
        private void saveChanges_Click(object sender, EventArgs e)
        {
            selectedBook.Price = Double.Parse(priceBox.Text);
            selectedBook.Isbn = isbnBox.Text;
            selectedBook.Author = authorBox.Text;
            selectedBook.PublishedYear = Int32.Parse(yearBox.Text);

            selectedArticle.Price = Double.Parse(priceBox.Text);
            selectedArticle.Isbn = isbnBox.Text;
            selectedArticle.Author = authorBox.Text;
            selectedArticle.PublishedYear = Int32.Parse(yearBox.Text);

            selectedMedia.Price = Double.Parse(priceBox.Text);
            selectedMedia.Isbn = isbnBox.Text;
            selectedMedia.Author = authorBox.Text;
            selectedMedia.PublishedYear = Int32.Parse(yearBox.Text);
        }


        private void librarianForm_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_l_TextChanged(object sender, EventArgs e)
        {
            if (searchBox_l.Text != "") 
            {
                if (searchBox_l.Text.Length == 1)
                { 
                    searchBox_l.Text = searchBox_l.Text.ToString().ToUpper();
                    searchBox_l.Select(searchBox_l.Text.Length, 0);
                }
                // search books
                var filtered_book = bookinfo.Where(d => d.Key.Contains(searchBox_l.Text)).ToDictionary(d => d.Key, d => d.Value);

                if (filtered_book.Count > 0)
                {                   

                    booklistbox_l.DataSource = new BindingSource(filtered_book, null);
                    booklistbox_l.ValueMember = "Key";
                    noresultlbl_l.Visible = false; 
                    resultlbl_l.Visible = true;
                    
                    if (filtered_book.Count == 1) resultlbl_l.Text = filtered_book.Count + " match";

                    else resultlbl_l.Text = filtered_book.Count + " matches";
                }
                else
                {
                    noresultlbl_l.Visible = true; 
                    resultlbl_l.Visible = false; 
                }

                // search articles

                var filtered_article = articleinfo.Where(d => d.Key.Contains(searchBox_l.Text)).ToDictionary(d => d.Key, d => d.Value);

                if (filtered_article.Count > 0)
                {

                    articlelistbox_l.DataSource = new BindingSource(filtered_article, null);
                    articlelistbox_l.ValueMember = "Key";
                    noresultlbl_l.Visible = false;
                    resultlbl_l.Visible = true;

                    if (filtered_article.Count == 1) resultlbl_l.Text = filtered_article.Count + " match";

                    else resultlbl_l.Text = filtered_article.Count + " matches";
                }
                if (filtered_article.Count == 0)
                {
                    noresultlbl_l.Visible = true;
                    resultlbl_l.Visible = false;
                }

                // search media
                var filtered_media = mediainfo.Where(d => d.Key.Contains(searchBox_l.Text)).ToDictionary(d => d.Key, d => d.Value);

                if (filtered_media.Count > 0)
                {

                    medialistbox_l.DataSource = new BindingSource(filtered_media, null);
                    medialistbox_l.ValueMember = "Key";
                    noresultlbl_l.Visible = false;
                    resultlbl_l.Visible = true;

                    if (filtered_media.Count == 1) resultlbl_l.Text = filtered_media.Count + " match";

                    else resultlbl_l.Text = filtered_media.Count + " matches";
                }
                else
                {
                    noresultlbl_l.Visible = true;
                    resultlbl_l.Visible = false;
                }

            }
            else
            {
                displayBooksinbooklistbox();
                displayArticlesinarticlelistbox();
                displayMediainmedialistbox();
                resultlbl_l.Visible = noresultlbl_l.Visible = false;
            }

        }
    }
}
