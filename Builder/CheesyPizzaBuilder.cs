using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CheesyPizzaBuilder : IPizzaBuilder
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
            _pizza.Dough = "Thick";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "Cheesy";
        }

        public void BuildToppings()
        {
            _pizza.Topping = "Cheese";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
