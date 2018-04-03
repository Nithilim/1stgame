using System;
using ConsoleApp5.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class BouncerPlatfrom:IRenderable
    {
        private int xCord = 13;
        private int yCord = 30;
        private string platform;
        private char shootSymbol;

        //public BouncerPlatfrom(string platform, char shootSymbol)
        //{
        //    this.platform = platform;
        //    this.shootSymbol = shootSymbol;
        //}

        public void MoveLeft()
        {
            if (xCord < 25 && xCord > 0)
            {
                xCord--;
                Console.SetCursorPosition(0,30);
                Console.Write(Repeat(" ", 30));
                Console.SetCursorPosition(xCord, yCord);
                Console.Write(platform);
            }
            else
            {
                xCord+=2;
            }
        }
        public void MoveRight()
        {
            if (xCord < 25 && xCord > 0)
            {
                xCord++;
                Console.SetCursorPosition(0, 30);
                Console.Write(Repeat(" ", 30));
                Console.SetCursorPosition(xCord, yCord);
                Console.Write(platform);
            }
            else
            {
                xCord-=2;
            }
        }
        public void Shoot()
        {
            if (yCord < 29)
            {
                yCord++;
                Console.SetCursorPosition(xCord - 2, yCord);
                Console.Write('o');
            }
        }
        public void Render()
        {
            Console.SetCursorPosition(xCord, yCord);
            Console.Write(platform);
        }
        public int GetXCord()
        {
            return xCord;
        }
        public static string Repeat(string value, int count)
        {
            return new StringBuilder(value.Length * count).Insert(0, value, count).ToString();
        }
    }
}
