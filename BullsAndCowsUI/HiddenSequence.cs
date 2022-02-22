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
    public partial class HiddenSequence : UserControl
    {
        public HiddenSequence()
        {
            InitializeComponent();
        }

        internal void RevealSolution(string i_Solution)
        {
            Dictionary<Color, char> colorToChar = ColorPick.ColorToChar;
            int index = 3;

            foreach (char c in i_Solution)
            {
                foreach (Color color in colorToChar.Keys)
                {
                    if (colorToChar[color] == c)
                    {
                        Controls[index].BackColor = color;
                        index--;
                    }
                }
            }
        }
    }
}
