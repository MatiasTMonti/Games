using System;

namespace ConsoleApp1
{
    class Input
    {
        private ConsoleKey up;
        private ConsoleKey down;
        private ConsoleKey right;
        private ConsoleKey left;
        private Personaje player;

        public Input(Personaje player, ConsoleKey up, ConsoleKey down, ConsoleKey right, ConsoleKey left)
        {
            this.player = player;
            this.up = up;
            this.down = down;
            this.right = right;
            this.left = left;
        }

        public void CheckInput(ConsoleKey key)
        {
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

