using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyPool = 0;         
            string[] article = {"Kaffe", "Thè", "Cola", "Ost Sandwich", "Skink Sandwich", "Tonfisk-Sandwich", "Chips" , "Popcorn", "Jordnötter"};
            
            Checkout checkout = new Checkout();                   

            //Init all products
            Coffee coffee = new Coffee(15);     
            Tea tea = new Tea(10);
            Cola cola = new Cola(20);
            CheeseSandwich cheeseSandwich = new CheeseSandwich(20);
            HamSandwich hamSandwich = new HamSandwich(25);
            TunaSandwich tunaSanwich = new TunaSandwich(35);
            Chips chips = new Chips(30);
            Popcorn popcorn = new Popcorn(25);
            Peanuts peanuts = new Peanuts(25);

            Console.WriteLine("Välkommen!");                        //Greetings

            Console.WriteLine("Var god mata in pengar.");           //Put money into moneyPool
            
            do
            {
                var input = Console.ReadLine();
                try
                {
                    moneyPool = Int32.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"You entered '{input}' and it needs to be '1,2,3...,n-1,n '");
                }
                Console.WriteLine($"Du har {moneyPool} kronor att handla för.");
                if (moneyPool < 1)
                {
                    Console.WriteLine("Lägg till pengar. Ange belopp: ");
                }
                else
                {
                    break;
                }
            } while (moneyPool < 1);
            

            Console.WriteLine("Meny");                              //Print menu
            Console.WriteLine("---------------------------------------------------------------");
            for (int i = 0; i < article.Length; i++)
            {
                Console.WriteLine($"Välj {i + 1}: för {article[i]}");
            }

            do     //Loop for multiple choice of items
            {
                Console.WriteLine("Var god välj vara (nummer 1-9) eller (0) för att avsluta: ");
                int choice = 0;
                string input = Console.ReadLine();

                try
                {
                    choice = Int32.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"You entered '{input}' and it needs to be '1,2,3...,n-1,n '");
                }

                if (choice == 0)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:

                        moneyPool = coffee.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    case 2:

                        moneyPool = tea.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    case 3:

                        moneyPool = cola.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    case 4:

                        moneyPool = cheeseSandwich.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    case 5:

                        moneyPool = hamSandwich.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    case 6:

                        moneyPool = tunaSanwich.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    case 7:

                        moneyPool = chips.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    case 8:

                        moneyPool = popcorn.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    case 9:

                        moneyPool = peanuts.Purchase(moneyPool);
                        Console.WriteLine($"Du har {moneyPool} kronor kvar att handla för.");
                        break;

                    default:

                        break;
                }
            } while (true);
            
            checkout.PayBackMoney(moneyPool);          //Refund or give change back
            Console.WriteLine();
        }
    }




}
