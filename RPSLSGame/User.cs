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

        //member methods

        public override string SelectMove()
        {
            Console.WriteLine("Please enter your move selection.");
            moveType = Console.ReadLine();
            if(moveOptionList.Contains(moveType))
            {
                return moveType;
            }
            else if (moveType == "help" || moveType == "Help")
            {
                DisplayMoves();
                SelectMove();
                return moveType;
            }
            else
            {
                Console.WriteLine("Not a valid move!  Please try again, or enter 'help' to see a list of moves.");
                SelectMove();
                return moveType;
            }
        }
        public void DisplayMoves()
        {
            Console.WriteLine("Your options for game moves are:");
            for (int i = 0; i < moveOptionList.Count; i++)
            {
                Console.WriteLine(moveOptionList[i]);
            }
            Console.ReadLine();
        }
    }
}
