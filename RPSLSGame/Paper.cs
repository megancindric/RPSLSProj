using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    public class Paper : Gestures
    {
        public Paper()
        {
            moveType = "Paper";
            losesTo = new List<string> { "Scissors", "Lizard"};
        }
    }
}
