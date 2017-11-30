using SkyReservation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.View
{
    class ReservationScreen : SelectionScreen
    {
        enum Options
        {
            Start,
            Add,
            View,
            SearchPNR
        }

        public void DisplayScreen()
        {
            Console.WriteLine("SKY RESERVATIONS - RESERVATION");
            Console.WriteLine("Please enter the corresponding number of your choice:");
            Console.WriteLine("0 - Return to Start Screen");
            Console.WriteLine("1 - Add Reservation");
            Console.WriteLine("2 - View Reservations");
            Console.WriteLine("3 - Search Reservation by PNR");
        }

        public String GetInput()
        {
            String input;
            DisplayScreen();
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
    }
}
