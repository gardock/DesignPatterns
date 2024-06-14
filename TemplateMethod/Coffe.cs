using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Coffe : Beverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Add milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brew coffee");
        }
    }
}
