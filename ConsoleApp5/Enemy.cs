using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Enemy
    {
        private int Id;
        private int XCord;
        private int YCord;
        private string EnemyName;

        public Enemy(string EnemyName, int id, int x, int y)
        {
            this.EnemyName = EnemyName;
            Id = id;
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
            Console.WriteLine($"Current {EnemyName} {Id} coordinates X: {XCord}; Y: {YCord}");
        }
    }
}
