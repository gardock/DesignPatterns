using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteImplementation
{
    public class GreekArcherBarrack : IBuilding
    {
        public void CreateUnits()
        {
            Console.WriteLine("Greek archer barrack produced units");
        }
    }
}
