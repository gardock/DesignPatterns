using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FlightBookingFacade
    {
        private FlightSystem _flightSystem;
        private ReservationSystem _reservationSystem;
        public FlightBookingFacade() { 
            _flightSystem = new FlightSystem();
            _reservationSystem = new ReservationSystem();
        }

        public void FindAndBookNearestFlight(string pointA, string pointB)
        {
            _flightSystem.SearchForFlights(pointA, pointB);
            _reservationSystem.ReserveFlight();
            _reservationSystem.CheckIn();
            _reservationSystem.SendEmailReminderBeforeFlight();
        }
    }
}
