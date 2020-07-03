using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Peanuts : Snack
    {
        public Peanuts(int price)
        {
            Price = price;
            Item = "Jordnötter";
            Description = "Rostade och saltade jordnötter";
        }
    }
}
