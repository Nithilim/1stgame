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

        public Frame (int FrameWidth, int FrameHeight, int FrameX, int FrameY, char FrameSymbol):base(FrameWidth, FrameHeight, FrameY, FrameY)
        {
            this.FrameSymbol = FrameSymbol;
        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            for(int i = 0; i < Width; i++)
            {
                Console.Write(FrameSymbol);
            }
            for(int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(FrameSymbol);
                Y++;
            }
            Y--;
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Width; i++)
            {
                Console.Write(FrameSymbol);
                X++;
            }
            X--;
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(FrameSymbol);
                Y--;
            }
        }
    }
}
