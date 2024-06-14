using AbstractFactory.ConcreteImplementation;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GreekFactory : IAbstractFactory
    {
        public IBuilding CreateRangedBarrack()
        {
            return new GreekArcherBarrack();
        }

        public IBuilding CreateBarracks()
        {
            return new GreekMeleeBarrack();
        }

        public IUnit CreateMeleeUnit()
        {
            return new GreekMelee();
        }

        public IUnit CreateRangedUnit()
        {
            return new GreekArcher();
        }
    }
}
