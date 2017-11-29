using SkyReservation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.View
{
    class MaintenanceScreen : SelectionScreen
    {
        enum Options
        {
            Start,
            Add,
            Search
        }

        public void displayScreen()
        {
            Console.WriteLine("SKY RESERVATIONS - FLIGHT MAINTENANCE");
            Console.WriteLine("Please enter the corresponding number of your choice:");
            Console.WriteLine("0 - Return to Start Screen");
            Console.WriteLine("1 - Add Flights");
            Console.WriteLine("2 - Search Flights");
            GetInput();
        }

        public String GetInput()
        {
            String input;
            do{
                Console.Write("Enter the number of your choice: ");
                input = Console.ReadLine();
            } while(!ValidateInput(input)); 

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
                case (int)Options.Add: //new MaintenanceScreen();
                    break;
                case (int)Options.Search: //new ReservationScreen();
                    break;
            }
        }
    }
}
