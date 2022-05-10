using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enemigo
    {
        Random random = new Random();
        private int randomMove;
        private int moveDir;

        private int randomRespawnX;
        private int randomRespawnY;

        struct Enemy
        {
            public int x;
            public int y;
        }

        Enemy enemy;

        public void Move()
        {
            randomMove = random.Next(0, 2);
            moveDir = random.Next(0, 4);

            if (moveDir == 0 && enemy.y < 20)
            {
                enemy.y += randomMove;
            }
            else if (moveDir == 1 && enemy.y > 0)
            {
                enemy.y -= randomMove;
            }
            else if (moveDir == 2 && enemy.x < 20)
            {
                enemy.x += randomMove;
            }
            else if (moveDir == 3 && enemy.x > 0)
            {
                enemy.x -= randomMove;
            }
        }

        public void ChangePos()
        {
            randomRespawnX = random.Next(0, 21);
            randomRespawnY = random.Next(0, 21);

            enemy.x = randomRespawnX;
            enemy.y = randomRespawnY;
        }

        public void WriteEnemy()
        {
            Console.SetCursorPosition(enemy.x, enemy.y);
            Console.Write("E");
        }

        public int GetPosEnemyX()
        {
            return enemy.x;
        }

        public int GetPosEnemyY()
        {
            return enemy.y;
        }
    }
}
