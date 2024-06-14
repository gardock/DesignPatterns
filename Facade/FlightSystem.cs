using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FlightSystem
    {
        public void SearchForFlights(string pointA, string pointB)
        {
            Console.WriteLine($"Searching for flight from {pointA} to {pointB}");
        }
    }
}
