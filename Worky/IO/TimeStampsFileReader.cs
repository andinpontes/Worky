using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worky.Interfaces;
using Worky.Model;

namespace Worky.IO
{
    public class TimeStampsFileReader : ITimeStampsReader
    {
        public string Filename { get; private set; }

        private TimeStampsFileReader()
        {
        }

        public static TimeStampsFileReader FromFile(string filename)
        {
            return new TimeStampsFileReader
            {
                Filename = filename
            };
        }

        public IEnumerable<TimeStamp> Read()
        {
            List<TimeStamp> result = new List<TimeStamp>();
            
            //TODO:

            return result;
        }
    }
}
