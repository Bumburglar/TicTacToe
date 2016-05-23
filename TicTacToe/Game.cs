using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Game
	{
		public string[] gameBoard;
		public bool playerWon;
        public Player player1;
        public Player player2;
        public bool playerTurn; // When this is true, Player 1 is playing.  When this is false, player 2 is playing.
		public Game()
		{
			gameBoard = new string[9];
			for (int x = 0;x< gameBoard.Length; x++)
			{
				gameBoard[x] = (x+1).ToString();
                player1 = new Player("X");
                player2 = new Player("O");
                playerTurn = true;
			}
		}
		public void Draw(string[] gameBoard) // Can draw a text gameboard (square) of any size given the gameboard as a parameter.
		{
			int side = (int) Math.Sqrt(gameBoard.Length+1);
			//Console.WriteLine(gameBoard.Length);
			int position = 0;
			for (int x = 1; x < side+1; x++)
			{
				string output = "|";
				for (int y = 1; y < side+1; y++)
				{
					if (position > gameBoard.Length) break;
					output += gameBoard[position]  + " | ";
					position++;
				}
				Console.WriteLine(output);
			}

		}
		public void setPosition(int position,Player player)
		{
			gameBoard[position] = player.marker;	
		}
        public void WinCheck()
        {
            #region Horizontal Win Condition
            if (gameBoard[0] == gameBoard[1] && gameBoard[1] == gameBoard[2])
            {
                playerWon = true;
            }
            else if (gameBoard[3] == gameBoard[4] && gameBoard[4] == gameBoard[5])
            {
                playerWon = true;
            }
            else if (gameBoard[6] == gameBoard[7] && gameBoard[7] == gameBoard[8])
            {
                playerWon = true;
            }
            #endregion
            #region Vertical Win Condition
            {
                if (gameBoard[0] == gameBoard[3] && gameBoard[3] == gameBoard[6])
                {
                    playerWon = true;
                }
                else if (gameBoard[1] == gameBoard[4] && gameBoard[4] == gameBoard[7])
                {
                    playerWon = true;
                }
                else if (gameBoard[2] == gameBoard[5] && gameBoard[5] == gameBoard[8])
                {
                    playerWon = true;
                }
            }
            #endregion
            #region Diagonal Win Condition
            if(gameBoard[0] == gameBoard[4] && gameBoard[4] == gameBoard[8])
            {
                playerWon = true;
            }
            else if (gameBoard[2] == gameBoard[4] && gameBoard[4] == gameBoard[6])
            {
                playerWon = true;
            }
            #endregion
        }
        public void Play(int position,Player player)
        {
            position -= 1;
            if (position > 8)
            {
                Console.WriteLine("That position doesn't exist on the board");
            }
            else if (gameBoard[position] != "x" && gameBoard[position] != "o")
            {
                gameBoard[position] = player.marker;
            }
            else
            {
                Console.WriteLine("Someone already played there!");
            }
            
        }
	}
}
