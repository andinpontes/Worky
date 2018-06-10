using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worky.Interfaces;

namespace Worky.Model
{
    class WorkyData : IActivity
    {
        public WorkyData()
        {
            //TODO:
            // read data from file
        }

        public void StartPausing()
        {
            //TODO:
            // add start-pausing-time in time-table
        }

        public void StartWorking()
        {
            //TODO:
            // add start-working-time in time-table
        }

        public void EndWorking()
        {
            //TODO:
            // add end-time in time-table
            // write data into file
        }
    }
}
