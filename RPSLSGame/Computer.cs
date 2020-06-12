using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    class Computer : Player
    {
        //member variables
        public Random random = new Random();

        //constructor
        public Computer()
        {

        }
        //Created from PLAYER parent class

        //member methods
        public override void SelectMove()
        {
            int computerSelection = random.Next(4);
            moveType = moveOptionList[computerSelection];

        }
    }
}
