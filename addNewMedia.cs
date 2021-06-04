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
    public partial class addNewMedia : Form
    {
        public addNewMedia()
        {
            InitializeComponent();
        }

        // Adding a click event on "Ok" button
        private void addnewMediaOk_Click(object sender, EventArgs e)
        {
            Program.newMediaName = addnewMediaBox.Text;
            this.Close();

        }

        // Adding a click event on "Cancel" button
        private void addnewMediaCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
