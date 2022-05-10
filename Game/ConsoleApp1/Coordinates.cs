using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Coordinates
    {
        struct Coords
        {
            int x;
            int y;
        }

        Coords coord;

        public static Coordinates operator +(Coordinates v1,  v2)
        {
            Coordinates su = new Coordinates();
            su.x = v1.x + v2.x;
            su.y = v1.y + v2.y;
            return su;
        }
    }
}
