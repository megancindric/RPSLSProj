using System;

namespace RPSLSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Class for player (abstract) that can be instantiated as USER or as COMPUTER
                //Every player will inherit the same LIST of move options
                //Player will select from this list based on USER INPUT
                //Computer will randomly select between 0-4 (5 options, up to index 4) and that will be it's selection



            //Response options
                 // Can program to check for tie FIRST (if player 1 input == player 2 input)
                 //Can first check if P1 wins - Run series of "if" statements
                        //may be able to compress this method later?
                //ELSE we can assume P2 wins (THERE IS ALWAYS A WINNER AND LOSER IN THIS GAME YALL)

            //We will have if statements corresponding to P1 Wins (P1 win count ++), P2 Wins (P2 win count++), & TIE (Tie will NOT increase score but will prompt another round)


        }
    }
}
