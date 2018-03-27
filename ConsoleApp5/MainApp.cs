using ConsoleApp5.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MainApp
    {
        private static void Main()
        {
            Console.SetWindowSize(60, 30);
            MainWindow kek = new MainWindow();
            kek.Render();
            Console.ReadKey();

        }
    }
}
