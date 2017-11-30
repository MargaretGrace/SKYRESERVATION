using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.Model
{
    class Flight
    {
        public int FlightID { get; set; }
        public string AirlineCode { get; set; }
        public int FlightNumber { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public string ScheduledTimeDeparture { get; set; }
        public string ScheduledTimeArrival { get; set; }
        //public TimeSpan Sta { get; set; }
        //public TimeSpan Std { get; set; }
    }
}
