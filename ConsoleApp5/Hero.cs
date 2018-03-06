using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Hero
    {
        private string HeroName;
        private int XCord;
        private int YCord;

        public Hero(string HeroName, int x, int y)
        {
            this.HeroName = HeroName;
            XCord = x;
            YCord = y;
        }

        public void MoveRight()
        {
            XCord = XCord + 1;
        }
        public void MoveLeft()
        {
            XCord = XCord - 1;
        }
        public void MoveUp()
        {
            YCord = YCord - 1;
        }
        public void MoveDown()
        {
            YCord = YCord + 1;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Current {HeroName} coordinates X: {XCord}; Y: {YCord}");
        }
    }
}
