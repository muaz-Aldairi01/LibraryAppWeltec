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
    public partial class StudentForm : Form
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


        public StudentForm()
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
            //bind booklistbox to bookinfo Dictionary collection.

            articlelistbox_l.DataSource = new BindingSource(articleinfo, null);

            //display the entries by key. Read about Listbox control here      

            articlelistbox_l.ValueMember = "Key";

        }

        private void displayMediainmedialistbox()
        {
            //bind booklistbox to bookinfo Dictionary collection.

            medialistbox_l.DataSource = new BindingSource(mediainfo, null);

            //display the entries by key. Read about Listbox control here      

            medialistbox_l.ValueMember = "Key";

        }

        private void booklistbox_l_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookinfo.ContainsKey(booklistbox_l.SelectedValue.ToString()))

                //update selected Book
                selectedBook = bookinfo[booklistbox_l.SelectedValue.ToString()];

            // Just for count of no. of entries in both listboxes
            label2.Text = booklistbox_l.Items.Count.ToString();


            // Question: from where and how are these (below) data coming?

            priceBox.Text = selectedBook.Price.ToString();
            isbnBox.Text = selectedBook.Isbn;
            authorBox.Text = selectedBook.Author;
            yearBox.Text = selectedBook.PublishedYear.ToString();

        }

        private void articlelistbox_l_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (articleinfo.ContainsKey(articlelistbox_l.SelectedValue.ToString()))

                //update selected Book
                selectedArticle = articleinfo[articlelistbox_l.SelectedValue.ToString()];

            // Just for count of no. of entries in both listboxes
            label4.Text = articlelistbox_l.Items.Count.ToString();


            // Question: from where and how are these (below) data coming?

            priceBox.Text = selectedArticle.Price.ToString();
            isbnBox.Text = selectedArticle.Isbn;
            authorBox.Text = selectedArticle.Author;
            yearBox.Text = selectedArticle.PublishedYear.ToString();
        }

        private void medialistbox_l_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mediainfo.ContainsKey(medialistbox_l.SelectedValue.ToString()))

                //update selected Book
                selectedMedia = mediainfo[medialistbox_l.SelectedValue.ToString()];

            // Just for count of no. of entries in both listboxes
            label6.Text = medialistbox_l.Items.Count.ToString();


            // Question: from where and how are these (below) data coming?

            priceBox.Text = selectedMedia.Price.ToString();
            isbnBox.Text = selectedMedia.Isbn;
            authorBox.Text = selectedMedia.Author;
            yearBox.Text = selectedMedia.PublishedYear.ToString();

        }
    }
}

