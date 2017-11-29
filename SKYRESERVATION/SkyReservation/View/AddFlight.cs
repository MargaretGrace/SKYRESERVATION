using SkyReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.View
{
    class AddFlight
    {
            public Flight GetDetails()
        {
            //String airlineCode;
            //int flightNumber;
            //int arrivalStation;
            //int departureStation;
            //string sta;
            //string std;

            string airlineCode;
            string flightNumber;
            string arrivalStation;
            string departureStation;
            string sta;
            string std;

            Flight flight = new Flight();

            Console.WriteLine("SKY RESERVATIONS - FLIGHT MAINTENANCE - ADD FLIGHTS");
            Console.WriteLine("Please enter the following details to add a flight:");

            Console.Write("Airline Code: ");
            airlineCode = Console.ReadLine();
            Console.Write("Flight Number: ");
            flightNumber = Console.ReadLine();
            Console.Write("Arrival Station: ");
            arrivalStation = Console.ReadLine();
            Console.Write("Departure Station: ");
            departureStation = Console.ReadLine();
            Console.Write("Scheduled Time of Arrival: ");
            sta = Console.ReadLine();
            Console.Write("Scheduled Time of Departure: ");
            std = Console.ReadLine();

            // check for restrictions before adding to flight
            // add details to flight object
            return flight; // go back to controller
        }
    }
}
