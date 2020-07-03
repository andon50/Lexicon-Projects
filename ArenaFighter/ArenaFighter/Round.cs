using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter
{
    class Round
    {

        public int RoundNumber { get; set; }
        public int MyProperty { get; set; }



        public Round()
        {
            


            if (player.PlayerStrength > opponent.OpponentStrength)
            {
                Console.WriteLine("You dealt some dammage to your opponent.");
                opponent.OpponentHealth -= (player.PlayerStrength - opponent.OpponentStrength);     // Opponents health reduced by difference in strength
            }
            else
            {
                Console.WriteLine("You got wounded");
                player.PlayerHealth = -(opponent.OpponentStrength - player.PlayerStrength);     // Opponents health reduced by difference in strength
            }



            return  ;
        }


        






    }


}
