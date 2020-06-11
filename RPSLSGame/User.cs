using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    class User : Player
    {
        //member variables

        //constructor
        public User()
        {

        }
        //created from PLAYER class

        //member methods
        public override string SelectMove()
        {
            Console.WriteLine("Please enter your move selection.  Type 'help' for a list of moves.");
            moveType = Console.ReadLine();
            return moveType;

        }
    }
}
