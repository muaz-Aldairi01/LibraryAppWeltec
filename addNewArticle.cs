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
    public partial class addNewArticle : Form
    {
        public addNewArticle()
        {
            InitializeComponent();
        }

        // Adding a click event on "Ok" button
        private void addnewArticleOk_Click(object sender, EventArgs e)
        {
            Program.newArticleName = addnewArticleBox.Text;
            this.Close();

        }

        // Adding a click event on "Cancel" button
        private void addnewArticleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
