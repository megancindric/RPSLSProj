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

        //constructor
        public Gameplay()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock!  Press any key to begin!");
            Console.ReadLine();
            playerOne = new User();
            DisplayRules();
            ChooseGameMode();
            ChoosePlayerNames();
            while(playerOne.playerScore < 2 && playerTwo.playerScore < 2)
            {
                GameRound();
            }
            DeclareWinner();
        }
        //member methods
        public void DisplayRules()
        {
            Console.WriteLine("The rules are as follows:");
            Console.WriteLine("Players can choose Rock, Paper, Scissors, Lizard, or Spock");
            Console.WriteLine("Rock crushes Paper and Lizard");
            Console.WriteLine("Paper covers Rock and disproves Spock");
            Console.WriteLine("Scissors cuts Paper and decapitates Lizard");
            Console.WriteLine("Lizard eats paper and poisons Spock");
            Console.WriteLine("Spock vaporizes Rock and smashes Scissors");
            Console.WriteLine("Got all that?  When you are ready, press any key to continue!");
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
            else
            {
                Console.WriteLine("Not a valid input!  Please try again!");
                ChooseGameMode();
            }
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
            DisplayMoves();
            CompareResults(playerOneMove, playerTwoMove);
        }
        //SWITCH CASE for PLAYER 1 INPUT 
        //This will then trigger player methods for what their input is
        //Will compare this to string of P2 input.
        public void CompareResults(String playerOneMove, String playerTwoMove)
        {
            if (playerOneMove == playerTwoMove)
            {
                TieGame();
            }
            else
            {
                switch (playerOneMove)
                {
                    case "Rock":
                        RockMoves(playerTwoMove);
                        break;

                    case "Paper":
                        PaperMoves(playerTwoMove);
                        break;

                    case "Scissor":
                        ScissorsMoves(playerTwoMove);
                        break;

                    case "Lizard":
                        LizardMoves(playerTwoMove);
                        break;

                    case "Spock":
                        SpockMoves(playerTwoMove);
                        break;
                }
            }
        }

        public void TieGame()
        {
            Console.WriteLine("Tie game!  Looks like no one gets a point this round!");
        }
 
        public void PlayerOnePoint()
        {
            Console.WriteLine($"{playerOne.moveType} beats {playerTwo.moveType}.  {playerOne.playerName} wins this round!");
            playerOne.playerScore++;
        }

        public void PlayerTwoPoint()
        {
            Console.WriteLine($"{playerTwo.moveType} beats {playerOne.moveType}.  {playerTwo.playerName} wins this round!");
            playerTwo.playerScore++;
        }

        public void DisplayMoves()
        {
            Console.WriteLine($"{playerOne.playerName} picked {playerOne.moveType} and {playerTwo.playerName} picked {playerTwo.moveType}.");
        }

        public void DisplayScore()
        {
            Console.WriteLine($"{playerOne.playerName} has {playerOne.playerScore} points.  {playerTwo.playerName} has {playerTwo.playerScore} points!");
            Console.ReadLine();
        }

        public void RockMoves(string moveType)
        {
            //this case where P1 is rock, we take in P2's input
            if (moveType == "Lizard" || moveType == "Scissors")
            {
                PlayerOnePoint();
            }
            else if (moveType == "Paper" || moveType == "Spock")
            {
                PlayerTwoPoint();
            }
        }

        public void PaperMoves(string moveType)
        {
            //Case where P1 is Paper, take in P2's input
            if (moveType == "Rock" || moveType == "Spock")
            {
                PlayerOnePoint();
            }
            else if (moveType == "Lizard" || moveType == "Scissors")
            {
                PlayerTwoPoint();
            }
        }

        public void ScissorsMoves(string moveType)
        {
            //case where P1 input is Scissors, take in P2's input
            if (moveType == "Paper" || moveType == "Lizard")
            {
                PlayerOnePoint();
            }
            else //input is Spock or Rock
            {
                PlayerTwoPoint();
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
                PlayerOnePoint();
            }
            else //input is Paper or Lizard
            {
                PlayerTwoPoint();
            }
        }
        public void DeclareWinner()
        {
            if (playerOne.playerScore > playerTwo.playerScore)
            {
                Console.WriteLine($"{playerOne.playerName} is the winner!!");
               // Console.WriteLine("Press 1 to play again, or press any other key to exit.");

            }
            //Winner message
            //Option to play again?
        }
    }
}
