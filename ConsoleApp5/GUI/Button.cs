using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class Button:GuiObject
    {
        private Frame buttonActive;
        private Frame buttonInactive;
        private TextLine textLine;
        private bool isActive=false;

        public Button(int width, int height, int xCord, int yCord, string buttonText):base(width, height, xCord, yCord)
        {
            buttonActive = new Frame(width, height, xCord, yCord, '+');
            buttonInactive = new Frame(width, height, xCord, yCord, '-');
            textLine = new TextLine(buttonText, xCord + 1, yCord+(height/2), width-2);
        }
        public void SetButtonActive()
        {
            isActive = true;
        }
        public void SetButtonInactive()
        {
            isActive = false;
        }
        public override void Render()
        {
            if (isActive == true)
            {
                buttonActive.Render();
                textLine.Render();
            }
            else
            {
                buttonInactive.Render();
                textLine.Render();
            }
        }
    }
}
