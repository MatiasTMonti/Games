using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Input
    {
        struct Vector
        {
            public int x;
            public int y;
        }

        Vector vector;

        public Input(ConsoleKey up, ConsoleKey down, ConsoleKey right, ConsoleKey left)
        {
            Keyboard(up, down, right, left);
        }

        public void Keyboard(ConsoleKey up, ConsoleKey down, ConsoleKey right, ConsoleKey left)
        {
            MoveUp(up);
            MoveDown(down);
            MoveRight(right);
            MoveLeft(left);
        }

        private void MoveUp(ConsoleKey up)
        {
            if (true)
            {

            }
        }

        private void MoveDown(ConsoleKey down)
        {

        }

        private void MoveRight(ConsoleKey right)
        {

        }

        private void MoveLeft(ConsoleKey left)
        {

        }


    }
}

