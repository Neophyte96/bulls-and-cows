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
    public partial class ResultButtons : UserControl
    {
        public ResultButtons()
        {
            InitializeComponent();
        }

        internal void FillUpResultButtons(int i_NumberOfBull, int i_NumberOfCows)
        {
            int index = 3;

            for (int i = 0; i < i_NumberOfBull; i++)
            {
                Controls[index].BackColor = Color.Black;
                index--;
            }

            for (int i = 0; i < i_NumberOfCows; i++)
            {
                Controls[index].BackColor = Color.Yellow;
                index--;
            }
        }
    }
}