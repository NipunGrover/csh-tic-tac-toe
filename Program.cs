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
        PrintTicTacToeLines(ticTacToeBoard);
    }

    static void PrintTicTacToeLines(string[][] board)
    {
        for (int row = 0; row < board.Length; row++)
        {
            Console.WriteLine(string.Join(" | ", board[row]));

            if (row < board.Length - 1)
            {
                Console.WriteLine(" -------------");
            }
        }
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