using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class MainWindow:IRenderable
    {
        private Button startButton = new Button(10, 4, 5, 24, "Start");
        private Button highScoreButton = new Button(13, 4, 21, 24, "High Score");
        private Button quitButton = new Button(10, 4, 40, 24, "Quit");
        private Frame mainWindowFrame = new Frame(59, 29, 0, 0, '#');

        private void AddText()
        {
            List<string> text=new List<string>();
            text.Add("This is a console game");
            text.Add("Made by Paulius Kandratavicius");
            text.Add("For Vilnius Coding School C# courses");
            text.Add("Select Start to start game");
            text.Add("Select High Scores to see high scores");
            text.Add("Select Quit to close the game");
            TextBlock mainWindowText = new TextBlock(1, 5, 60,text);
            mainWindowText.Render();
        }
        public void Render()
        {
            mainWindowFrame.Render();
            startButton.Render();
            highScoreButton.Render();
            quitButton.Render();
            AddText();
            startButton.SetButtonActive();
        }
        private void ControlConditions(KeyPressEventArgs e)
        {
            int buttonPosition=0;
            if (e.KeyChar == (char)Keys.Right)
            {
                buttonPosition += 1;
            }
            if (e.KeyChar == (char)Keys.Left)
            {
                buttonPosition -= 1;
            }
        }
    }
}
