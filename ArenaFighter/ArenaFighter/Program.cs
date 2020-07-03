using System;
using System.Collections.Generic;


namespace ArenaFighter
{
    class Program
    {
        static void Main(string[] args)
        {

            String playerName;

            Random rand = new Random();
            
            List<string> logOpponents = new List<string>(); //Contains names of Opponents


            Console.WriteLine("Välkommen till Arenan");
            
            Console.WriteLine("What's your name?");
            playerName = Console.ReadLine();                      //Reads player name
            Character player = new Character(playerName);         //Creates a new player object with name

            do
            {
                Character opponent = new Character();       //Creates a new opponent
                Console.WriteLine("A new battle begins. Your new opponent is: " + opponent.OpponentName);
                logOpponents.Add(opponent.OpponentName);


                do         //Round loop: runs until someone is dead
                {
                    RoundNumber++;    //Counts number of rounds

                    player.PlayerStrength = Player.PlayerStrength + rand.Next(1, 7);            //Randomly increased strength: player
                    opponent.OpponentStrength = opponent.OpponentStrength + rand.Next(1, 7);    //Randomly increased strength: opponent



                } while (player.PlayerHealth > 0 && opponent.OpponentHealth > 0);               //End of Round loop





            } while (Player.PlayerHealth > 0));  //End of Battle loop




            Battle battle = new Battle();             //Creates a new battle
            battle.Battle();                                //starts a new battle







        }
    }
}
