using System;

namespace DataLayer
{
    public class Train
    {
        public int S_No { get; set; }
        public int Train_No { get; set; }
        public string Train_Name { get; set; }
        public string Start_station { get; set; }
        public string End_station { get; set; }
        public DateTime Start_date { get; set; }
        public TimeSpan Start_time { get; set; }
        public DateTime End_date { get; set; }
        public TimeSpan End_time { get; set; }
        public int name { get; set; }
    }
}
