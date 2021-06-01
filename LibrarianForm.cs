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

            var article_path = @"../../datafiles/Books.csv";
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

            var media_path = @"../../datafiles/Books.csv";
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
        { //simply calls method below

            displayBooksinbooklistbox();
            displayArticlesinbooklistbox();
            displayMediainbooklistbox();

        }



        private void displayBooksinbooklistbox()
        {
            //bind booklistbox to bookinfo Dictionary collection.

            booklistbox_l.DataSource = new BindingSource(bookinfo, null);

            //display the entries by key. Read about Listbox control here      

            booklistbox_l.ValueMember = "Key";

        }

        private void displayArticlesinbooklistbox()
        {
            //bind booklistbox to bookinfo Dictionary collection.

            articlelistbox_l.DataSource = new BindingSource(articleinfo, null);

            //display the entries by key. Read about Listbox control here      

            articlelistbox_l.ValueMember = "Key";

        }

        private void displayMediainbooklistbox()
        {
            //bind booklistbox to bookinfo Dictionary collection.

            medialistbox_l.DataSource = new BindingSource(mediainfo, null);

            //display the entries by key. Read about Listbox control here      

            medialistbox_l.ValueMember = "Key";

        }

        private void librarianForm_Load(object sender, EventArgs e)
        {

        }
    }
}
