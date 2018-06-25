using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Worky.Interfaces;
using Worky.Model;

namespace Worky.IO
{
    public class TimeStampsFileWriter : ITimeStampsWriter
    {
        public string Filename { get; private set; }

        private TimeStampsFileWriter()
        {
        }

        public static TimeStampsFileWriter FromFile(string filename)
        {
            return new TimeStampsFileWriter
            {
                Filename = filename
            };
        }

        public void Write(IEnumerable<TimeStamp> stamps)
        {
            EnsureDirectoryExists();

            string[] lines = stamps.Select(e => e.ToString()).ToArray();
            File.WriteAllLines(Filename, lines, Encoding.UTF8);
        }

        private void EnsureDirectoryExists()
        {
            string directory = Path.GetDirectoryName(Filename);
            Directory.CreateDirectory(directory);
        }
    }
}
