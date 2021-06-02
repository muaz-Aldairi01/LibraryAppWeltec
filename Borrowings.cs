using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppWeltec
{
    class Borrowings
    {
        //Fields
        private string borrowingName;
        private string isbn;
        private string author;
        private int publishedYear;
        private string type;
        private DateTime dueDate;
        private bool isRenewed;
        private int overDueDays;
        private int penalty;

        //properties
        public string BorrowingName { get => borrowingName; set => borrowingName = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Author { get => author; set => author = value; }
        public int PublishedYear { get => publishedYear; set => publishedYear = value; }
        public string Type { get => type; set => type = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public bool IsRenewed { get => isRenewed; set => isRenewed = value; }

        public int OverDueDays { get => overDueDays; set => overDueDays = value; }

        public int Penalty { get => penalty; set => penalty = value; }
    }
}
