using Facade.BO;
using Facade.BO.Interfaces;
using Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Restaurant
    {
        private readonly IPizza _pizzaProvider;
        private readonly IBread _breadProvider;

        public Restaurant()
        {
            _pizzaProvider = new PizzaProvider();
            _breadProvider = new BreadProvider();
        }

        public void GetNonVegiPizza()
        {
            _pizzaProvider.GetNonVegPizza();
        }
        public void GetVegiPizza()
        {
            _pizzaProvider.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _breadProvider.GetGarlicBread();
        }
        public void GetCheesyBread()
        {
            _breadProvider.GetCheesyGarlicBread();
        }
    }
}
