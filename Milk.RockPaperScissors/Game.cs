using System.Collections.Generic;

namespace Milk.RockPaperScissors
{
    public struct Game
    {
        public GameMove PlayerMove { get; set; }
        public GameMove ComputerMove { get; set; }

        public string Result { get; set; }
    }
}