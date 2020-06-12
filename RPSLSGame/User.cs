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
            ChoosePlayerName();
        }

        //member methods

        public override void SelectMove()
        {
            Console.WriteLine($"{playerName}, please enter your move selection. (Enter 'help' for a list of options!)");
            moveType = Console.ReadLine();
            if (moveType == "help" || moveType == "Help")
            {
                DisplayMoves();
                SelectMove();
            }
            else if (!moveOptionList.Contains(moveType))
            {
                Console.WriteLine("Not a valid move!  Please try again, or enter 'help' to see a list of moves. (Make sure to capitalize your choice!!)");
                SelectMove();
            }

        }
        public void DisplayMoves()
        {
            Console.WriteLine("Your options for game moves are:");
            for (int i = 0; i < moveOptionList.Count; i++)
            {
                Console.WriteLine(moveOptionList[i]);
            }
        }
        public void ChoosePlayerName()
        {
            Console.WriteLine("Please enter your name:");
            playerName = Console.ReadLine();
            Console.WriteLine($"Thanks, {playerName}!");
        }
    }
}

