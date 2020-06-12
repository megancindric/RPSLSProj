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
        public List<string> moveOptionList;

        //constructor
        public Player()
        {
            playerScore = 0;
            moveOptionList = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }
        //member methods
        public abstract void SelectMove();

    }
}
        
        