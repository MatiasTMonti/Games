using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Personaje
    {
        public struct Coordinates
        {
            public int x;
            public int y;
        }

        public Coordinates coord;

        public Personaje()
        {
            
        }

        public static Personaje operator +(Personaje v1, Input.Vector v2)
        {
            Personaje su = new Personaje();
            su.x = v1.x + v2.x;
            su.y = v1.y + v2.y;
            return su;
        }
    }
}
