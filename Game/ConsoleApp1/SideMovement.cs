using System;

namespace ConsoleApp1
{
    class SideMovement : Movement
    {
        public override void Move(ref int x, ref int y, Random rand)
        {
            switch (rand.Next(0, 2))
            {
                case 0:
                    if (x > 0)
                        x--;
                    break;
                case 1:
                    if (x < 20)
                        x++;
                    break;
                default:
                    break;
            }
        }
    }
}
