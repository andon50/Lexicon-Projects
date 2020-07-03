using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Popcorn : Snack
    {
        public Popcorn(int price)
        {
            Price = price;
            Item = "Popcorn";
            Description = "Poppade majskorn, saltade";
        }
    }
}
