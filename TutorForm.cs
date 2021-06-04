using System;
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
    public partial class TutorForm : Form
    {
        //Dictionary to store all books
        SortedDictionary<string, Books> bookinfo = new SortedDictionary<string, Books>();

        static string[] book_headings = new string[6];

        Books selectedBook = new Books();

        //Dictionary to store all articles
        SortedDictionary<string, Articles> articleinfo = new SortedDictionary<string, Articles>();

        static string[] article_headings = new string[6];

        Articles selectedArticle = new Articles();

        //Dictionary to store all media items
        SortedDictionary<string, Media> mediainfo = new SortedDictionary<string, Media>();

        static string[] media_headings = new string[6];

        Media selectedMedia = new Media();

        
        public TutorForm()
        {
            InitializeComponent();

            // reading data from Books file and store them in the dictionary bookinfo

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

            // reading data from Articles file and store them in the dictionary aticleinfo

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

            // reading data from Media file and store them in the dictionary mediainfo

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

        // creating method for loading data into listboxs 
        private void refreshForm()
        { 
            displayBooksinbooklistbox();
            displayArticlesinarticlelistbox();
            displayMediainmedialistbox();
        }


        // creating method to display Books in booklistbox
        private void displayBooksinbooklistbox()
        {
            //bind booklistbox to bookinfo Dictionary collection.

            booklistbox_l.DataSource = new BindingSource(bookinfo, null);             
            booklistbox_l.ValueMember = "Key";

        }

        // creating method to display Articles in articlelistbox
        private void displayArticlesinarticlelistbox()
        {
            //bind articlelistbox to articleinfo Dictionary collection.

            articlelistbox_l.DataSource = new BindingSource(articleinfo, null);               
            articlelistbox_l.ValueMember = "Key";

        }

        // creating method to display Media items in medialistbox
        private void displayMediainmedialistbox()
        {
            //bind medialistbox to mediainfo Dictionary collection.

            medialistbox_l.DataSource = new BindingSource(mediainfo, null);     
            medialistbox_l.ValueMember = "Key";

        }

        // Adding an event "Selectedindexchanged" on booklistbox
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

        // Adding an event "Selectedindexchanged" on articlelistbox
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

        // Adding an event "Selectedindexchanged" on medialistbox
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

        // searching items from the search bar 

        // Adding  a "TextChanged" event to "searchBox" text box 
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
                    noResultBookLabel.Visible = false;
                    resultBookLabel.Visible = true;

                    if (filtered_book.Count == 1) resultBookLabel.Text = filtered_book.Count + " match in Book list";

                    else resultBookLabel.Text = filtered_book.Count + " matches in Book list";
                }
                else
                {
                    noResultBookLabel.Visible = true;
                    resultBookLabel.Visible = false;
                }

                // search articles

                var filtered_article = articleinfo.Where(d => d.Key.Contains(searchBox_l.Text)).ToDictionary(d => d.Key, d => d.Value);

                if (filtered_article.Count > 0)
                {
                    articlelistbox_l.DataSource = new BindingSource(filtered_article, null);
                    articlelistbox_l.ValueMember = "Key";
                    noResultArticleLabel.Visible = false;
                    resultArticlelabel.Visible = true;

                    if (filtered_article.Count == 1) resultArticlelabel.Text = filtered_article.Count + " match in Article list";

                    else resultArticlelabel.Text = filtered_article.Count + " matches in Article list";
                }
                else
                {
                    noResultArticleLabel.Visible = true;
                    resultArticlelabel.Visible = false;
                }

                // search media
                var filtered_media = mediainfo.Where(d => d.Key.Contains(searchBox_l.Text)).ToDictionary(d => d.Key, d => d.Value);

                if (filtered_media.Count > 0)
                {
                    medialistbox_l.DataSource = new BindingSource(filtered_media, null);
                    medialistbox_l.ValueMember = "Key";
                    noResultMediaLabel.Visible = false;
                    resultMediaLabel.Visible = true;

                    if (filtered_media.Count == 1) resultMediaLabel.Text = filtered_media.Count + " match in Media list";

                    else resultMediaLabel.Text = filtered_media.Count + " matches in Media list";
                }
                else
                {
                    noResultMediaLabel.Visible = true;
                    resultMediaLabel.Visible = false;
                }

            }
            else
            {
                displayBooksinbooklistbox();
                displayArticlesinarticlelistbox();
                displayMediainmedialistbox();
                resultBookLabel.Visible = noResultBookLabel.Visible = false;
                resultArticlelabel.Visible = noResultArticleLabel.Visible = false;
                resultMediaLabel.Visible = noResultMediaLabel.Visible = false;
            }
        }

        private void viewListBtn_Click(object sender, EventArgs e)
        {
            TutorBorrowingsList tbl = new TutorBorrowingsList();
            tbl.Show();
        }
    }
}
