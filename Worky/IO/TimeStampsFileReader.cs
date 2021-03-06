﻿using System.Collections.Generic;
using System.IO;
using System.Text;
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

            string[] lines = ReadLinesFromFile();
            foreach (var current in lines)
            {
                TimeStamp timeStamp;
                if (TimeStamp.TryParse(current, out timeStamp))
                    result.Add(timeStamp);
            }

            return result;
        }

        private string[] ReadLinesFromFile()
        {
            try
            {
                return File.ReadAllLines(Filename, Encoding.UTF8);
            }
            catch (FileNotFoundException)
            {
            }
            catch (DirectoryNotFoundException)
            {
            }

            return new string[] { };
        }
    }
}
