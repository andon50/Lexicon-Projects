using System;
using System.Collections.Generic;



namespace Golf
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfStrokes=0;                              //Number of strokes
            double ballDistance;                                //How long the ball went in meters
            double distanceToHole;                              //Distance left to hole in meters

            Console.WriteLine("Välkommen till Golf. Prova att slå i bollen på så få slag som möjligt.");
            Console.WriteLine("Det är 380 meter till hål.");

            HitTheBall hitTheBall = new HitTheBall();           //create object for hitting the ball
            hitTheBall.DistanceToHole = 380;                    //Startvalue for distance to hole

            List<double> distanceLog = new List<double>();      //List of how far the ball went for each stroke


            do
            {

                Console.WriteLine("Ange utslagsvinkel (1-45 grader): ");
                hitTheBall.Angle = Convert.ToInt32(Console.ReadLine());          //User input for angle

                Console.WriteLine("Ange utslagshastighet (1-90 m/s): ");
                hitTheBall.Velocity = Convert.ToInt32(Console.ReadLine());       //User input for velocity

                ballDistance = hitTheBall.CalculateLenghtOfStroke();             //Calculates length of stroke
                distanceLog.Add(ballDistance);                                   //Adds to List
                numberOfStrokes++;                                               //counts number of strokes

                try        //Checks if distance to hole are over 380 meters and in that case throws an exception
                {
                    distanceToHole = hitTheBall.CalculateDistanceToHole();           //Calculates distance to hole

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

                try
                {
                    if (numberOfStrokes > 9)
                    {
                        throw new NumberOfStrokesExeption("To many strikes! We can't wait any longer.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                

                if (distanceToHole < 1)                                         //Checks if the distance is less than 1 meter
                {
                    Console.WriteLine("Bollen gick i hål");
                    break;
                }
                else
                {
                    Console.WriteLine("Du slog " + ballDistance + " meter. Du har "
                        + distanceToHole + " meter kvar till hål efter " + numberOfStrokes + " slag.");
                }
                
                Console.WriteLine("Vill du fortsätta? (j/n)");
                ConsoleKey sign = Console.ReadKey().Key;                         // reads operator key (+,-,*,/)
                if (sign == ConsoleKey.Q)
                {
                    break;
                }

            } while (distanceToHole > 1);


            Console.WriteLine();
            Console.WriteLine("Du har använt {0} slag", numberOfStrokes);

            foreach (var item in distanceLog)
            {
                Console.Write(item + " meter, ");
            }

            Console.WriteLine();
        }
    }

    class DistanceException : Exception
    {
        public DistanceException(string message) : base(message)
        {
        }
    }

    class NumberOfStrokesExeption : Exception
    {
        public NumberOfStrokesExeption(string message) : base(message)
        {
        }

    }
}
