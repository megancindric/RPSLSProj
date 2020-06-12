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
                playerOne.SelectMove();
                playerTwo.SelectMove(); 
                DisplayMoves();
                CompareResults();
                DisplayScore();
            }
            DeclareWinner();
        }
        //member methods
        public void DisplayRules()
        {
            Console.WriteLine("The rules are as follows:");
            Console.WriteLine("Players can choose Rock, Paper, Scissors, Lizard, or Spock.");
            Console.WriteLine("Rock crushes Paper and Lizard.");
            Console.WriteLine("Paper covers Rock and disproves Spock.");
            Console.WriteLine("Scissors cuts Paper and decapitates Lizard.");
            Console.WriteLine("Lizard eats paper and poisons Spock.");
            Console.WriteLine("Spock vaporizes Rock and smashes Scissors.");
            Console.WriteLine("The first player to 2 points wins!!");
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
            Console.WriteLine($"{playerOne.playerName} and {playerTwoName} will be battling!");
        }
    
        
        public void CompareResults()
        {
            if (playerOne.moveType == playerTwo.moveType)
            {
                TieGame();
            }
            else
            {
                switch (playerOne.moveType)
                {
                    case "Rock":
                        RockMoves();
                        break;

                    case "Paper":
                        PaperMoves();
                        break;

                    case "Scissors":
                        ScissorsMoves();
                        break;

                    case "Lizard":
                        LizardMoves();
                        break;

                    case "Spock":
                        SpockMoves();
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
            Console.WriteLine("The current score is:");
            Console.WriteLine($"{playerOne.playerName}: {playerOne.playerScore}\n{playerTwo.playerName}: {playerTwo.playerScore}");
        }

        public void RockMoves()
        {
            if (playerTwo.moveType == "Lizard" || playerTwo.moveType == "Scissors")
            {
                PlayerOnePoint();
            }
            else if (playerTwo.moveType == "Paper" || playerTwo.moveType == "Spock")
            {
                PlayerTwoPoint();
            }
        }
        public void PaperMoves()
        {
            if (playerTwo.moveType == "Rock" || playerTwo.moveType == "Spock")
            {
                PlayerOnePoint();
            }
            else if (playerTwo.moveType == "Lizard" || playerTwo.moveType == "Scissors")
            {
                PlayerTwoPoint();
            }
        }
        public void ScissorsMoves()
        {
            if (playerTwo.moveType == "Paper" || playerTwo.moveType == "Lizard")
            {
                PlayerOnePoint();
            }
            else //input is Spock or Rock
            {
                PlayerTwoPoint();
            }
        }

        public void LizardMoves()
        {
            //case where P1 input is Lizard, take in P2's input
            if (playerTwo.moveType == "Spock" || playerTwo.moveType == "Paper")
            {
                PlayerOnePoint();
            }
            else //input is rock or scissor
            {
                PlayerTwoPoint();
            }
        }
        public void SpockMoves()
        {
            //case where P1 input is Spock, take in P2's input
            if (playerTwo.moveType == "Rock" || playerTwo.moveType == "Scissors")
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
            }
            else
            {
                Console.WriteLine($"{playerTwo.playerName} is the winner!!");
            }
            Console.WriteLine("Thank you for playing! :) ");
        }
    }
}
