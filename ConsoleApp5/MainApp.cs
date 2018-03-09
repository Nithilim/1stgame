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
            Frame frm = new Frame(10, 5, 2, 2, '^');
            frm.Render();
            TextLine line = new TextLine("Koooooooooop",20,15,10,1);
            line.Render();
            Console.ReadKey();
        }
    }
}
