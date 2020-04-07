namespace Milk.RockPaperScissors
{

    public class WinningMove
    {
        /// <summary>
        /// The move in question
        /// </summary>
        public GameMove Move { get; set; }
        /// <summary>
        /// The verb to use
        /// </summary>
        public string Verb { get; set; }
        /// <summary>
        /// The move the move beats
        /// </summary>
        public GameMove OppositeMove { get; set; }

        public WinningMove(GameMove move, string verb, GameMove oppositeMove)
        {
            Move = move;
            Verb = verb;
            OppositeMove = oppositeMove;
        }

        public override string ToString()
        {
            return $"{Move} {Verb} {OppositeMove}";
        }
    }
}