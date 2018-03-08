using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Enemy:Unit
    {
        private int Id;

        public Enemy(string EnemyName, int Id, int x, int y):base(x,y,EnemyName)
        {
            this.Id = Id;
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
        public int GetId()
        {
            return Id;
        }
    }
}
