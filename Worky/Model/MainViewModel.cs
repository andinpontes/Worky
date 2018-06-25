using System.ComponentModel;
using Worky.Extensions;
using Worky.Interfaces;

namespace Worky.Model
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly string TIME_FORMAT = @"hh\:mm\:ss";

        public event PropertyChangedEventHandler PropertyChanged;

        private WorkingData _workingData;
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
        public string WorkingTimeThisWeek { get; set; }
        public string WorkingTimeThisMonth { get; set; }

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

        public MainViewModel(ITimeStampsReader reader)
        {
            _workingData = new WorkingData(reader);
        }

        public void Start()
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

