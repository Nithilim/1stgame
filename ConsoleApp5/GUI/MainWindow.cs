using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.GUI
{
    class MainWindow : IRenderable
    {
        private Button startButton = new Button(10, 4, 5, 24, "Start");
        private Button highScoreButton = new Button(13, 4, 21, 24, "High Score");
        private Button quitButton = new Button(10, 4, 40, 24, "Quit");
        private Frame mainWindowFrame = new Frame(59, 29, 0, 0, '#');
        private int buttonPosition = 0;
        //private TestGhostDodger startGame = new TestGhostDodger();
        //private Bouncer startGame = new Bouncer();

        private void AddText()
        {
            List<string> text = new List<string>();
            text.Add("This is a console game");
            text.Add("Made by Paulius Kandratavicius");
            text.Add("For Vilnius Coding School C# courses");
            text.Add("Select Start to start game");
            text.Add("Select High Scores to see high scores");
            text.Add("Select Quit to close the game");
            text.Add("Once game is started use Spacebar to shoot");
            text.Add("Left and Right arrow keys to navigate");
            text.Add("Destroy all '*' to win or press ESC to exit in game");
            TextBlock mainWindowText = new TextBlock(1, 5, 60, text);
            mainWindowText.Render();
        }
        public void Render()
        {
            mainWindowFrame.Render();
            startButton.SetButtonActive();
            startButton.Render();
            highScoreButton.Render();
            quitButton.Render();
            AddText();
            ControlConditions();
        }
        private void ControlConditions()
        {
            bool buttonSelected = false;
            ConsoleKeyInfo consoleKey = new ConsoleKeyInfo();
            while (!Console.KeyAvailable&&buttonSelected==false) {
                consoleKey = Console.ReadKey(true);
                switch (consoleKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        buttonPosition -= 1;
                        break;
                    case ConsoleKey.RightArrow:
                        buttonPosition += 1;
                        break;
                }
                if (buttonPosition < 0)
                {
                    buttonPosition = 2;
                }
                if (buttonPosition > 2)
                {
                    buttonPosition = 0;
                }
                switch (buttonPosition)
                {
                    case 0:
                        startButton.SetButtonActive();
                        quitButton.SetButtonInactive();
                        highScoreButton.SetButtonInactive();
                        quitButton.Render();
                        highScoreButton.Render();
                        startButton.Render();
                        break;
                    case 1:
                        highScoreButton.SetButtonActive();
                        startButton.SetButtonInactive();
                        quitButton.SetButtonInactive();
                        quitButton.Render();
                        highScoreButton.Render();
                        startButton.Render();
                        break;
                    case 2:
                        quitButton.SetButtonActive();
                        startButton.SetButtonInactive();
                        highScoreButton.SetButtonInactive();
                        quitButton.Render();
                        highScoreButton.Render();
                        startButton.Render();
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("Unexpected Error!");
                        break;
                }
                if (buttonPosition==2&&consoleKey.Key==ConsoleKey.Enter)
                {
                    buttonSelected = true;
                    Environment.Exit(0);
                }
                if (buttonPosition == 0 && consoleKey.Key == ConsoleKey.Enter)
                {
                    buttonSelected = true;
                    //startGame.Render();
                }
                if (buttonPosition == 1 && consoleKey.Key == ConsoleKey.Enter)
                {
                    throw new NotImplementedException();
                    //TODO: Gets the highscores!
                }
            }
        }
    }
}
