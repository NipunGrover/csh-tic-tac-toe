using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    internal class GameDraw
    {
        static public void PrintTicTacToeLines(string[][] board)
        {
            Console.WriteLine(" |---|---|---|");
            for (int row = 0; row < board.Length; row++)
            {
                Console.WriteLine(string.Join(" | ", board[row]));

                if (row < board.Length )
                {
                    Console.WriteLine(" |---|---|---|");
                }
            }
        }
    }
}
