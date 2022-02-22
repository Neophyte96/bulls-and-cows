using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCowsUI
{
    public partial class GuessButtons : UserControl
    {
        private readonly ColorPick r_PickColorForm = new ColorPick();
        internal List<Color> m_ChosenColors = new List<Color>();

        public GuessButtons()
        {
            InitializeComponent();
        }

        internal void EnableButtons()
        {
            GuessButton1.Enabled = true;
            GuessButton2.Enabled = true;
            GuessButton3.Enabled = true;
            GuessButton4.Enabled = true;
        }

        internal void DisableButtons()
        {
            foreach (Button button in Controls)
            {
                button.Enabled = false;
            }
        }

        private void guessButtonClick(object sender, EventArgs e)
        {
            Button guessButton = sender as Button;

            r_PickColorForm.SetColor(guessButton);
            if (isAllButtonsSelected())
            {
                CheckResButton.Enabled = true;
            }
        }

        private bool isAllButtonsSelected()
        {
            bool isAllButtonsSelected = ColorPick.ColorToChar.ContainsKey(GuessButton1.BackColor) &&
                                        ColorPick.ColorToChar.ContainsKey(GuessButton2.BackColor) &&
                                        ColorPick.ColorToChar.ContainsKey(GuessButton3.BackColor) &&
                                        ColorPick.ColorToChar.ContainsKey(GuessButton4.BackColor);

            return isAllButtonsSelected;
        }

        private void checkResButton_Click(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;

            m_ChosenColors = new List<Color>();
            m_ChosenColors.Add(GuessButton1.BackColor);
            m_ChosenColors.Add(GuessButton2.BackColor);
            m_ChosenColors.Add(GuessButton3.BackColor);
            m_ChosenColors.Add(GuessButton4.BackColor);
            (ParentForm as BoardForm).CheckResult(m_ChosenColors);
        }
    }
}
