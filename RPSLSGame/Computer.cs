using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    class Computer : Player
    {
        //member variables
        public Random random;
        //Best practice to DECLARE a member variable but ASSIGN in constructor (saves on memory!!)

        //constructor
        public Computer()
        {
            random = new Random();
            playerName = "Mr. Robot";
        }
        //member methods
        public override void SelectMove()
        {
            int computerSelection = random.Next(moveOptionList.Count);
            moveType = moveOptionList[computerSelection];
        }
    }
}
