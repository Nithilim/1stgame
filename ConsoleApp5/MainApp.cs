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
            Thread first = new Thread(new ThreadStart(loopA));
            Thread second = new Thread(new ThreadStart(loopB));
            first.Start();
            second.Start();
            Console.ReadKey();
        }
        static void loopA()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Bandom loop A");
                System.Threading.Thread.Sleep(50);
            }
        }
        static void loopB()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Bandom daugiau loop B");
                System.Threading.Thread.Sleep(60);
            }
        }
    }
}
