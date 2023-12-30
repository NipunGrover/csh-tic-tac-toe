namespace tic_tac_toe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Example Tic Tac Toe board
            string[][] ticTacToeBoard = new string[][]
            {
                new string[] { "", " ", " ", " ", "" },
                new string[] { "", " ", " ", " ", "" },
                new string[] { "", " ", " ", " ", "" },

            };

            // Print the Tic Tac Toe lines
            GameDraw.PrintTicTacToeLines(ticTacToeBoard);
        }

        /*
                while (true)
                { 
                    ConsoleKeyInfo keya = Console.ReadKey(true);

                    if (keya.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                    }
                    else if (keya.Key == ConsoleKey.UpArrow && Console.CursorTop > 0)
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    }
                    else if (keya.Key == ConsoleKey.LeftArrow && Console.CursorLeft > 0)
                    { 
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                    else if (keya.Key == ConsoleKey.RightArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                    }

                */




    }
}