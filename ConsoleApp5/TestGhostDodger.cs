using System;
using ConsoleApp5.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    // Game to dodge Invaders. At the moment cannot implement due to lack of knowledge regarding
    // task splitting to different threads.
    class TestGhostDodger:IRenderable
    {
        private int setTimer = 300;
        private bool lost = false;
        public void Render()
        {
            Console.Clear();
            Console.SetWindowSize(30, 30);
            while (lost == false)
            { 
                PrintEnemy();
            }
        }
        private void PrintEnemy()
        {
            char enemyChar = '*';
            for(int a = 0; a < 25; a++)
            {
                for (int i=2; i < 9; i++)
                {
                Console.SetCursorPosition(i, a);
                Console.Write(enemyChar);
                }
                for (int i = 1; i < 10; i++)
                {
                    Console.SetCursorPosition(i, a+1);
                    if (i == 4 || i==6)
                    {
                        Console.Write('O');
                    }
                    else
                    {
                        Console.Write(enemyChar);
                    }
                }
                for (int i = 0; i < 11; i++)
                {
                    Console.SetCursorPosition(i, a+2);
                    Console.Write(enemyChar);
                }
                for (int i = 0; i < 11; i++)
                {
                    Console.SetCursorPosition(i, a+3);
                    if (i == 1 || i == 9)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write(enemyChar);
                    }
                }
                for (int i = 0; i < 11; i++)
                {
                    Console.SetCursorPosition(i, a+4);
                    if (i == 0 || i == 2 || i == 8 || i == 10)
                    {
                        Console.Write(enemyChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                for (int i = 0; i < 11; i++)
                {
                    Console.SetCursorPosition(i, a+5);
                    if (i == 3 || i == 4 || i == 6 || i == 7)
                    {
                        Console.Write(enemyChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                System.Threading.Thread.Sleep(setTimer);
                Console.Clear();
            }
        }

    }
}
