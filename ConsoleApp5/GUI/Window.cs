using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class Window:GuiObject,IRenderable
    {
        private Frame windowBorder;

        public Window (int cordX, int cordY, int width, int height, char symbol):base(width, height, cordX, cordY)
        {
            windowBorder = new Frame(width, height, cordX, cordY, symbol);
        }
        public void Render()
        {
            windowBorder.Render();
        }
    }
}
