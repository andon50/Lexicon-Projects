using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class HamSandwich : Sandwich
    {
        public HamSandwich(int price)
        {
            Price = price;
            Item = "Skink Sandwich";
            Description = "Dubbel smörgås med skinka i mellan";
        }
    }
}
