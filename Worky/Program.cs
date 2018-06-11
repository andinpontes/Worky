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

            WorkingData data = new WorkingData();
            MainForm mainForm = new MainForm(data);
            Application.Run(mainForm);
        }
    }
}
