using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ReservationSystem
    {
        public void ReserveFlight()
        {
            Console.WriteLine("Reserve flight");
        }
        public void CheckIn()
        {
            Console.WriteLine("CheckingIn flight");
        }
        public void SendEmailReminderBeforeFlight()
        {
            Console.WriteLine("Sending email");
        }
    }
}
