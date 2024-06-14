using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea : Beverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Add lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing tea");
        }
    }
}
