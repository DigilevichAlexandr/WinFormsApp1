using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Attribute;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Initialize();
        }
        private static void Initialize()
        {
            Type t = typeof(Form1);
            object[] attributes = t.GetCustomAttributes(typeof(ViewModelAttribute), false);
            if (attributes.Length > 0 && (attributes[0] as ViewModelAttribute).Activated == true)
            {
                Form1 form1 = new Form1();
                ViewModel viewModel = new ViewModel(form1);
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
