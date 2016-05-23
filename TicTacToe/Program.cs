using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Game game = new Game();
			game.Draw(game.gameBoard);
            Console.WriteLine("Press any button to begin!");
			Console.ReadLine();
            do
            {
                int choice = Int32.Parse(Console.ReadLine());
                if (choice.GetType() !=  typeof(int))
                {
                    Console.WriteLine("That's not an option, sorry!");
                }
                else if (game.playerTurn == false)
                {
                    game.Play(choice, game.player2);
                    game.Draw(game.gameBoard);
                    game.playerTurn = true;
                    game.WinCheck();
                }
                else
                {
                    game.Play(choice, game.player1);
                    game.Draw(game.gameBoard);
                    game.playerTurn = false;
                    game.WinCheck();
                }

            } while (game.playerWon == false);
            if (game.playerWon && game.playerTurn == false)
            {
                Console.WriteLine("Player 1 is the winner");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player 2 is the winner");
                Console.ReadLine();
            }
		}
	}
}
