using System;

namespace ConsoleApp1
{
    class Enemigo
    {
        public int posX = 0;
        public int posY = 0;

        Random rand = new Random();
        Movement movement;

        private int randomRespawnX;
        private int randomRespawnY;

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

        public Enemigo(int posX, int posY, Movement movement)
        {
            this.posX = posX;
            this.posY = posY;
            this.movement = movement;
        }

        public void Move()
        {
            movement.Move(ref posX, ref posY, rand);
        }

        public void RespawnRandom()
        {
            randomRespawnX = rand.Next(0, 21);
            randomRespawnY = rand.Next(0, 21);

            posX = randomRespawnX;
            PosY = randomRespawnY;
        }

        public void DrawEnemys(string draw)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(draw);
        }
    }
}
