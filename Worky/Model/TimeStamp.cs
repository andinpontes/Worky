using System;

namespace Worky.Model
{
    public class TimeStamp
    {
        public WorkingState WorkingState { get; private set; }
        public DateTime DateTime { get; private set; }

        public TimeStamp(WorkingState workingState)
        {
            DateTime = DateTime.Now;
            WorkingState = workingState;
        }

        public override string ToString()
        {
            return $"{DateTime} -> {WorkingState}";
        }
    }
}
