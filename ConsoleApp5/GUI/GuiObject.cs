using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class GuiObject
    {
        protected int Width;
        protected int Height;
        protected int X;
        protected int Y;

        public GuiObject (int Width, int Height, int X, int Y)
        {
            this.Width = Width;
            this.Height = Height;
            this.X = X;
            this.Y = Y;
        }
        public virtual void Render() { }
    }
}
