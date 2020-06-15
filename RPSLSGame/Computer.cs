using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    class Computer : Player
    {
        //member variables
        public Random random;

        //constructor
        public Computer()
        {
            random = new Random();
            playerName = "Mr. Robot";
        }
        //member methods
        public override void SelectMove()
        {
            int computerSelection = random.Next(gestureOptions.Count);
            moveChoice = gestureOptions[computerSelection];
        }
    }
}
