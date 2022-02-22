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
    public partial class MessageForm : Form
    {
        public MessageForm(string i_MessageToPop)
        {
            InitializeComponent();
            Message.Text = i_MessageToPop;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}