using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    public class Lizard : Gestures
    {
        public Lizard()
        {
            moveType = "Lizard";
            losesTo = new List<string> { "Rock", "Scissors"};
        }
    }
}
