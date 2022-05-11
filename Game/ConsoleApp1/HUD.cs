using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HUD
    {
        public int posX = 30;
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

        Personaje player;

        private int points = 0;
        private int lifes = 5;

        public HUD(Personaje player)
        {
            this.player = player;

        }

        public void LogicPoints()
        {
            player.SetPoints(points++);
        }

        public void LogicLifes()
        {
            player.SetLifes(lifes--);
        }

        public void DrawHUD()
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("Points: " + player.GetPoints() + "Lifes: " + player.GetLifes());
        }
    }
}
