using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    public class Scissors : Gestures
    {
        public Scissors()
        {
            moveType = "Scissors";
            losesTo = new List<string> { "Spock", "Rock"};
        }
    }
}
