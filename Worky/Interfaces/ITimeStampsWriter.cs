using System.Collections.Generic;
using Worky.Model;

namespace Worky.Interfaces
{
    interface ITimeStampsWriter
    {
        void Write(IEnumerable<TimeStamp> stamps);
    }
}
