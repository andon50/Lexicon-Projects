using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Checkout
    {
        private int[] moneyDenomination = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        private int[] moneyBack = new int[8];


        public void PayBackMoney(int moneyLeft)      //PayBack
        {
            Console.WriteLine("Please recieve your change in...");

            for (int i = 7; i >= 0; i--)
            {
                if (moneyLeft > moneyDenomination[i])
                {
                    moneyBack[i] = moneyLeft / moneyDenomination[i];     //Calculates number of notes in denomination 'i'
                    moneyLeft -= moneyBack[i] * moneyDenomination[i];      //Calculates what is left in moneypool

                    Console.WriteLine(moneyBack[i] + " sedlar/mynt i valören " + moneyDenomination[i] + " kronor");  //prints money back on screen
                }
            }
        }
    }
}
