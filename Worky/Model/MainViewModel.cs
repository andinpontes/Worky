using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worky.Model
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly string TIME_FORMAT = @"hh\:mm\:ss";

        public event PropertyChangedEventHandler PropertyChanged;

        private WorkingData _workingData = new WorkingData();

        private string _workingTimeToday = string.Empty;
        private string _pausingTimeToday = string.Empty;

        public string Caption
        {
            get { return IsWorking ? "bei der Arbeit" : "beim Pausieren"; }
        }
        public string WorkingTimeToday
        {
            get { return _workingTimeToday; }
            set
            {
                _workingTimeToday = value;
                OnPropertyChanged("WorkingTimeToday");
            }
        }
        public string PauseTimeToday
        {
            get { return _pausingTimeToday; }
            set
            {
                _pausingTimeToday = value;
                OnPropertyChanged("PausingTimeToday");
            }
        }
        public string WorkingTimeThisWeek { get; set; }// = "working this week";
        public string WorkingTimeThisMonth { get; set; }// = "working this month";

        public bool IsWorking
        {
            get { return _workingData.State == WorkingState.Working; }
            set
            {
                _workingData.State = (value) ? WorkingState.Working : WorkingState.Pausing;
                OnPropertyChanged("IsWorking");
            }
        }
        public bool IsPausing
        {
            get { return _workingData.IsPausing; }
            set
            {
                _workingData.State = (value) ? WorkingState.Pausing : WorkingState.Working;
                OnPropertyChanged("IsPausing");
            }
        }

        public MainViewModel()
        {
            _workingData.StartWorking();
        }

        public void Close()
        {
            _workingData.EndWorking();
        }
        public void UpdateTimes()
        {
            WorkingTimeToday = _workingData.WorkingTimeToday.ToString(TIME_FORMAT);
            PauseTimeToday = _workingData.PauseTimeToday.ToString(TIME_FORMAT);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

