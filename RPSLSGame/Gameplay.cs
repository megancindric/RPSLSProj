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

            while(playerOne.playerScore < 2 && playerTwo.playerScore < 2)
            {
                playerOne.SelectMove();
                playerTwo.SelectMove(); 
                DisplayMoves();
                CompareResults();
                DisplayScore();
                Console.WriteLine("Press any key to begin the next round!");
                Console.ReadLine();
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
        public void CompareResults()
        {
            if (playerOne.moveChoice.moveType == playerTwo.moveChoice.moveType)
            {
                TieGame();
            }
            else if (playerOne.moveChoice.losesTo.Contains(playerTwo.moveChoice.moveType))
            {
                PlayerOnePoint();
            }
            else
            {
                PlayerTwoPoint();
            }
        }

        public void TieGame()
        {
            Console.WriteLine("Tie game!  Looks like no one gets a point this round!");
        }
 
        public void PlayerOnePoint()
        {
            Console.WriteLine($"{playerOne.moveChoice.moveType} beats {playerTwo.moveChoice.moveType}.  {playerOne.playerName} wins this round!");
            playerOne.playerScore++;
        }

        public void PlayerTwoPoint()
        {
            Console.WriteLine($"{playerTwo.moveChoice.moveType} beats {playerOne.moveChoice.moveType}.  {playerTwo.playerName} wins this round!");
            playerTwo.playerScore++;
        }

        public void DisplayMoves()
        {
            Console.WriteLine($"{playerOne.playerName} picked {playerOne.moveChoice.moveType} and {playerTwo.playerName} picked {playerTwo.moveChoice.moveType}.");
        }

        public void DisplayScore()
        {
            Console.WriteLine("The current score is:");
            Console.WriteLine($"{playerOne.playerName}: {playerOne.playerScore}\n{playerTwo.playerName}: {playerTwo.playerScore}");
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
