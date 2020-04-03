using NUnit.Framework;

namespace Milk.RockPaperScissors.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly GameEngine _gameEngine = new GameEngine();


        [Test]
        public void Play_PlayerPaper_ComputerRock_ShouldReturnPlayerWins()
        {
            //ARRANGE
            string playerMove = "paper";
            string computerMove = "rock";
            string expected = "Player Wins";
            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Play_PlayerPaper_ComputerScissors_ShouldReturnPlayerLoses()
        {
            //ARRANGE
            string playerMove = "paper";
            string computerMove = "scissors";
            string expected = "Player Loses";

            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerP_ComputerPaper_ShouldReturnTie()
        {
            //ARRANGE
            string playerMove = "paper";
            string computerMove = "paper";
            string expected = "Tie";
            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Play_PlayerRock_ComputerScissors_ShouldReturnPlayerWins()
        {
            //ARRANGE
            string playerMove = "rock";
            string computerMove = "scissors";
            string expected = "Player Wins";
            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerRock_ComputerPaper_ShouldReturnPlayerLoses()
        {
            //ARRANGE
            string playerMove = "rock";
            string computerMove = "paper";
            string expected = "Player Loses";

            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerRock_ComputerRock_ShouldReturnTie()
        {
            //ARRANGE
            string playerMove = "rock";
            string computerMove = "rock";
            string expected = "Tie";
            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerScissors_ComputerPaper_ShouldReturnPlayerWins()
        {
            //ARRANGE
            string playerMove = "scissors";
            string computerMove = "paper";
            string expected = "Player Wins";
            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerScissors_ComputerRock_ShouldReturnPlayerLoses()
        {
            //ARRANGE
            string playerMove = "scissors";
            string computerMove = "Rock";
            string expected = "Player Loses";

            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerScissors_ComputerScissors_ShouldReturnTie()
        {
            //ARRANGE
            string playerMove = "scissors";
            string computerMove = "scissors";
            string expected = "Tie";
            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerValidInput_ComputerInValidInput_ShouldReturnInvalidInput()
        {
            //ARRANGE
            string playerMove = "scissors";
            string computerMove = "";
            string expected = "Invalid Input";
            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerInValidInput_ComputerValidInput_ShouldReturnInvalidInput()
        {
            //ARRANGE
            string playerMove = "";
            string computerMove = "scissors";
            string expected = "Invalid Input";
            //ACT
            var actual = _gameEngine.Play(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

    }
}