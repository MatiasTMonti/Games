using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GameManager
    {
        Personaje player1;
        Input input;

        ConsoleKey cki;

        public void Run()
        {
            cki = Console.ReadKey(true).Key;

            Init();

            do
            {
                Input();

                Console.Clear();

                Draw();

                Thread.Sleep(100);

            } while (true);
        }

        private void Init()
        {
            player1 = new Personaje();
            input = new Input(ConsoleKey.W, ConsoleKey.S, ConsoleKey.D, ConsoleKey.A);
        }

        private void Input()
        {
            cki = ConsoleKey.J;

            input.CheckInput(cki, player1);
        }

        private void Draw()
        {
            player1.DrawPlayers("1");
        }  
    }
}
