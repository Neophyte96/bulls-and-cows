using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCowsUI
{
    public partial class ColorPick : Form
    {
        private static readonly Dictionary<Color, char> sr_ColorToChar = new Dictionary<Color, char>();
        private Button m_ButtonToChange;

        internal static Dictionary<Color, char> ColorToChar
        {
            get
            {
                return sr_ColorToChar;
            }
        }

        internal static string ConvertColorListToString(List<Color> i_ColorList)
        {
            StringBuilder resultsSB = new StringBuilder();

            foreach (Color color in i_ColorList)
            {
                resultsSB.Append(sr_ColorToChar[color]);
            }

            return resultsSB.ToString();
        }

        public ColorPick()
        {
            InitializeComponent();
            initializeDictionary();
        }

        internal void SetColor(Button i_ButtonToChange)
        {
            m_ButtonToChange = i_ButtonToChange;
            this.ShowDialog();
        }

        private void buttonOnClick(object sender, EventArgs e)
        {
            Button colorButton = sender as Button;
            m_ButtonToChange.BackColor = colorButton.BackColor;
            this.Visible = false;
        }

        private void initializeDictionary()
        {
            char charToMap = 'A';

            foreach (Button button in Controls)
            {
                sr_ColorToChar[button.BackColor] = charToMap;
                charToMap++;
            }
        }
    }
}