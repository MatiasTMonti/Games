using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Personaje()
        {
            
        }

        public void DrawPlayers(string draw)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(draw);
        }
    }
}
