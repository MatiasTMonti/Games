using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            GameManager game = new GameManager();

            game.Run();
        }
    }
}
