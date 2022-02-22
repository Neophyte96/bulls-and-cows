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
    public partial class StartForm : Form
    {
        private readonly int r_MaxGuesses = GameManagement.MaxNumOfGuesses;
        private readonly int r_MinGuesses = GameManagement.MinNumOfGuesses;
        private int m_NumOfGuesses;

        public StartForm()
        {
            m_NumOfGuesses = r_MinGuesses;
            InitializeComponent();
            buttonNumberOfGuesses.Text = string.Format("Number of chances: {0}", m_NumOfGuesses);
        }

        private void buttonNumberOfGuesses_Click(object sender, EventArgs e)
        {
            m_NumOfGuesses++;
            if (m_NumOfGuesses > r_MaxGuesses)
            {
                m_NumOfGuesses = r_MinGuesses;
            }

            buttonNumberOfGuesses.Text = string.Format("Number of chances: {0}", m_NumOfGuesses);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BoardForm(m_NumOfGuesses).ShowDialog();
        }
    }
}
