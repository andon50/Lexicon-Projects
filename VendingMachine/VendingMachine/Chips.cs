using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Chips : Snack
    {
        public Chips(int price)
        {
            Price = price;
            Item = "Chips";
            Description = "Friterade potatisflarn, saltade";
        }
    }
}
