using System;

namespace ConsoleApp1
{
    class Enemigo
    {
        public int posX = 0;
        public int posY = 0;

        Random rand = new Random();

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

        public void InputEnemys()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    if (PosY > 0)
                    {
                        posY--;
                    }
                    break;
                case 1:
                    if (PosY < 20)
                    {
                        PosY++;
                    }  
                    break;
                case 2:
                    if (posX > 0)
                    {
                        posX--;
                    }                 
                    break;
                case 3:
                    if (posX < 20)
                    {
                        posX++;
                    }
                    break;
                default:
                    break;
            }
        }

        public void DrawEnemys(string draw)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(draw);
        }
    }
}
