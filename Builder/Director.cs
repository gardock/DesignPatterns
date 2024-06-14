using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private IPizzaBuilder _builder;
        public void SetPizzaBuilder(IPizzaBuilder builder)
        {
            _builder = builder;
        }
        public Pizza GetPizza()
        {
            return _builder.GetPizza();
        }

        public void ConstructPizza()
        {
            _builder.BuildDough();
            _builder.BuildSauce();
            _builder.BuildCheese();
            _builder.BuildToppings();
        }

        public Director AddExtraGouda()
        {
            _builder.AddExtraGouda();
            return this;
        }

        public Director AddExtraOlives()
        {
            _builder.AddExtraOlives();
            return this;
        }
    }
}
