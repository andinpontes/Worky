using System;
using System.Windows.Forms;
using Worky.IO;
using Worky.Model;
using Worky.Extensions;

namespace Worky
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filename = FileLogging.GetMonthlyLogFilename("Worky", ".txt");

            TimeStampsFileReader fileReader = TimeStampsFileReader.FromFile(filename);
            TimeStampsFileWriter fileWriter = TimeStampsFileWriter.FromFile(filename);
            var viewModel = new MainViewModel(fileReader, fileWriter);

            MainForm mainForm = new MainForm(viewModel);
            Application.Run(mainForm);
        }
    }
}
