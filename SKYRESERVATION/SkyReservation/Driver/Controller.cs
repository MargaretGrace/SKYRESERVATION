using SkyReservation.Abstract;
using SkyReservation.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReservation.Driver
{
    class Controller
    {
        int input;

        public Controller()
        {
           StartScreen startScreen = new StartScreen();
           input = Convert.ToInt32(startScreen.GetInput());

           GetSelectionScreen();
        }

        public void GetSelectionScreen()
        {
            switch (input)
            {
                case 1: new MaintenanceController();
                    //return new MaintenanceController();
                    break;
                case 2: new ReservationController();
                    //return new ReservationController();
                    break;
            }
        }
    }
}
