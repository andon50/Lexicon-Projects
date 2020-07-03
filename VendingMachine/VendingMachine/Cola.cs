using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Cola : Drink
    {
        public Cola(int price)
        {
            Price = price;
            Item = "Cola";
            Description = "Varning! Starkt frätande!'";
        }
    }
}
