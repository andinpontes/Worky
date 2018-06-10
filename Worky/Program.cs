using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worky.Model;

namespace Worky
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

            WorkyData data = new WorkyData();
            MainForm mainForm = new MainForm();
            mainForm.Activity = data;
            Application.Run(mainForm);
        }
    }
}
