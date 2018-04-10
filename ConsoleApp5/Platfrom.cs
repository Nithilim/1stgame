using System;
using ConsoleApp5.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Platfrom:IRenderable
    {
        private int xCord = 13;
        private int yCord = 30;
        private string platform;
        private Repeater stringRepeat = new Repeater(" ", 30);

        public Platfrom(string platform, char shootSymbol)
        {
            this.platform = platform;
        }

        public void MoveLeft()
        {
            if (xCord < 25 && xCord > 0)
            {
                xCord--;
                Console.SetCursorPosition(0,30);
                Console.Write(stringRepeat);
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
                Console.Write(stringRepeat);
                Console.SetCursorPosition(xCord, yCord);
                Console.Write(platform);
            }
            else
            {
                xCord-=2;
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
    }
}
