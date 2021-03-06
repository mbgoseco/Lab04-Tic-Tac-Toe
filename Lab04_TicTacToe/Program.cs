﻿using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player();
            Console.Write("Player 1 - enter your name: ");
            playerOne.Name = Console.ReadLine();
            playerOne.Marker = "X";
            playerOne.IsTurn = true;

            Player playerTwo = new Player();
            Console.Write("Player 2 - enter your name: ");
            playerTwo.Name = Console.ReadLine();
            playerTwo.Marker = "O";
            playerTwo.IsTurn = false;

            // Creates new instance of game
            Game newGame = new Game(playerOne, playerTwo);
            Console.Clear();

            // Game logic begins here, returns result for winner when game is finished
            Player winner = newGame.Play();
            if (winner == null)
            {
                Console.WriteLine("The game is a draw!");
            }
            else
            {
                Console.WriteLine($"{winner.Name} is winnar!");
            }
        }
    }
}
