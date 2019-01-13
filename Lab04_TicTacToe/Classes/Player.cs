using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Player
    {
		public string Name { get; set; }
		/// <summary>
		/// P1 is X and P2 will be O
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		/// Flag to determine if it is the user's turn
		/// </summary>
		public bool IsTurn { get; set; }

        /// <summary>
        /// Asks the current player to choose a position on the game board. Returns the coordinates for that position.
        /// </summary>
        /// <param name="board">Game Board</param>
        /// <returns>Coordinates for chosen position, Position(Row, Column)</returns>
		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}

        /// <summary>
        /// Takes in a single digit position on the game board and returns in row, column coordinates.
        /// </summary>
        /// <param name="position">Position on the game board in single digits</param>
        /// <returns>Position(Row, Column)</returns>
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}

	    /// <summary>
        /// Begins the next player's turn. Asks them to choose a position and fills it with their marker if the position is not taken.
        /// </summary>
        /// <param name="board">Current game board</param>
		public void TakeTurn(Board board)
		{
			IsTurn = true;

			Console.WriteLine($"{Name} it is your turn");

            bool positionTaken;
            do
            {
			    Position position = GetPosition(board);

                if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
                {
                    board.GameBoard[position.Row, position.Column] = Marker;
                    positionTaken = false;
                }
                else
                {
                    Console.WriteLine("This space is already occupied");
                    positionTaken = true;
                }
            } while (positionTaken == true);
		}
	}
}
