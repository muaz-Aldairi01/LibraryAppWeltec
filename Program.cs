using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAppWeltec
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        // declaring the following globle variables to be able to use them in all forms.
        public static string newBookName = null;
        public static string newArticleName = null;
        public static string newMediaName = null;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibraryAppForm());
        }
    }
}
