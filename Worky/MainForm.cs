using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worky.Interfaces;
using Worky.Model;

namespace Worky
{
    public partial class MainForm : Form
    {
        public IActivity Activity { get; private set; }
        public MainViewModel ViewModel { get; set; }

        public MainForm(IActivity activity)
        {
            InitializeComponent();
            Activity = activity;
            ViewModel = new MainViewModel();
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;

            textBoxWorkTimeToday.DataBindings.Add("Text", ViewModel, "WorkingTimeToday");
            textBoxPausingTimeToday.DataBindings.Add("Text", ViewModel, "PauseTimeToday");
            textBoxWorkTimeWeek.DataBindings.Add("Text", ViewModel, "WorkingTimeThisWeek");
            textBoxWorkTimeMonth.DataBindings.Add("Text", ViewModel, "WorkingTimeThisMonth");
            radioButtonWorking.DataBindings.Add("Checked", ViewModel, "IsWorking", false, DataSourceUpdateMode.OnPropertyChanged);
            radioButtonPausing.DataBindings.Add("Checked", ViewModel, "IsPausing", false, DataSourceUpdateMode.OnPropertyChanged);

            SetWorkingStateToCaption();
        }

        private void SetWorkingStateToCaption()
        {
            Text = ViewModel.Caption;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SetWorkingStateToCaption();
        }

        //private void CheckBoxWorkingCheckedChanged(object sender, EventArgs e)
        //{
        //    CheckBox cb = (CheckBox)sender;
        //    if (!cb.Checked)
        //        return;

        //    //checkBoxPausing.Checked = false;
        //    //Activity.StartWorking();
        //}

        //private void CheckBoxPausingCheckedChanged(object sender, EventArgs e)
        //{
        //    CheckBox cb = (CheckBox)sender;
        //    if (!cb.Checked)
        //        return;

        //    //checkBoxWorking.Checked = false;
        //    //Activity.StartPausing();
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            //checkBoxWorking.Checked = true;
            //checkBoxPausing.Checked = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Activity.EndWorking();
            ViewModel.Close();
        }

        private void Timer_Ticked(object sender, EventArgs e)
        {
            ViewModel.UpdateTimes();
            //textBoxWorkTimeToday.Invalidate();
        }

        //private void RadioButtonWorkingCheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void RadioButtonPausingCheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
