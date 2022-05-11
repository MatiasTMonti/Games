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
        Personaje player2;
        Enemigo enemy1;
        Input inputP1;
        Input inputP2;

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
            player2 = new Personaje();

            enemy1 = new Enemigo();

            inputP1 = new Input(player1, ConsoleKey.W, ConsoleKey.S, ConsoleKey.D, ConsoleKey.A);
            inputP2 = new Input(player2, ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.RightArrow, ConsoleKey.LeftArrow);
        }

        private void Input()
        {
            if (Console.KeyAvailable)
            {
                cki = Console.ReadKey(true).Key;
            }

            inputP1.CheckInput(cki);
            inputP2.CheckInput(cki);

            enemy1.InputEnemys();

            cki = ConsoleKey.J;
        }

        private void Draw()
        {
            player1.DrawPlayers("1");
            player2.DrawPlayers("2");
            enemy1.DrawEnemys("E");
        }  
    }
}
