using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.Model
{
    class Reservation
    {
        public int ReservationID { get; set; }
        public string AirlineCode { get; set; }
        public int FlightNumber { get; set; }
        public string FlightDate { get; set; }
        public int NumPassengers { get; set; }
        public string PnrNumber { get; set; }
    }
}
