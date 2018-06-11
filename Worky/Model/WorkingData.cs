using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worky.Interfaces;

namespace Worky.Model
{
    class WorkingData : IActivity
    {
        private List<TimeStamp> _timeStamps = new List<TimeStamp>();
        private WorkingState _state = WorkingState.Working;

        public WorkingState State
        {
            get { return _state; }
            set
            {
                if (value == WorkingState.Working && _state != WorkingState.Working)
                {
                    StartWorking();
                }
                else if (value == WorkingState.Pausing && _state != WorkingState.Pausing)
                {
                    StartPausing();
                }
                else if (value == WorkingState.Ending && _state != WorkingState.Ending)
                {
                    EndWorking();
                }
            }
        }
        public TimeStamp[] TimeStampsOfToday { get { return _timeStamps.Where(e => e.DateTime > DateTime.Today).ToArray(); } }
        //List<TimeStamp> TimeStampsOfThisWeek { ... }
        //List<TimeStamp> TimeStampsOfThisMonth { ... }
        //TimeSpan WorkTimeToday { ... }
        //TimeSpan PauseTimeToday { ... }
        //TimeSpan WorkTimeThisWeek { ... }
        //TimeSpan WorkTimeThisMonth { ... }
        public bool IsWorking { get { return State == WorkingState.Working; } }
        public bool IsPausing { get { return State == WorkingState.Pausing; } }

        public WorkingData()
        {
            //TODO:
            // read data from file
        }

        public void StartPausing()
        {
            _state = WorkingState.Pausing;
            _timeStamps.Add(new TimeStamp(WorkingState.Pausing));
            //TODO:
            // write data into file
        }

        public void StartWorking()
        {
            _state = WorkingState.Working;
            _timeStamps.Add(new TimeStamp(WorkingState.Working));
            //TODO:
            // write data into file
        }

        public void EndWorking()
        {
            _state = WorkingState.Ending;
            _timeStamps.Add(new TimeStamp(WorkingState.Ending));
            //TODO:
            // write data into file
        }
    }
}
