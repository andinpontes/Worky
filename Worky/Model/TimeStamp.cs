using System;
using System.Text.RegularExpressions;

namespace Worky.Model
{
    public class TimeStamp
    {
        private static readonly string REGEX_PATTERN = @"(\d{2}\.\d{2}\.\d{4}\s*\d{2}:\d{2}:\d{2})\s*->\s*(Working|Pausing|Ending)";
        private static Regex regex = new Regex(REGEX_PATTERN);

        public WorkingState WorkingState { get; private set; }
        public DateTime DateTime { get; private set; }

        public TimeStamp(WorkingState workingState)
        {
            DateTime = DateTime.Now;
            WorkingState = workingState;
        }

        public static bool TryParse(string text, out TimeStamp result)
        {
            result = null;

            MatchCollection coll = regex.Matches(text);
            if (coll.Count <= 0 || coll[0].Groups.Count <= 2)
                return false;

            string dateTimeTxt = coll[0].Groups[1].ToString();
            DateTime time = new DateTime();
            if (!DateTime.TryParse(dateTimeTxt, out time))
                return false;

            string stateTxt = coll[0].Groups[2].ToString();
            WorkingState workingState;
            if (!Enum.TryParse<WorkingState>(stateTxt, out workingState))
                return false;

            result = new TimeStamp(workingState);
            result.DateTime = time;
            return true;
        }
        public override string ToString()
        {
            return $"{DateTime} -> {WorkingState}";
        }
    }
}
