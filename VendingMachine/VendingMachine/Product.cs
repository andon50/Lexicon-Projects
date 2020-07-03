using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Product
    {
        public string Item { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public virtual void Examine()
        {
            Console.WriteLine("Info från Product class");
            Console.WriteLine($"{Item}; {Description}; Pris: {Price} kronor");
        }
        public void Use()
        {
            Console.WriteLine($"Njut nu av din {Item}");
        }
        public int Purchase(int moneyPool)      //Takes money from moneyPool if there are sufficent money left.
        {
            if ( moneyPool< Price)                      
            {
                Console.WriteLine("No money left.");
                return moneyPool;
            }
            else
            {
                Console.WriteLine($"Du köpte en {Item}");
                Use();
                return (moneyPool -= Price);
            }
        }
    }
}
