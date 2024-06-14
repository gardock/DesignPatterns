using AbstractFactory.ConcreteImplementation;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RomanFactory : IAbstractFactory
    {
        public IBuilding CreateRangedBarrack()
        {
            return new RomanArcherBarrack();
        }

        public IBuilding CreateBarracks()
        {
            return new RomanMeleeBarrack();
        }

        public IUnit CreateMeleeUnit()
        {
            return new RomanMelee();
        }

        public IUnit CreateRangedUnit()
        {
            return new RomanArcher();
        }
    }
}
