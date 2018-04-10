using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Tester
    {
        public List<int> test = new List<int>();
        public void testing()
        {
            for(int i = 0; i < 8; i++)
            {
                test.Add(i);
            }
        }
        public void Render()
        {
            foreach(int item in test)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        public void RemoveAtCollision(int index)
        {
            if (test.Count > index)
            {
                test.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Bad Input");
            }
        }
    }
}
