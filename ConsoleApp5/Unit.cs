using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Unit
    {
        protected int XCord;
        protected int YCord;
        protected string Name;

        public Unit (int XCord, int YCord, string Name)
        {
            this.XCord = XCord;
            this.YCord = YCord;
            this.Name = Name;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Unit {Name} is currently located in these coordinates X: {XCord}; Y: {YCord}");
        }
    }
}
