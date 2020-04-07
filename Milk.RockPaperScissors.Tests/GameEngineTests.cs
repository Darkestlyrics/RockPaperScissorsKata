using NUnit.Framework;

namespace Milk.RockPaperScissors.Tests
{
    [TestFixture]
    public class Tests
    {

        //TODO: Finish up the rest of the tests
        private readonly GameEngine _gameEngine = new GameEngine();

        #region Player_Paper_Tests
        [Test]
        public void Play_PlayerPaper_ComputerRock_ShouldReturnPlayerWins()
        {
            //ARRANGE
            var playerMove = GameMove.Paper;
            var computerMove = GameMove.Rock;
            var expected = "Player Wins: Paper Covers Rock";
            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Play_PlayerPaper_ComputerScissors_ShouldReturnPlayerLoses()
        {
            //ARRANGE
            var playerMove = GameMove.Paper;
            var computerMove = GameMove.Scissors;
            var expected = "Player Loses: Scissors Cuts Paper";

            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Play_PlayerPaper_ComputerLizard_ShouldReturnPlayerLoses()
        {
            //ARRANGE
            var playerMove = GameMove.Paper;
            var computerMove = GameMove.Lizard;
            var expected = "Player Loses: Lizard Eats Paper";

            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Play_PlayerPaper_ComputerSpock_ShouldReturnPlayerWins()
        {
            //ARRANGE
            var playerMove = GameMove.Paper;
            var computerMove = GameMove.Spock;
            var expected = "Player Wins: Paper Disproves Spock";

            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerPaper_ComputerPaper_ShouldReturnTie()
        {
            //ARRANGE
            var playerMove = GameMove.Paper;
            var computerMove = GameMove.Paper;
            var expected = "Tie";
            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Player_Rock_Tests
        [Test]
        public void Play_PlayerRock_ComputerScissors_ShouldReturnPlayerWins()
        {
            //ARRANGE
            var playerMove = GameMove.Rock;
            var computerMove = GameMove.Scissors;
            var expected = "Player Wins: Rock Smashes scissors";
            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerRock_ComputerPaper_ShouldReturnPlayerLoses()
        {
            //ARRANGE
            var playerMove = GameMove.Paper;
            var computerMove = GameMove.Scissors;
            var expected = "Player Loses: Scissors Cuts Paper";

            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Play_PlayerRock_ComputerLizard_ShouldReturnPlayerLoses()
        {
            //ARRANGE
            var playerMove = GameMove.Paper;
            var computerMove = GameMove.Lizard;
            var expected = "Player Loses: Lizard Eats Paper";

            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Play_PlayerRock_ComputerSpock_ShouldReturnPlayerWins()
        {
            //ARRANGE
            var playerMove = GameMove.Paper;
            var computerMove = GameMove.Spock;
            var expected = "Player Wins: Paper Disproves Spock";

            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerRock_ComputerRock_ShouldReturnTie()
        {
            //ARRANGE
            var playerMove = GameMove.Rock;
            var computerMove = GameMove.Rock;
            var expected = "Tie";
            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Player_Scissors_Tests

        [Test]
        public void Play_PlayerScissors_ComputerPaper_ShouldReturnPlayerWins()
        {
            //ARRANGE
            var playerMove = GameMove.Scissors;
            var computerMove = GameMove.Paper;
            var expected = "Player Wins";
            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerScissors_ComputerRock_ShouldReturnPlayerLoses()
        {
            //ARRANGE
            var playerMove = GameMove.Scissors;
            var computerMove = GameMove.Rock;
            var expected = "Player Loses";

            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_PlayerScissors_ComputerScissors_ShouldReturnTie()
        {
            //ARRANGE
            var playerMove = GameMove.Scissors;
            var computerMove = GameMove.Scissors;
            var expected = "Tie";
            //ACT
            var actual = _gameEngine.Play_Game(playerMove, computerMove);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Player_Lizard_Tests

        #endregion

        #region Player_Spock_Tests

        #endregion




    }
}