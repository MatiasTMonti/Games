using System;

namespace ConsoleApp1
{
    abstract class Movement
    {
        public abstract void Move(ref int x, ref int y, Random rand);
    }
}
