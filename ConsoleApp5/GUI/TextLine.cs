using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class TextLine:GuiObject
    {
        protected string Line;

        public TextLine(string Line, int LineX, int LineY, int LineWidth, int LineHeight) : base(LineWidth, LineHeight, LineX, LineY)
        {
            this.Line = Line;
        }
        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            if (Width > Line.Length)
            {
                int offset = (Width - Line.Length) / 2;
                for(int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }
            Console.Write(Line);
        }
    }
}
