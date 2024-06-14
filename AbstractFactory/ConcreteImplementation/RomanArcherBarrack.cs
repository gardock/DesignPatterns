using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteImplementation
{
    public class RomanArcherBarrack : IBuilding
    {
        public void CreateUnits()
        {
            Console.WriteLine("Roman archer barrack produced units");
        }
    }
}
