using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteImplementation
{
    public class RomanMeleeBarrack : IBuilding
    {
        public void CreateUnits()
        {
            Console.WriteLine("Roman melee barrack produced units");
        }
    }
}
