using SkyReservation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.View
{
    class SearchFlightScreen : SelectionScreen
    {
        enum Options
        {
            Start,
            FlightNumber,
            AirlineCode,
            OriginDestination
        }

        public void displayScreen()
        {
            Console.WriteLine("SKY RESERVATIONS - FLIGHT MAINTENANCE - SEARCH FLIGHTS");
            Console.WriteLine("Please enter the corresponding number of your choice:");
            Console.WriteLine("0 - Return to Start Screen");
            Console.WriteLine("1 - Search Flights by Flight Number");
            Console.WriteLine("2 - Search Flights by Airline Code");
            Console.WriteLine("3 - Search Flights by Origin or Destination");
            GetInput();
        }

        public String GetInput()
        {
            String input;
            do
            {
                Console.Write("Enter the number of your choice: ");
                input = Console.ReadLine();
            } while (!ValidateInput(input));

            return input;
        }

        public bool ValidateInput(string input)
        {
            int n;
            bool isValidNumber;

            isValidNumber = int.TryParse(input, out n);

            if (isValidNumber && Enum.IsDefined(typeof(Options), n))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Not a valid option, try again");
                return false;
            }
        }

        public void GetNextScreen(int input)
        {
            switch (input)
            {
                case (int)Options.Start: //new StartScreen();
                    break;
                case (int)Options.FlightNumber: //new MaintenanceScreen();
                    break;
                case (int)Options.AirlineCode: //new ReservationScreen();
                    break;
                case (int)Options.OriginDestination: //new ReservationScreen();
                    break;
            }
        }

    }
}
