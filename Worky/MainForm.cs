using System;
using System.Windows.Forms;
using Worky.Model;

namespace Worky
{
    public partial class MainForm : Form
    {
        public MainViewModel ViewModel { get; set; }

        public MainForm()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();

            DataBindings.Add("Text", ViewModel, "Caption");
            textBoxWorkTimeToday.DataBindings.Add("Text", ViewModel, "WorkingTimeToday");
            textBoxPausingTimeToday.DataBindings.Add("Text", ViewModel, "PauseTimeToday");
            textBoxWorkTimeWeek.DataBindings.Add("Text", ViewModel, "WorkingTimeThisWeek");
            textBoxWorkTimeMonth.DataBindings.Add("Text", ViewModel, "WorkingTimeThisMonth");
            radioButtonWorking.DataBindings.Add("Checked", ViewModel, "IsWorking", false, DataSourceUpdateMode.OnPropertyChanged);
            radioButtonPausing.DataBindings.Add("Checked", ViewModel, "IsPausing", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewModel.Close();
        }

        private void Timer_Ticked(object sender, EventArgs e)
        {
            ViewModel.UpdateTimes();
        }
    }
}
