using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppWeltec
{
    class Books
    {
        //Fields
        private string bookName;
        private double price;
        private string isbn;
        private string author;
        private int publishedYear;
        

        //properties
        public string BookName { get => bookName; set => bookName = value; }
        public double Price { get => price; set => price = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Author { get => author; set => author = value; }

        public int PublishedYear { get => publishedYear; set => publishedYear = value; }

    }
}
