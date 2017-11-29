using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.Model
{
    class Flight
    {
        //public int FlightId { get; set; }
        public string AirlineCode { get; set; }
        public int FlightNumber { get; set; }
        public int ArrivalStation { get; set; }
        public int DepartureStation { get; set; }
        public string Sta { get; set; }
        public string Std { get; set; }
    }
}
