using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Beverage
    {
        //Template method
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
            Stir();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        private void Stir()
        {
            Console.WriteLine("Mixing");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring in cup");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
