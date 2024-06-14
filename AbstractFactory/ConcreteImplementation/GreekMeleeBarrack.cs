
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteImplementation
{
    public class GreekMeleeBarrack : IBuilding
    {
        public void CreateUnits()
        {
            Console.WriteLine("Greek melee barrack produced units");
        }
    }
}
