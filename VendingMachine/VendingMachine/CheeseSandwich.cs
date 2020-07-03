using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class CheeseSandwich : Sandwich
    {
        public CheeseSandwich(int price)
        {
            Price = price;
            Item = "Ost Sandwich";
            Description = "Dubbel smörgås med ost i mellan";
        }
    }
}
