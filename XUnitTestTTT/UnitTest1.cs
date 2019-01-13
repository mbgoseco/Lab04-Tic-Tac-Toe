using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace XUnitTestTTT
{
    public class UnitTest1
    {
        // Tests that a win condition is triggered on a winning game board.
        [Fact]
        public void WinningBoard()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            game.Board.GameBoard[0, 0] = "X";
            game.Board.GameBoard[1, 1] = "X";
            game.Board.GameBoard[2, 2] = "X";

            Assert.True(game.CheckForWinner(game.Board));
        }

        // Tests that players properly switch turns.
        [Fact]
        public void PlayersSwitch()
        {
            Player p1 = new Player();
            p1.IsTurn = true;
            Player p2 = new Player();
            p2.IsTurn = false;
            Game game = new Game(p1, p2);

            game.SwitchPlayer();

            Assert.True(game.PlayerTwo.IsTurn);
        }

        // Tests to confirm that the position the player inputs correlates to the correct index of the game board array.
        [Fact]
        public void NumberMatchesCoords()
        {
            Position testCoords = Player.PositionForNumber(6);
            Assert.Equal(1, testCoords.Row);
            Assert.Equal(2, testCoords.Column);
        }

        // Tests to confirm that the game knows which player the current turn belongs to.
        [Fact]
        public void PlayerTwosTurn()
        {
            Player p1 = new Player();
            p1.IsTurn = false;
            Player p2 = new Player();
            p2.IsTurn = true;
            Game game = new Game(p1, p2);

            Assert.Equal(game.PlayerTwo, game.NextPlayer());
        }
    }
}
