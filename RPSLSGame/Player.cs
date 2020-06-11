using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    public abstract class Player
    {
        //member variables
        public string moveType;
        public string playerName;
        public int playerScore;
        public List<String> moveOptionList;

        //constructor
        public Player()
        {
            playerScore = 0;
            moveOptionList = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        //member methods

        public abstract string SelectMove();
        
        public void RockMoves(string moveType)
        {
            //this case where P1 is rock, we take in P2's input
            if (moveType == "Lizard" || moveType == "Scissors")
            {
                Console.WriteLine($"Rock beats {moveType}!  Player 1 wins!");
                //PLAYER1SCORE++
            }
            else if (moveType == "Paper" || moveType == "Spock")
            {
                Console.WriteLine($"{moveType} beats Rock!  Player 2 wins!");
                //PLAYER2SCORE++
            }
        }

        public void PaperMoves(string moveType)
        {
            //Case where P1 is Paper, take in P2's input
            if (moveType == "Rock" || moveType == "Spock")
            {
                Console.WriteLine($"Paper beats {moveType}!  Player 1 wins!");
                //PLAYER1SCORE++
            }
            else if (moveType == "Lizard" || moveType == "Scissors")
            {
                Console.WriteLine($"{moveType} beats Paper!  Player 2 wins!");
                //PLAYER2SCORE++
            }
        }

        public void ScissorsMoves(string moveType)
        {
            //case where P1 input is Scissors, take in P2's input
            if (moveType == "Paper" || moveType == "Lizard")
            {
                Console.WriteLine($"Scissors beats {moveType}!  Player 1 wins!");
                //PLAYER1SCORE++
            }
            else //input is Spock or Rock
            {
                Console.WriteLine($"{moveType} beats Scissors!  Player 2 wins!");
                //PLAYER2SCORE++
            }

        }

        public void LizardMoves(string moveType)
        {
            //case where P1 input is Lizard, take in P2's input
            if (moveType == "Spock" || moveType == "Paper")
            {
                Console.WriteLine($"Lizard beats {moveType}!  Player 1 wins!");
                //PLAYER 1 SCORE++
            }
            else //input is rock or scissor
            {
                Console.WriteLine($"{moveType} beats Lizard!  Player 2 wins!");
                //PLAYER 2 SCORE++
            }

        }

        public void SpockMoves(string moveType)
        {
            //case where P1 input is Spock, take in P2's input
            if (moveType == "Rock" || moveType == "Scissors")
            {
                Console.WriteLine($"Spock beats {moveType}!  Player 1 wins!");
                //PLAYER 1 SCORE++
            }
            else //input is Paper or Lizard
            {
                Console.WriteLine($"{moveType} beats Spock!  Player 2 wins!");
                //PLAYER 2 SCORE++
            }
        }

        //can have BOOL of IsTie, if ISTIE we will display TIE message
        //can have BOOL of P1 Wins - 
    }
}
