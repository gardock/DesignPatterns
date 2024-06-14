using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteImplementation
{
    public class RomanArcher : IUnit
    {
        public void Move()
        {
            Console.WriteLine("Roman archer unit moved");
        }
    }
}
