using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class Frame:GuiObject
    {
        protected char FrameSymbol;

        public Frame (int FrameWidth, int FrameHeight, int FrameX, int FrameY, char FrameSymbol):base(FrameWidth, FrameHeight, FrameX, FrameY)
        {
            this.FrameSymbol = FrameSymbol;
        }

        public override void Render()
        {
            for(int i=0; i < Width;i++)
            {
                Console.SetCursorPosition(X+i, Y);
                Console.Write(FrameSymbol);
                Console.SetCursorPosition(X + i, Y + Height);
                Console.Write(FrameSymbol);
            }
            Console.Write(FrameSymbol);
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y+i);
                Console.Write(FrameSymbol);
                Console.SetCursorPosition(X + Width, Y + i);
                Console.Write(FrameSymbol);
            }

        }
    }
}
