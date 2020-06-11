using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    class Gameplay
    {
        //member variables
        public Player playerOne;
        public Player playerTwo;
        public bool isATie;

        //constructor
        public Gameplay()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock!  Press any key to begin!");
            Console.ReadLine();
            playerOne = new User();
            DisplayRules();
            ChooseGameMode();
            ChoosePlayerNames();

        }

        //member methods
    

      
        public void DisplayRules()
        {
            Console.WriteLine("The rules are as follows:");
            Console.WriteLine();

            Console.WriteLine("When you are ready, press any key to continue");
            Console.ReadLine();

        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Please select your game mode: \nEnter '1' to play against the computer.\nEnter '2' to play against another human.");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                playerTwo = new Computer();
                Console.WriteLine("Player VS Computer selected.\n");
            }
            else if (userInput == "2")
            {
                playerTwo = new User();
                Console.WriteLine("Player VS Player selected.\n");
            }
            //do we want a third option here for when input != 1 or 2?  How would we loop this back along until input is 1 or 2 (do/while loop?)
        }

        public void ChoosePlayerNames()
        {
            Console.WriteLine("Please enter Player 1's name:");
            playerOne.playerName = Console.ReadLine();
            Console.WriteLine($"Thanks, {playerOne.playerName}.  Now please enter Player 2's name:");
            string playerTwoName = Console.ReadLine();
            playerTwo.playerName = playerTwoName;
            Console.WriteLine($"{playerOne.playerName} and {playerTwoName} will be battling!  Press any key to begin!");
            Console.ReadLine();
        }
       public void GameRound()
        {
            string playerOneMove = playerOne.SelectMove();
            string playerTwoMove = playerTwo.SelectMove();
            CompareResults(playerOneMove, playerTwoMove);
        }
        //SWITCH CASE for PLAYER 1 INPUT 
        //This will then trigger player methods for what their input is
        //Will compare this to string of P2 input.
        public void CompareResults(String playerOneMove, String playerTwoMove)
        {
            if (playerOneMove == playerTwoMove)
            {
                isATie = true;
            }
            else
            {
                switch (playerOneMove)
                {
                    case "Rock":
                        RockMoves(playerTwoMove);
                        Console.ReadLine();
                        break;

                    case "Paper":
                        PaperMoves(playerTwoMove);
                        Console.ReadLine();
                        break;

                    case "Scissor":
                        ScissorsMoves(playerTwoMove);
                        Console.ReadLine();
                        break;

                    case "Lizard":
                        LizardMoves(playerTwoMove);
                        Console.ReadLine();
                        break;


                    case "Spock":
                        SpockMoves(playerTwoMove);
                        Console.ReadLine();
                        break;
                }
            }
        }

        public void DeclareWinner()
        {

        }



        //FOR MOVE SELECTION
        //If player's movelist does NOT contain input string, return "Whoops, that's not a move!  Let's try that again!"
        //Can also have input to display move list (maybe a HELP function?)

        //Will run while P1's score is less than 3 and P2's score is less than 3

        //Then will trigger DISPLAYWINNER method

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




        //Response options
        // Can program to check for tie FIRST (if player 1 input == player 2 input)
        //Can first check if P1 wins - Run series of "if" statements
        //may be able to compress this method later?
        //ELSE we can assume P2 wins (THERE IS ALWAYS A WINNER AND LOSER IN THIS GAME YALL)

        //We will have if statements corresponding to P1 Wins (P1 win count ++), P2 Wins (P2 win count++), & TIE (Tie will NOT increase score but will prompt another round)
    }
}
