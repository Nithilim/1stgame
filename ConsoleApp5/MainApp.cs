using ConsoleApp5.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    class MainApp
    {
        private static void Main()
        {
            Random dropType = new Random();
            
            for(int i = 0; i < 50; i++)
            {
                int dropChance = dropType.Next(0, 2);
                Console.WriteLine(dropChance);
                System.Threading.Thread.Sleep(50);
            }
            Console.ReadKey();
        }
    }
}
