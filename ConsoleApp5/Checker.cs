using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Checker
    {
        private GenerateLevel blocks = new GenerateLevel();
        private bool result;
        public bool CollisionCheck(int blockX, int blockY, int bulletX, int bulletY)
        {
            if (blockX == bulletX && blockY == bulletY)
            {
                return result = true;
            }
            else
            {
                return result = false;
            }
        }
        public bool DropCheck(int[] dropCord, int bulletX, int bulletY)
        {
            if (dropCord[0] == bulletX && dropCord[1] == bulletY)
            {
                return result = true;
            }
            else
            {
                return result = false;
            }
        }
        public bool IfEmpty()
        {
            if (blocks.GetBlockCordX().Count == 0 && blocks.GetBlockCordY().Count == 0)
            {
                return result = true;
            }
            else
            {
                return result = false;
            }
        }
    }
}
