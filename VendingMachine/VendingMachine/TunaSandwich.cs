using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class TunaSandwich : Sandwich
    {
        public TunaSandwich(int price)
        {
            Price = price;
            Item = "Tonfisk Sandwich";
            Description = "Dubbel smörgås med tonfisk i mellan";
        }
    }
}
