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
        HUD hudP1;
        Attack attack;

        ConsoleKey cki;

        bool AttackOn;

        public void Run()
        {
            cki = Console.ReadKey(true).Key;

            Init();

            do
            {
                Input();

                Update();

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

            hudP1 = new HUD(player1);

            attack = new Attack();

            AttackOn = false;
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

        private void Update()
        {
            if (player1.posX == enemy1.posX && player1.posY == enemy1.posY && AttackOn)
            {
                hudP1.LogicPoints();
                enemy1.RespawnRandom();
                AttackOn = false;
            }

            if (player1.posX == enemy1.posX && player1.posY == enemy1.posY)
            {
                hudP1.LogicLifes();
                player1.RespawnRandom();
            }

            if (player1.posX == attack.posX && player1.posY == attack.posY)
            {
                AttackOn = true;
            }
        }

        private void Draw()
        {
            player1.DrawPlayers("1");
            player2.DrawPlayers("2");
            enemy1.DrawEnemys("E");
            hudP1.DrawHUD();

            if (!AttackOn)
                attack.DrawPowerup("A");

            if (AttackOn)
                attack.LogicAttack();
        }
    }
}
