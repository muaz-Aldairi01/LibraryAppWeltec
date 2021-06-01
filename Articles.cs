using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppWeltec
{
    class Articles
    {
        //Fields
        private string articleName;
        private double price;
        private string isbn;
        private string author;
        private int publishedYear;


        //properties
        public string BookName { get => articleName; set => articleName = value; }
        public double Price { get => price; set => price = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Author { get => author; set => author = value; }

        public int PublishedYear { get => publishedYear; set => publishedYear = value; }

    }
}
