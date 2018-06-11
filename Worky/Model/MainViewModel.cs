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
        public event PropertyChangedEventHandler PropertyChanged;

        //private WorkingState _state = WorkingState.Working;
        private WorkingData _workingData = new WorkingData();

        public string Caption
        {
            get { return IsWorking ? "bei der Arbeit" : "beim Pausieren"; }
        }
        public string WorkingTimeToday
        {
            get
            {
                //_workingData.TimeStampsOfToday
                return "working today";
            }
        }
        public string PauseTimeToday { get; set; }// = "pausing today";
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

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
