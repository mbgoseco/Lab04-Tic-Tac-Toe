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
    }
}
