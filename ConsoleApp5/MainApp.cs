using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MainApp
    {
        private static void Main()
        {
            GameScreen screen = new GameScreen(35, 35);
            screen.SetHero(new Hero("Kablis", 0, 0));
            Random rndCord = new Random();
            for(int i = 0; i < 10; i++)
            {
                screen.MobAdd(new Enemy("Kibiras", i, rndCord.Next(0, 35), rndCord.Next(0, 35)));
            }
            screen.GetHero().MoveLeft();
            screen.MoveAllMobDown();
            screen.Render();
            screen.GetEnemyById(2).MoveDown();
            screen.Render();
            Console.ReadKey();
        }
    }
}
