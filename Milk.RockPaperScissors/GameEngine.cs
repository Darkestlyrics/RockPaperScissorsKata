using System;
using System.Collections.Generic;
using System.Linq;

namespace Milk.RockPaperScissors
{
    public class GameEngine
    {
        ///Version 1
        //public string Play(string playerMove, string computerMove)
        //{
        //    string res = "";
        //    switch (playerMove.ToUpper())
        //    {
        //        case "SCISSORS":
        //            switch (computerMove.ToUpper())
        //            {
        //                case "SCISSORS":
        //                    res = "Tie";
        //                    break;
        //                case "ROCK":
        //                    res = "Player Loses";
        //                    break;
        //                case "PAPER":
        //                    res = "Player Wins";
        //                    break;
        //            }
        //            break;
        //        case "ROCK":
        //            switch (computerMove.ToUpper())
        //            {
        //                case "SCISSORS":
        //                    res = "Player Wins";
        //                    break;
        //                case "ROCK":
        //                    res = "Tie";
        //                    break;
        //                case "PAPER":
        //                    res = "Player Loses";
        //                    break;
        //            }
        //            break;
        //        case "PAPER":
        //            switch (computerMove.ToUpper())
        //            {
        //                case "SCISSORS":
        //                    res = "Player Loses";
        //                    break;
        //                case "ROCK":
        //                    res = "Player Wins";
        //                    break;
        //                case "PAPER":
        //                    res = "Tie";
        //                    break;
        //            }
        //            break;
        //    }
        //    return res;
        //}

        ///Refactored v2
        //public string Play(string playerMove, string computerMove)
        //{
        //    if (playerMove.ToUpper() == computerMove.ToUpper())
        //        return "Tie";

        //    string res = "";
        //    switch (playerMove.ToUpper())
        //    {
        //        case "SCISSORS":
        //            switch (computerMove.ToUpper())
        //            {
        //                case "ROCK":
        //                    res = "Player Loses";
        //                    break;
        //                case "PAPER":
        //                    res = "Player Wins";
        //                    break;
        //            }
        //            break;
        //        case "ROCK":
        //            switch (computerMove.ToUpper())
        //            {
        //                case "SCISSORS":
        //                    res = "Player Wins";
        //                    break;
        //                case "PAPER":
        //                    res = "Player Loses";
        //                    break;
        //            }
        //            break;
        //        case "PAPER":
        //            switch (computerMove.ToUpper())
        //            {
        //                case "SCISSORS":
        //                    res = "Player Loses";
        //                    break;
        //                case "ROCK":
        //                    res = "Player Wins";
        //                    break;
        //            }
        //            break;
        //    }
        //    return res;
        //}

        ///Refactored v3
        //public string Play(string playerMove, string computerMove)
        //{

        //    if (playerMove.ToUpper() == computerMove.ToUpper())
        //        return "Tie";
        //    if (string.IsNullOrEmpty(playerMove) || string.IsNullOrEmpty(computerMove))
        //        return "Invalid Input";
        //    string res = "";
        //    switch (playerMove.ToUpper())
        //    {
        //        case "SCISSORS":
        //            res = $"Player { (computerMove.ToUpper() == "ROCK" ? "Loses" : "Wins")}";
        //            break;

        //        case "ROCK":
        //            res = $"Player { (computerMove.ToUpper() == "PAPER" ? "Loses" : "Wins")}";

        //            break;
        //        case "PAPER":
        //            res = $"Player { (computerMove.ToUpper() == "SCISSORS" ? "Loses" : "Wins")}";

        //            break;
        //    }
        //    return res;
        // }

        ///Refactored v4
        #region v4
        private readonly List<WinningMove> _winningMoves = new List<WinningMove>()
        {
            new WinningMove(GameMove.Rock, "Smashes", GameMove.Scissors),
            new WinningMove(GameMove.Rock, "Smashes", GameMove.Lizard),
            new WinningMove(GameMove.Scissors, "Cuts", GameMove.Paper),
            new WinningMove(GameMove.Scissors, "Decapitates", GameMove.Lizard),
            new WinningMove(GameMove.Paper, "Covers", GameMove.Rock),
            new WinningMove(GameMove.Paper, "Disproves", GameMove.Spock),
            new WinningMove(GameMove.Lizard, "Poisons", GameMove.Spock),
            new WinningMove(GameMove.Lizard, "Eats", GameMove.Paper),
            new WinningMove(GameMove.Spock, "Crushes", GameMove.Scissors),
            new WinningMove(GameMove.Spock, "Crushes", GameMove.Lizard),
        };
        public string Play_Game(GameMove playerMove, GameMove computerMove)
        {
            WinningMove winningMove = null;
            string result = "Player wins";
            if (Is_Tie(playerMove, computerMove))
                return "Tie";
            //This section will need refactoring
            if (Is_Computer_Winner(computerMove, playerMove))
            {
                result = "Player Loses";
                winningMove = Get_Winning_Move(computerMove, playerMove);
            }
            else
            {
                winningMove = Get_Winning_Move(playerMove, computerMove);
            }

            return Get_Winner_Text(winningMove, result);
        }

        private WinningMove Get_Winning_Move(GameMove move, GameMove oppositeMove) => _winningMoves.First(o => o.Move == move && o.OppositeMove == oppositeMove);

        private bool Is_Computer_Winner(GameMove computer, GameMove player) =>
            _winningMoves.Any(o => o.Move == computer && o.OppositeMove == player);

        private string Get_Winner_Text(WinningMove move,string result)
        {
            return $"{result}: {move}";
        }

        private bool Is_Tie(GameMove playerMove, GameMove computerMove) => playerMove == computerMove;

        #endregion
    }
}
