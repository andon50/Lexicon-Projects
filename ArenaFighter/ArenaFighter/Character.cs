using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace ArenaFighter
{
    class Character
    {

        public string PlayerName { get; set; }

        public int PlayerStrength { get; set; }

        public int PlayerHealth { get; set; }

        public string OpponentName { get; set; }

        public int OpponentStrength { get; set; }

        public int OpponentHealth { get; set; }


        Random rand = new Random();

        public Character(string name)               //Creates a player with random Strength, sets input name and health to 10
        {
            PlayerName = name;
            PlayerStrength = rand.Next(1, 7);
            PlayerHealth = 10;

        }
        public Character()                          //Creates an opponent with random name, random strength and health to 10
        {
            string[] bruteNames = {"Nummer 0", "Lars", "Ove", "Gunnar", "Erik", "Tore", "Nils", "Nummer 7"};
            OpponentName = bruteNames[rand.Next(1, 7)];
            OpponentStrength = rand.Next(1, 7);
            OpponentHealth = 10;
        }


        
    }
}
