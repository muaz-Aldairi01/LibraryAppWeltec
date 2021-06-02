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
    public partial class StudentBorrowingsList : Form
    {
        SortedDictionary<string, Borrowings> borrowinginfo = new SortedDictionary<string, Borrowings>();

        static string[] borrowing_headings = new string[6];

        Borrowings selectedBorrowing = new Borrowings();

        public StudentBorrowingsList()
        {
            InitializeComponent();

            var borrowing_path = @"../../datafiles/StudentBorrowings.csv";
            string[] borrowing_lines = System.IO.File.ReadAllLines(borrowing_path);
            foreach (string line in borrowing_lines)
            {

                if (line.StartsWith("Borrowing-Name"))

                    borrowing_headings = line.Split(',');


                else
                {
                    string[] info = line.Split(',');

                    borrowinginfo.Add(info[0], new Borrowings
                    {
                        Isbn = info[1],
                        Author = info[2],
                        PublishedYear = Int32.Parse(info[3]),
                        Type = info[4],
                        DueDate = Convert.ToDateTime(info[5]),
                        IsRenewed = Convert.ToBoolean(info[6])
                        
                    });
                }
            }
            refreshForm();
        }

        private void refreshForm()
        {

            displayBorrowingsinstudentlistbox();

        }

        private void displayBorrowingsinstudentlistbox()
        {
            //bind booklistbox to bookinfo Dictionary collection.

            studentlistbox.DataSource = new BindingSource(borrowinginfo, null);

            //display the entries by key. Read about Listbox control here      

            studentlistbox.ValueMember = "Key";

        }

        private void studentlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (borrowinginfo.ContainsKey(studentlistbox.SelectedValue.ToString()))

                selectedBorrowing = borrowinginfo[studentlistbox.SelectedValue.ToString()];



            label2.Text = studentlistbox.Items.Count.ToString();


            // Question: from where and how are these (below) data coming?

            isbnBox.Text = selectedBorrowing.Isbn;
            authorBox.Text = selectedBorrowing.Author;
            yearBox.Text = selectedBorrowing.PublishedYear.ToString();
            typeBox.Text = selectedBorrowing.Type;
            dueDateBox.Text = selectedBorrowing.DueDate.ToString();
            isRenewedBox.Text = selectedBorrowing.IsRenewed.ToString();
        }
    }
}
