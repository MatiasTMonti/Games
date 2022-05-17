using System;

namespace ConsoleApp1
{
    class NormalMovement : Movement
    {
        public override void Move(ref int x, ref int y, Random rand)
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    x++;
                    break;
                case 1:
                    x--;
                    break;
                case 2:
                    y++;
                    break;
                case 3:
                    y--;
                    break;
                default:
                    break;
            }
        }
    }
}
