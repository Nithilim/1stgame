using System;
using ConsoleApp5.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Bouncer:IRenderable
    {
        private BouncerPlatfrom platfrom = new BouncerPlatfrom();
        private List<int> xList = new List<int>();
        private List<int> yList = new List<int>();
        public void Render()
        {
            Console.SetWindowSize(30, 30);
            Console.Clear();
            ConsoleKeyInfo consoleKey = new ConsoleKeyInfo();
            GenerateLevel();
            platfrom.Render();
            do
            {
                while (!Console.KeyAvailable && consoleKey.Key != ConsoleKey.Escape)
                {
                    consoleKey = Console.ReadKey(true);
                    switch (consoleKey.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            platfrom.MoveLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            platfrom.MoveRight();
                            break;
                        case ConsoleKey.Spacebar:
                            PlatformShoot(platfrom.GetXCord()+2);
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }
                System.Threading.Thread.Sleep(20);
            } while (xList.Count() != 0);
            Console.Clear();
            Console.SetCursorPosition(10, 15); 
            Console.WriteLine("You've Won!");
            Console.ReadKey(false);
        
        }
        public void GenerateLevel()
        {
            int y = 1;
            int x = 2;
            for (int a = 26; a > 0; a-=2)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(Repeat("*", a));
                y++;
                x++;
                xList.Add(x);
                yList.Add(y);
            }

        }
        public static string Repeat(string value, int count)
        {
            return new StringBuilder(value.Length * count).Insert(0, value, count).ToString();
        }
        public void PlatformShoot(int x)
        {
            bool CheckCollision=false;
            for (int y = 30; y > 0; y--)
            {
                Console.SetCursorPosition(x, y);
                Console.Write('o');
                CheckCollision = Collision(x, y);
                if (CheckCollision == true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(' ');
                    for(int a = 0; a < xList.Count(); a++)
                    {
                        if (xList[a] == x && yList[a] == y)
                        {
                            xList.RemoveAt(a);
                            yList.RemoveAt(a);
                        }
                    }
                }
                System.Threading.Thread.Sleep(90);
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
            }
        }
        public bool Collision(int x, int y)
        {
            bool Check=false;
            if (xList.Contains(x))
            {
                if (yList.Contains(y))
                {
                    Check = true;
                }
                else
                {
                    Check = false;
                }
            }
            return Check;
        }
        private void AddText()
        {
                List<string> text = new List<string>();
                text.Add("The game is still in progress");
                text.Add("The goal is to destroy all * ");
                text.Add("Use Space button to shoot");
                text.Add("Left and right arrow keys to navigate");
                text.Add("Press Enter key to begin");
                TextBlock introductionText = new TextBlock(1, 5, 30, text);
                introductionText.Render();
            
        }
    }
}
