using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    public abstract class Player
    {
        //member variables
        public Gestures moveChoice;
        public string playerName;
        public int playerScore;
        public List<Gestures> gestureOptions;
        public Spock spock;
        public Lizard lizard;
        public Scissors scissors;
        public Paper paper;
        public Rock rock;
        
        //constructor
        public Player()
        {
            playerScore = 0;
            CreateMoveList();
        }
        //member methods
        public abstract void SelectMove();

        public void CreateMoveList()
        {
            spock = new Spock();
            lizard = new Lizard();
            scissors = new Scissors();
            paper = new Paper();
            rock = new Rock();
            gestureOptions = new List<Gestures>() { rock, paper, scissors, lizard, spock };
        }

    }
}
        
        