using System;
using ConsoleApp5.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class LevelInfoFlow
    {
        GenerateLevel level = new GenerateLevel("#", ConsoleColor.DarkBlue);
        Platfrom platform = new Platfrom("=====", 'o');
        Checker check = new Checker();
        public void Render()
        {
            Console.SetWindowSize(30, 30);
            Console.Clear();
            ConsoleKeyInfo consoleKey = new ConsoleKeyInfo();
            level.Render();
            platform.Render();
            while(check.IfEmpty()==false)
            {
                while (!Console.KeyAvailable && consoleKey.Key != ConsoleKey.Escape)
                {
                    consoleKey = Console.ReadKey(true);
                    switch (consoleKey.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            platform.MoveLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            platform.MoveRight();
                            break;
                        case ConsoleKey.Spacebar:
                            new Bullet('o').StandardBullet(platform.GetXCord());
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }
                System.Threading.Thread.Sleep(20);
            }
            Console.Clear();
            Console.SetCursorPosition(10, 15);
            Console.WriteLine("You've Won!");
            Console.ReadKey(false);

        }
    }
}
