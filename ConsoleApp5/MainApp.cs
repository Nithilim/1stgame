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
            Button frm = new Button(10, 4, 5, 5, "aaa");
            frm.Render();
            Console.ReadKey();
        }
    }
}
