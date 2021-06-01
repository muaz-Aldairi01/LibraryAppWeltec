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
        }
    }
}
