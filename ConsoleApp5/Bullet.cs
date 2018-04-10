using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Bullet
    {
        private ConsoleColor bulletColor;
        private char bulletSymbol;
        private bool collision;
        private Checker check = new Checker();
        private GenerateLevel blocks = new GenerateLevel();

        public Bullet(char bulletSymbol)
        {
            this.bulletSymbol = bulletSymbol;
        }
        public void StandardBullet(int xCord)
        {
            xCord -= 2;
            List<int> blockCordX = blocks.GetBlockCordX();
            List<int> blockCordY = blocks.GetBlockCordY();
            for (int yCord = 28; yCord > 1 ; yCord--)
            {
                for (int a = 0; a < blockCordX.Count(); a++)
                {
                    collision = check.CollisionCheck(blockCordX[a], blockCordY[a], xCord, yCord);
                    if (collision == true)
                    {
                        //Remove entries in lists
                        break;
                    }
                }
                do
                {
                    Console.SetCursorPosition(xCord - 2, yCord);
                    Console.Write(bulletSymbol);
                } while (collision == false);
            }
        }
        public void PurpleBullet(int xCord)
        {
            xCord -= 2;
            for (int yCord = 28; yCord > 1; yCord--)
            {
                Console.SetCursorPosition(xCord - 2, yCord);
                Console.Write(bulletSymbol);
            }
        }
    }
}
