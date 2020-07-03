using System;
using System.Collections.Generic;


namespace ArenaFighter
{
    class Battle
    {
        public int BattleNumber { get; set; }
        public int RoundNumber { get; set; }
        public bool Alive { get; set; }
        public int Score { get; set; }          //number of wins, bonus (2 points) if retired
        
               

        public void Battle()
        {
            Random rand = new Random();                     //Initializes a new randow object
            List<string> battleLog = new List<string>();    //Contains Wictory or Lost
            List<Int32> roundLog = new List<Int32>();       //Contains number of rounds in each battle
            
            

            do       //Battle loop:  runs until dead or retired
            {
                

                


                roundLog.Add(roundNumber);   //Adds number of rounds in this battle to roundLog

                if (Player.PlayerHealth > 0)        //Checks if the battle are won or lost and adds the result to battleLog
                {
                    battleLog.Add("Victory");
                    score++;                   
                }
                else
                {
                    battleLog.Add("Lost");
                    alive = false;
                    Console.WriteLine("Sorry, you will go to Valhalla...");
                    break;
                }

                
                Console.WriteLine("Do you want to continue with a new battle? j/n");    //Retire or continue with new battles ?
                ConsoleKey stop = Console.ReadKey().Key;

                if (stop == ConsoleKey.N)
                {
                    Console.WriteLine("You are now retired...");
                    break;
                }
            }
            while (Player.PlayerHealth>0);

            Console.WriteLine("Game over!");
            if (alive)
            {
                score += 3;         //Bonus for alive
            }

            Console.WriteLine("Total Score: " + (score));

            for (int i = 0; i < logOpponents.Count; i++)
            {
                Console.Write("Battle nr: " + (i+1) + ", ");
                Console.Write("Opponents name: " + logOpponents[i] + ", ");
                Console.Write("Total of " + roundLog[i] + "rounds" + ", ");
                Console.WriteLine("Battle: " + battleLog[i]);

            }

        }   //End of function 'newBattle' 


    }
}
