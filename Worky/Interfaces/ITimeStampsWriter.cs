using System.Collections.Generic;
using Worky.Model;

namespace Worky.Interfaces
{
    public interface ITimeStampsWriter
    {
        void Write(IEnumerable<TimeStamp> stamps);
    }
}
