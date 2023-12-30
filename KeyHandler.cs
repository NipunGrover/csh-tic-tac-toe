using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    internal class KeyHandler
    {
        static public void KeyboardKeys()
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                }
                else if (key.Key == ConsoleKey.UpArrow && Console.CursorTop > 0)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                }
                else if (key.Key == ConsoleKey.LeftArrow && Console.CursorLeft > 0)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                }

            }
        }
    }
}
