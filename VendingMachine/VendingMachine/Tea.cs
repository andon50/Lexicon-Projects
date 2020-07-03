using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Tea : Drink
    {
        public Tea(int price)
        {
            Price = price;
            Item = "Tea";
            Description = "Gott tea från Ceylon!";
        }
    }
}
