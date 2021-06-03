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
    public partial class addNewBook : Form
    {
        public addNewBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addnewBooKOk_Click(object sender, EventArgs e)
        {
            Program.newBookName = addnewBookBox.Text;
            this.Close();

        }

        private void addnewBookCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void addNewBook_Load(object sender, EventArgs e)
        {

        }
    }
}
