using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Input
    {
        private ConsoleKey up;
        private ConsoleKey down;
        private ConsoleKey right;
        private ConsoleKey left;

        public Input(ConsoleKey up, ConsoleKey down, ConsoleKey right, ConsoleKey left)
        {
            this.up = up;
            this.down = down;
            this.right = right;
            this.left = left;
        }

        public void CheckInput(ConsoleKey key, Personaje player)
        {
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey(true).Key;
            }

            if (key == up && player.posY > 0)
            {
                MoveUp(ref player.posY);
            }
            else if (key == down && player.posY < 20)
            {
                MoveDown(ref player.posY);
            }
            else if (key == right && player.posX < 20)
            {
                MoveRight(ref player.posX);
            }
            else if (key == left && player.posX > 0)
            {
                MoveLeft(ref player.posX);
            } 
        }

        private void MoveUp(ref int posY)
        {
            posY--;
        }

        private void MoveDown(ref int posY)
        {
            posY++;
        }

        private void MoveRight(ref int posX)
        {
            posX++;
        }

        private void MoveLeft(ref int posX)
        {
            posX--;
        }
    }
}

