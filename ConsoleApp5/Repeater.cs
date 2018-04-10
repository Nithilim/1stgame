using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Repeater
    {
        private string text;
        private int count;
        public Repeater(string text, int count)
        {
            this.text = text;
            this.count = count;
        }
        public string Repeat()
        {
            return new StringBuilder(text.Length * count).Insert(0, text, count).ToString();
        }
    }
}
