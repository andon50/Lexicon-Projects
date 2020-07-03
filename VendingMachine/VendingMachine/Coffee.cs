using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Coffee: Drink
    {
        public Coffee(int price)
        {
            Price = price;
            Item = "Kaffe";
            Description = "Gott kaffe från Colombia!";
        }
    }
}
