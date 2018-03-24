using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class TextBlock:GuiObject
    {
        private List<TextLine> textBlock = new List<TextLine>();

        public TextBlock (int lineX, int lineY, int width, List<string> textList, int height):base(width, 0, lineX, lineY)
        {
            for(int i = 0; i<textList.Count; i++)
            {
                textBlock.Add(new TextLine(textList[i], lineX, lineY, width));
            }
        }
        public override void Render()
        {
            for (int i = 0; i < textBlock.Count; i++)
            {
                textBlock[i].Render();
            }
        }
    }
}
