using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int value;

            Console.WriteLine("Ange ett heltal och <Enter>");
            value = Convert.ToInt32(Console.ReadLine());   // converts string to integer

            while (true)
            {
                Console.WriteLine("Ange en operator: +,-,*,/ eller beräkna resultatet med 'q'");
                ConsoleKey sign = Console.ReadKey().Key;            // reads operator key (+,-,*,/)

                if (sign == ConsoleKey.Q)
                {
                    break;
                }
                
                switch (sign)
                {
                    case ConsoleKey.Add:
                        value = Program.Add(value);
                        break;
                    case ConsoleKey.Subtract:
                        value = Program.Subtract(value);
                        break;
                    case ConsoleKey.Multiply:
                        value = Program.Multiply(value);
                        break;
                    case ConsoleKey.Divide:
                        value = Program.Divide(value);
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("Resultatet blir: " + value);

            Console.ReadKey();
        }

        static int Add(int number)
        {
            Console.WriteLine("Ange ytterligare ett heltal <Enter>");
            number += Convert.ToInt32(Console.ReadLine());

            return number;
        }

        static int Subtract(int number)
        {
            Console.WriteLine("Ange ytterligare ett heltal <Enter>");
            number -= Convert.ToInt32(Console.ReadLine());

            return number;
        }

        static int Multiply(int number)
        {
            Console.WriteLine("Ange ytterligare ett heltal <Enter>");
            number *= Convert.ToInt32(Console.ReadLine());

            return number;
        }

        static int Divide(int number)
        {
            Console.WriteLine("Ange ytterligare ett heltal <Enter>");
            number /= Convert.ToInt32(Console.ReadLine());

            return number;
        }
    }
}
