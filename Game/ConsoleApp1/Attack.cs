using System;

namespace ConsoleApp1
{
    class Attack
    {
        public int posX = 10;
        public int posY = 10;

        public int PosX
        {
            get => posX;
            set => posX = value;
        }

        public int PosY
        {
            get => posY;
            set => posY = value;
        }

        public void LogicAttack()
        {
            Console.SetCursorPosition(30, 10);
            Console.Write("Atacar");
        }

        public void DrawPowerup(string draw)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(draw);
        }
    }
}
