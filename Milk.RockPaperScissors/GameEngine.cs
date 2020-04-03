using System;

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

        ///refactored v3
        public string Play(string playerMove, string computerMove)
        {

            if (playerMove.ToUpper() == computerMove.ToUpper())
                return "Tie";
            if (string.IsNullOrEmpty(playerMove) || string.IsNullOrEmpty(computerMove))
                return "Invalid Input";
            string res = "";
            switch (playerMove.ToUpper())
            {
                case "SCISSORS":
                    res = $"Player { (computerMove.ToUpper() == "ROCK" ? "Loses" : "Wins")}";
                    break;

                case "ROCK":
                    res = $"Player { (computerMove.ToUpper() == "PAPER" ? "Loses" : "Wins")}";

                    break;
                case "PAPER":
                    res = $"Player { (computerMove.ToUpper() == "SCISSORS" ? "Loses" : "Wins")}";

                    break;
            }
            return res;
        }
    }
}
//