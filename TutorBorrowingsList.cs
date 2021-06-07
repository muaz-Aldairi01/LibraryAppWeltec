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
    public partial class TutorBorrowingsList : Form
    {
        //Dictionary to store all tutor borrowings
        SortedDictionary<string, Borrowings> borrowinginfo = new SortedDictionary<string, Borrowings>();

        static string[] borrowing_headings = new string[6]; 
        
        Borrowings selectedBorrowing = new Borrowings();

        public TutorBorrowingsList()
        {
            InitializeComponent();

            // reading data from TutorBorrowings file and store them in the dictionary borrowinginfo

            var borrowing_path = @"../../datafiles/TutorBorrowings.csv";
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

        // creating method for loading data into tutorlistbox 
        private void refreshForm()
        { 

            displayBorrowingsintutorlistbox();

        }


        // creating method to display Borrowings in tutorlistbox
        private void displayBorrowingsintutorlistbox()
        {
            //bind tutorlistbox to borrowinginfo Dictionary collection.

            tutorlistbox.DataSource = new BindingSource(borrowinginfo, null);    
            tutorlistbox.ValueMember = "Key";

        }

        // Adding an event "Selectedindexchanged" on tutorlistbox
        private void tutorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (borrowinginfo.ContainsKey(tutorlistbox.SelectedValue.ToString()))

            selectedBorrowing = borrowinginfo[tutorlistbox.SelectedValue.ToString()];      
            label2.Text = tutorlistbox.Items.Count.ToString();
            isbnBox.Text = selectedBorrowing.Isbn;
            authorBox.Text = selectedBorrowing.Author;
            yearBox.Text = selectedBorrowing.PublishedYear.ToString();
            typeBox.Text = selectedBorrowing.Type;
            dueDateBox.Text = selectedBorrowing.DueDate.ToString();
            isRenewedBox.Text = selectedBorrowing.IsRenewed.ToString();
        }
    }
}
