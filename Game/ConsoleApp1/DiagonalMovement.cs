using System;

namespace ConsoleApp1
{
    class DiagonalMovement : Movement
    {
        public override void Move(ref int x, ref int y, Random rand)
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    if (y > 0 && x > 0)
                    {
                        y--;
                        x--;
                    }
                    break;
                case 1:
                    if (y < 20 && x > 0)
                    {
                        y++;
                        x--;
                    }
                    break;
                case 2:
                    if (x > 0 && y < 20)
                    {
                        x--;
                        y++;
                    }
                    break;
                case 3:
                    if (x < 20 && y < 20)
                    {
                        x++;
                        y++;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
