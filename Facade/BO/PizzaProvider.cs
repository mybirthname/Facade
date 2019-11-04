using Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.BO
{
    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            Console.WriteLine("Getting Non Veg Pizza");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza");
        }
    }
}
