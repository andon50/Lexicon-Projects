using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Drink : Product
    {
        public bool Sugar { get; set; }
        public bool Milk { get; set; }

        public override void Examine()
        {
            Console.WriteLine($"{Item}; {Description}; Pris: {Price} kronor");
            Console.WriteLine("Tillval socker, mjölk");
        }
    }
}
