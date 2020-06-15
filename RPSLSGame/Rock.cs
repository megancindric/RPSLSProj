using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLSGame
{
    public class Rock : Gestures
    {
       public Rock()
        {
            moveType = "Rock";
            losesTo = new List<string>{ "Paper", "Spock"};
        }
    }
}
