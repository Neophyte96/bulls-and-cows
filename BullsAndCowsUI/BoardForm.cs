using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;

namespace BullsAndCowsUI
{
    public partial class BoardForm : Form
    {
        private const int k_SpaceBetweenLines = 5;
        private static GuessButtons[] s_GuessButtons;
        private static ResultButtons[] s_ResultButtons;
        private readonly HiddenSequence r_HiddenSequence = new HiddenSequence();
        private readonly GameManagement r_Game;

        public BoardForm(int i_NumOfGuesses)
        {
            r_Game = new GameManagement(i_NumOfGuesses);
            s_GuessButtons = new GuessButtons[i_NumOfGuesses];
            s_ResultButtons = new ResultButtons[i_NumOfGuesses];
            InitializeComponent();
        }

        private void boardForm_Load(object sender, EventArgs e)
        {
            r_HiddenSequence.Location = new Point(10, 10);
            int lineHeight = r_HiddenSequence.Bottom + 20;

            for (int i = 0; i < s_GuessButtons.Length; i++)
            {
                GuessButtons guessButtonsLine = new GuessButtons();
                ResultButtons resButtons = new ResultButtons();

                guessButtonsLine.Location = new Point(r_HiddenSequence.Left, lineHeight);
                resButtons.Location = new Point(guessButtonsLine.Right + 5, lineHeight);
                s_GuessButtons[i] = guessButtonsLine;
                s_ResultButtons[i] = resButtons;
                lineHeight += guessButtonsLine.Height + k_SpaceBetweenLines;
            }

            s_GuessButtons[0].EnableButtons();
            this.Height = (s_GuessButtons.Length * (new GuessButtons().Height + k_SpaceBetweenLines)) + 110;
            this.Width = new GuessButtons().Width + new ResultButtons().Width + 40;
            this.Controls.Add(r_HiddenSequence);
            this.Controls.AddRange(s_GuessButtons);
            this.Controls.AddRange(s_ResultButtons);
        }

        internal void NextGuess()
        {
            r_Game.CurrentNumOfSteps++;
            if (r_Game.IsPlayerWon || r_Game.IsPlayerLost)
            {
                finishGame();
            }
            else
            {
                s_GuessButtons[r_Game.CurrentNumOfSteps - 1].DisableButtons();
                s_GuessButtons[r_Game.CurrentNumOfSteps].EnableButtons();
            }
        }

        internal void CheckResult(List<Color> i_ChosenColors)
        {
            string userChoiceString = ColorPick.ConvertColorListToString(i_ChosenColors);
            bool isValidGuess = true;

            isValidGuess = r_Game.GetResults(userChoiceString, out int o_NumberOfBull, out int o_NumberOfCows);
            if (!isValidGuess)
            {
                new MessageForm("Invalid Guess! you need to choose 4 different colors!").ShowDialog();
            }
            else
            {
                s_ResultButtons[r_Game.CurrentNumOfSteps].FillUpResultButtons(o_NumberOfBull, o_NumberOfCows);
                NextGuess();
            }
        }

        private void finishGame()
        {
            r_HiddenSequence.RevealSolution(r_Game.Solution);
            s_GuessButtons[r_Game.CurrentNumOfSteps - 1].DisableButtons();
        }
    }
}
