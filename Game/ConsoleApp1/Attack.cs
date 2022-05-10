using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Attack
    {
        struct attack
        {
            public int x;
            public int y;
        }

        attack attacks;

        public void AttackInitialPos()
        {
            attacks.x = 10;
            attacks.y = 10;
        }

        public void LogicAttack()
        {
            Console.SetCursorPosition(45, 10);
            Console.Write("Atacar");
        }

        public void DrawAttack()
        {
            Console.SetCursorPosition(attacks.x, attacks.y);
            Console.Write("A");
        }
        public int GetPosAttackX()
        {
            return attacks.x;
        }

        public int GetPosAttackY()
        {
            return attacks.y;
        }
    }
}
