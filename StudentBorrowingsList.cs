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
        //Dictionary to store all student borrowings
        SortedDictionary<string, Borrowings> borrowinginfo = new SortedDictionary<string, Borrowings>();

        static string[] borrowing_headings = new string[6];

        Borrowings selectedBorrowing = new Borrowings();

        public StudentBorrowingsList()
        {
            InitializeComponent();

            // reading data from StudentBorrowings file and store them in the dictionary borrowinginfo

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

        // creating method for loading data into studentlistbox 
        private void refreshForm()
        {

            displayBorrowingsinstudentlistbox();

        }

        // creating method to display Borrowings in studentlistbox
        private void displayBorrowingsinstudentlistbox()
        {
            //bind studentlistbox to borrowinginfo Dictionary collection.

            studentlistbox.DataSource = new BindingSource(borrowinginfo, null);     
            studentlistbox.ValueMember = "Key";

        }

        // Adding an event "Selectedindexchanged" on tutorlistbox
        private void studentlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateOverDueDays();

            if (borrowinginfo.ContainsKey(studentlistbox.SelectedValue.ToString()))

            selectedBorrowing = borrowinginfo[studentlistbox.SelectedValue.ToString()];
            label2.Text = studentlistbox.Items.Count.ToString();
            isbnBox.Text = selectedBorrowing.Isbn;
            authorBox.Text = selectedBorrowing.Author;
            yearBox.Text = selectedBorrowing.PublishedYear.ToString();
            typeBox.Text = selectedBorrowing.Type;
            dueDateBox.Text = selectedBorrowing.DueDate.ToString();
            isRenewedBox.Text = selectedBorrowing.IsRenewed.ToString();
            overdueDaysBox.Text = selectedBorrowing.OverDueDays.ToString();
            penaltyBox.Text = "$" + selectedBorrowing.Penalty.ToString();

        }

        // creating method to calculate overdue days and the panelty
        private void calculateOverDueDays()
        {
            selectedBorrowing.OverDueDays = (DateTime.Now - selectedBorrowing.DueDate).Days;
            if (selectedBorrowing.OverDueDays > 0)
            {                
                selectedBorrowing.Penalty = selectedBorrowing.OverDueDays * 5;
            }
            else
            {
                selectedBorrowing.OverDueDays = 0;
            }

        }
    }
}
