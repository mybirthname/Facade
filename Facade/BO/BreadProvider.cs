using Facade.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.BO
{
    public class BreadProvider : IBread
    {
        public void GetCheesyGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }

        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Cheesy Garlic Bread.");      
        }
    }
}
