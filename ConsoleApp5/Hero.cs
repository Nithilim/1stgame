using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Hero:Unit
    {
        public Hero(string HeroName, int x, int y):base(x,y,HeroName)
        {
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
        public int GetY()
        {
            return YCord;
        }
    }
}
