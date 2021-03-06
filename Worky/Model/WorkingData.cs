﻿using System;
using System.Collections.Generic;
using System.Linq;
using Worky.Extensions;
using Worky.Interfaces;

namespace Worky.Model
{
    class WorkingData
    {
        private ITimeStampsReader _timeStampsReader;
        private ITimeStampsWriter _timeStampsWriter;
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
        public TimeStamp[] TimeStampsOfToday
        {
            get { return _timeStamps.Where(e => e.DateTime > DateTime.Today).ToArray(); }
        }
        public TimeStamp[] TimeStampsOfThisWeek
        {
            get
            {
                DateTime lastMonday = DateTime.Today.StartOfWeek(DayOfWeek.Monday);
                return _timeStamps.Where(e => e.DateTime > lastMonday).ToArray();
            }
        }
        public TimeStamp[] TimeStampsOfThisMonth
        {
            get
            {
                DateTime firstDayThisMonth = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
                return _timeStamps.Where(e => e.DateTime > firstDayThisMonth).ToArray();
            }
        }
        public bool IsWorking { get { return State == WorkingState.Working; } }
        public bool IsPausing { get { return State == WorkingState.Pausing; } }

        public TimeSpan WorkingTimeToday
        {
            get { return CalculateTimeSpan(TimeStampsOfToday, WorkingState.Working); }
        }
        public TimeSpan PauseTimeToday
        {
            get { return CalculateTimeSpan(TimeStampsOfToday, WorkingState.Pausing); }
        }
        public TimeSpan WorkTimeThisWeek
        {
            get { return CalculateTimeSpan(TimeStampsOfThisWeek, WorkingState.Working); }
        }
        public TimeSpan WorkTimeThisMonth
        {
            get { return CalculateTimeSpan(TimeStampsOfThisMonth, WorkingState.Working); }
        }

        public WorkingData(ITimeStampsReader reader, ITimeStampsWriter writer)
        {
            _timeStampsReader = reader ?? throw new ArgumentNullException(nameof(reader));
            _timeStampsWriter = writer ?? throw new ArgumentNullException(nameof(writer));

            IEnumerable<TimeStamp> stamps = _timeStampsReader.Read();
            _timeStamps.AddRange(stamps);
        }

        public void StartPausing()
        {
            _state = WorkingState.Pausing;
            _timeStamps.Add(new TimeStamp(WorkingState.Pausing));
            _timeStampsWriter.Write(_timeStamps);
        }

        public void StartWorking()
        {
            _state = WorkingState.Working;
            _timeStamps.Add(new TimeStamp(WorkingState.Working));
            _timeStampsWriter.Write(_timeStamps);
        }

        public void EndWorking()
        {
            _state = WorkingState.Ending;
            _timeStamps.Add(new TimeStamp(WorkingState.Ending));
            _timeStampsWriter.Write(_timeStamps);
        }

        private TimeSpan CalculateTimeSpan(TimeStamp[] timeStamps, WorkingState workingState)
        {
            TimeSpan result = new TimeSpan();

            for (int index = 0; index < timeStamps.Length; index++)
            {
                TimeStamp current = timeStamps[index];
                if (current.WorkingState != workingState)
                    continue;

                DateTime endTime = GetIntervalEndTimeByIndex(timeStamps, index);
                TimeSpan span = endTime - current.DateTime;
                result = result.Add(span);
            }

            return result;
        }
        private DateTime GetIntervalEndTimeByIndex(TimeStamp[] timeStamps, int index)
        {
            DateTime result = DateTime.Now;

            if (index < timeStamps.Length - 1)
                result = timeStamps[index + 1].DateTime;

            return result;
        }
    }
}
