using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worky.Extensions;

namespace Worky.Model
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly string TIME_FORMAT = @"hh\:mm\:ss";

        public event PropertyChangedEventHandler PropertyChanged;

        private WorkingData _workingData = new WorkingData();

        private string _workingTimeToday = string.Empty;
        private string _pausingTimeToday = string.Empty;
        private string _workingTimeThisWeek = string.Empty;

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
                OnPropertyChanged(PropertyHelper.CallerName());
            }
        }
        public string PauseTimeToday
        {
            get { return _pausingTimeToday; }
            set
            {
                _pausingTimeToday = value;
                OnPropertyChanged(PropertyHelper.CallerName());
            }
        }
        public string WorkingTimeThisWeek
        {
            get { return _workingTimeThisWeek; }
            set
            {
                _workingTimeThisWeek = value;

                OnPropertyChanged(PropertyHelper.CallerName());
            }
        }
        public string WorkingTimeThisMonth { get; set; }// = "working this month";

        public bool IsWorking
        {
            get { return _workingData.State == WorkingState.Working; }
            set
            {
                _workingData.State = (value) ? WorkingState.Working : WorkingState.Pausing;
                OnPropertyChanged(PropertyHelper.CallerName());
            }
        }
        public bool IsPausing
        {
            get { return _workingData.IsPausing; }
            set
            {
                _workingData.State = (value) ? WorkingState.Pausing : WorkingState.Working;
                OnPropertyChanged(PropertyHelper.CallerName());
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
            WorkingTimeThisWeek = _workingData.WorkTimeThisWeek.ToString(TIME_FORMAT);
            WorkingTimeThisMonth = _workingData.WorkTimeThisMonth.ToString(TIME_FORMAT);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

