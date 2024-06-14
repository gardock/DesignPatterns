using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void AddExtraGouda()
        {
            _pizza.Cheese += " + gouda";
        }

        public void AddExtraOlives()
        {
            _pizza.Topping += " + Olives";
        }

        public void BuildCheese()
        {
            _pizza.Cheese = "Mozzarella";
        }

        public void BuildDough()
        {
            _pizza.Dough = "Thin";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "Garlic";
        }

        public void BuildToppings()
        {
            _pizza.Topping = "Olives";
        }

        public Pizza GetPizza()
        {
            return _pizza; 
        }
    }
}
