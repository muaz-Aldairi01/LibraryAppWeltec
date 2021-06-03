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
    public partial class LibraryAppForm : Form
    {
        public LibraryAppForm()
        {
            InitializeComponent();
        }

        private void LibraryAppForm_Load(object sender, EventArgs e)
        {

        }

        private void librarianBtn_Click(object sender, EventArgs e)
        {
            librarianForm lb = new librarianForm();
            lb.Show();
        }

        private void tutorBtn_Click(object sender, EventArgs e)
        {
            TutorForm tf = new TutorForm();
            tf.Show();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();

        }
    }
}
