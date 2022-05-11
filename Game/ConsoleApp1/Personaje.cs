using System;

namespace ConsoleApp1
{
    class Personaje
    {
        Random rand = new Random();

        private int randomRespawnX;
        private int randomRespawnY;

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

        private int points = 0;
        private int lifes = 5;

        public void RespawnRandom()
        {
            randomRespawnX = rand.Next(0, 21);
            randomRespawnY = rand.Next(0, 21);

            posX = randomRespawnX;
            PosY = randomRespawnY;
        }

        public void DrawPlayers(string draw)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(draw);
        }

        public int GetPoints()
        {
            return points;
        }

        public void SetPoints(int points)
        {
            this.points = points;
        }

        public int GetLifes()
        {
            return lifes;
        }

        public void SetLifes(int lifes)
        {
            this.lifes = lifes;
        }
    }
}
