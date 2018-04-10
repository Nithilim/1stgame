using System;
using ConsoleApp5.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class GenerateLevel
    {
        private string levelSymbol;
        private ConsoleColor symbolColor;
        //private int amountOfSymbols;
        private List<int> blockCordX = new List<int>();
        private List<int> blockCordY = new List<int>();

        public GenerateLevel (string levelSymbol, ConsoleColor symbolColor)
        {
            this.levelSymbol = levelSymbol;
            this.symbolColor = symbolColor;

        }
        public GenerateLevel() { }
        public void Render()
        {
            int y = 1;
            int x = 2;
            Console.ForegroundColor = symbolColor;
            for (int a = 28; a > 0; a -= 2)
            {
                Repeater repeatString = new Repeater(levelSymbol, a);
                Console.SetCursorPosition(x, y);
                Console.WriteLine(repeatString.Repeat());
                y++;
                x++;
                blockCordX.Add(x);
                blockCordY.Add(y);
            }
        }
        public int[] GetDrop()
        {
            Random rnd = new Random();
            int CordX = rnd.Next(2, 28);
            int CordY = rnd.Next(1, blockCordY.Last()-1);
            int[] dropCord = new int[] { CordX, CordY };
            return dropCord;
        }
        public List<int> GetBlockCordX()
        {
            return blockCordX;
        }
        public List<int> GetBlockCordY()
        {
            return blockCordY;
        }
        public void RemoveAtCollision(int index)
        {
            if (blockCordX.Count > index && blockCordY.Count > index)
            {
                blockCordX.RemoveAt(index);
                blockCordY.RemoveAt(index);
            }
        }
    }
}
