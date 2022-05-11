using System;

namespace ConsoleApp1
{
    class HUD
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

        Personaje player;

        private int points = 0;
        private int lifes = 5;

        public HUD(Personaje player, int posX, int posY)
        {
            this.player = player;
            this.posX = posX;
            this.posY = posY;
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
