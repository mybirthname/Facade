using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var resturant = new Restaurant();
            resturant.GetGarlicBread();
        }
    }
}
