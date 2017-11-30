using SkyReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.View
{
    class FlightDetails
    {
        string airlineCode;
        string flightNumber;
        string departureStation;
        string arrivalStation;
        string scheduledTimeDeparture;
        string scheduledTimeArrival;
        int airlineCodeLength = 2;
        int minFlightNumValue = 1;
        int maxFlightNumValue = 9999;
        int stationLength = 3;
        TimeSpan parsedTime;

        Flight flight = new Flight();

        public Flight GetAddDetails()
        {
            //String airlineCode;
            //int flightNumber;
            //int arrivalStation;
            //int departureStation;
            //string sta;
            //string std;

            Console.WriteLine("SKY RESERVATIONS - FLIGHT MAINTENANCE - ADD FLIGHTS");
            Console.WriteLine("Please enter the following details to add a flight:");

            do
            {
                Console.Write("Airline Code: ");
                airlineCode = Console.ReadLine().ToUpper();
            } while (!IsValidAirlineCode(airlineCode));

            do
            {
                Console.Write("Flight Number: ");
                flightNumber = Console.ReadLine();
            } while (!IsValidFlightNumber(flightNumber));

            do
            {
                Console.Write("Departure Station: ");
                departureStation = Console.ReadLine().ToUpper();
            } while (!IsValidStation(departureStation));

            do{
                Console.Write("Arrival Station: ");
                arrivalStation = Console.ReadLine().ToUpper();
            } while(!IsValidStation(arrivalStation));


            do
            {
                Console.Write("Scheduled Time of Departure: ");
                scheduledTimeDeparture = Console.ReadLine();
            } while (!IsValidTime(scheduledTimeDeparture)); 

            do
            {
                Console.Write("Scheduled Time of Arrival: ");
                scheduledTimeArrival = Console.ReadLine();
            } while (!IsValidTime(scheduledTimeArrival));

            flight.AirlineCode = airlineCode;
            flight.FlightNumber = Convert.ToInt32(flightNumber);
            flight.DepartureStation = departureStation;
            flight.ArrivalStation = arrivalStation;
            TimeSpan.TryParse(scheduledTimeDeparture, out parsedTime);
            flight.ScheduledTimeDeparture = scheduledTimeDeparture;
            TimeSpan.TryParse(scheduledTimeArrival, out parsedTime);
            flight.ScheduledTimeArrival = scheduledTimeArrival;

            return flight;
        }

        public Flight GetSearchDetails(int search)
        {
            Console.WriteLine("SKY RESERVATIONS - FLIGHT MAINTENANCE - SEARCH FLIGHTS");
            switch (search)
            {
                case 2: do
                        {
                            Console.Write("Airline Code: ");
                            airlineCode = Console.ReadLine().ToUpper();
                        } while (!IsValidAirlineCode(airlineCode));
                        flight.AirlineCode = airlineCode;              
                    break;
                case 3: do
                        {
                            Console.Write("Flight Number: ");
                            flightNumber = Console.ReadLine();
                        } while (!IsValidFlightNumber(flightNumber));
                        flight.FlightNumber = Convert.ToInt32(flightNumber);
                    break;
                case 4: do
                        {
                            Console.Write("Departure Station (Origin): ");
                            departureStation = Console.ReadLine();
                        } while (!IsValidStation(departureStation));
                        flight.DepartureStation = departureStation.ToUpper();
                    break;
                case 5: do
                        {
                            Console.Write("Arrival Station (Destination): ");
                            arrivalStation = Console.ReadLine();
                        } while (!IsValidStation(arrivalStation));
                        flight.ArrivalStation = arrivalStation.ToUpper();
                    break;
            }
            return flight;
        }

        public bool IsValidAirlineCode(string code)
        {
            if (code.Length == airlineCodeLength)
            {
                if ((char.IsDigit(code[0]) && char.IsLetter(code[1])) ||
                    (char.IsLetter(code[0]) && char.IsLetterOrDigit(code[1])))
                {
                    return true;
                }
            }

            Console.WriteLine("Not a valid airline code, try again.");
            return false;
        }

        public bool IsValidFlightNumber(string number)
        {
            int num;

            if(int.TryParse(number, out num))
            {
                if (num >= minFlightNumValue && num <= maxFlightNumValue)
                {
                    return true;
                }
            }
            
            Console.WriteLine("Not a valid flight number, try again.");
            return false;
        }

        public bool IsValidStation(string station)
        {
            //bool isValid = false;
            //if (station.Length == 3)
            //{
            //    station.ToList().ForEach(s => {
            //        if (!IsValidNumber(s) && !IsValidLetter(s))
            //        {
            //            return false;
            //        }
            //    });
            //    return true;
            //}


           if (station.Length == stationLength)
           {
                foreach (char c in station)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        Console.WriteLine("Not a valid option, try again.");
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("Not a valid station, try again.");
            return false;
        }

        public bool IsValidTime(string time)
        {
            bool isValid;
            TimeSpan tempTime;
            isValid = TimeSpan.TryParse(time, out tempTime);
            if (isValid)
            {
                return true;
            }
            Console.WriteLine("Not a valid time, try again.");
            return false;
        }

        // TODO: ViewFlights() should be transferred to another function
        public void ViewFlights(List<Flight> flights) 
        {
            Console.WriteLine("SKY RESERVATIONS - FLIGHT MAINTENANCE - VIEW FLIGHTS");
            foreach (Flight f in flights)
            {
                Console.Write("Airline Code: ");
                Console.WriteLine(f.AirlineCode);
                Console.Write("Flight Number: ");
                Console.WriteLine(f.FlightNumber);
                Console.Write("Departure Station: ");
                Console.WriteLine(f.DepartureStation);
                Console.Write("Arrival Station: ");
                Console.WriteLine(f.ArrivalStation);
                Console.Write("Scheduled Time of Departure: ");
                Console.WriteLine(f.ScheduledTimeDeparture);
                Console.Write("Scheduled Time of Arrival: ");
                Console.WriteLine(f.ScheduledTimeArrival);
                Console.WriteLine("\n\n");
            }
        }

        //public bool IsValidNumber(char c)
        //{
        //    if (c >= '0' && c <= '9')
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool IsValidLetter(char c)
        //{
        //    if (c >= 'A' && c <= 'Z')
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
