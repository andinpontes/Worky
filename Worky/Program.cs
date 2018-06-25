using System;
using System.IO;
using System.Windows.Forms;
using Worky.IO;
using Worky.Model;

namespace Worky
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filetitle = DateTime.Now.ToString("yyyy_MM") + ".txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filename = Path.Combine(path, "Worky", filetitle);

            TimeStampsFileReader fileReader = TimeStampsFileReader.FromFile(filename);
            TimeStampsFileWriter fileWriter = TimeStampsFileWriter.FromFile(filename);
            var viewModel = new MainViewModel(fileReader, fileWriter);

            MainForm mainForm = new MainForm(viewModel);
            Application.Run(mainForm);
        }
    }
}
