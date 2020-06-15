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
            DisplayMoves();
            Console.WriteLine($"{playerName}, please enter the number of your move selection.");
            int moveNumber = Int32.Parse(Console.ReadLine());
            if (moveNumber < gestureOptions.Count)
            {
                moveChoice = gestureOptions[moveNumber];
            }
            else
            {
                Console.WriteLine("Not a valid move!  Please try again.");
                SelectMove();
            }
                    
        }

        public void DisplayMoves()
        {
            Console.WriteLine("Your options for game moves are:");
            for (int i = 0; i < gestureOptions.Count; i++)
            {
                Console.WriteLine(i + ". : " + gestureOptions[i].moveType);
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

