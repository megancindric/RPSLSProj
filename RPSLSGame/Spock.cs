using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    public class Spock : Gestures
    {
        public Spock()
        {
            moveType = "Spock";
            losesTo = new List<string> { "Paper", "Lizard"};
        }
    }
}
