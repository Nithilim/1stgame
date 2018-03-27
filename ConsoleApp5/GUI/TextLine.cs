using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class TextLine:GuiObject, IRenderable
    {
        protected string Line;

        public TextLine(string Line, int LineX, int LineY, int LineWidth) : base(LineWidth, 0, LineX, LineY)
        {
            this.Line = Line;
        }
        public void Render()
        {
            if (Width > Line.Length)
            {
                Console.SetCursorPosition(X, Y);
                int offset = (Width+1 - Line.Length) / 2;
                for(int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }
            Console.Write(Line);
        }
    }
}
