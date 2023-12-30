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


            Task task = Task.Run(() => KeyHandler.KeyboardKeys());
            task.Wait();
        }

        



    }
}