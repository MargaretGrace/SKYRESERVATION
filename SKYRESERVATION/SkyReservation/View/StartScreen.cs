using SkyReservation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.View
{
    class StartScreen : SelectionScreen
    {
        enum Options
        {
            Maintenance = 1,
            Reservation
        }

        public void DisplayScreen()
        {
            Console.WriteLine("WELCOME TO SKY RESERVATIONS");
            Console.WriteLine("Please enter the corresponding number of your choice:");
            Console.WriteLine("1 - Flight Maintenance");
            Console.WriteLine("2 - Reservation");
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
                case (int)Options.Maintenance: //new MaintenanceScreen();
                    break;
                case (int)Options.Reservation: //new ReservationScreen();
                    break;
            }
        }
           
    }
}
