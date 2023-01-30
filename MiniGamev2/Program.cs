using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGamev2
{
    internal class Program
    {
        static Player player = new Player();
        static bool gameOver = false;
        static ConsoleKeyInfo choice;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            while (gameOver == false)
            {
                Console.Clear();
                PlayerDraw(player.x, player.y);
                PlayerUpdate();
            }
        }

        static void PlayerDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(player.character);
        }

        static void PlayerUpdate()
        {
            choice = Console.ReadKey(true);
            Console.Write(" ");

            switch (choice.Key)
            {
                case ConsoleKey.Escape:
                    gameOver = true;
                    break;

                case ConsoleKey.W:
                        player.y--;
                        break;

                case ConsoleKey.S:
                        player.y++;
                        break;

                case ConsoleKey.A:
                        player.x--;
                        break;

                case ConsoleKey.D:
                        player.x++;
                        break;

                default:
                    {
                        break;
                    }
            }
        }
    }
}
