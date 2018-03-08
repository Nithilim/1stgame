using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Game
    {
        public static void StartGame()
        {
            GameScreen screen = new GameScreen(35, 35);
            screen.SetHero(new Hero("Kablis", 0, 0));
            Random rndCord = new Random();
            for (int i = 0; i < 10; i++)
            {
                screen.MobAdd(new Enemy("Kibiras", i, rndCord.Next(0, 35), rndCord.Next(0, 35)));
            }
            bool needToRender = true;
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case (ConsoleKey.Escape):
                            needToRender = false;
                            break;
                        case (ConsoleKey.DownArrow):
                            screen.MoveHeroDown();
                            break;
                        case (ConsoleKey.UpArrow):
                            screen.MoveHeroUp();
                            break;
                        case (ConsoleKey.LeftArrow):
                            screen.GetHero().MoveLeft();
                            break;
                        case (ConsoleKey.RightArrow):
                            screen.GetHero().MoveRight();
                            break;
                    }
                    Console.Clear();
                    screen.Render();
                    System.Threading.Thread.Sleep(250);
                }
            } while (needToRender == true);
            Console.ReadKey();
        }
    }
}
