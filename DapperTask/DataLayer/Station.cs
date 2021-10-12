using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class Station
    {
        public int S_No { get; set; }
        public string Station_Name { get; set; }
        public string Train_Name { get; set; }
        public TimeSpan Arrival_Time { get; set; }
        public TimeSpan Departure_Time { get; set; }
        public DateTime Arrival_Date { get; set; }
    }
}
