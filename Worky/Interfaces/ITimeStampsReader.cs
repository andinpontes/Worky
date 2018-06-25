using System.Collections.Generic;
using Worky.Model;

namespace Worky.Interfaces
{
    public interface ITimeStampsReader
    {
        IEnumerable<TimeStamp> Read();
    }
}
