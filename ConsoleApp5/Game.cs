using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Game
    {
        private static void Main()
        {
            Hero myHero = new Hero("Jonas Kablys", 0, 0);
            myHero.MoveDown();
            myHero.PrintInfo();
            List<Enemy> mobs = new List<Enemy>();
            Random rnd = new Random();
            int enemyCount = 0;
            for(int i = 0; i<10; i++)
            {
                Enemy mob = new Enemy("Kibir", enemyCount, rnd.Next(0, 10), rnd.Next(0, 10));
                mobs.Add(mob);
                enemyCount++;
            }
            foreach(Enemy mob in mobs)
            {
                mob.MoveDown();
            }
            Console.ReadKey();
        }
    }
}
