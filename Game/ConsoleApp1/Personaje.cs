using System;

namespace ConsoleApp1
{
    class Personaje
    {
        public int posX = 0;
        public int posY = 0;

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

        public void DrawPlayers(string draw)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(draw);
        }
    }
}
