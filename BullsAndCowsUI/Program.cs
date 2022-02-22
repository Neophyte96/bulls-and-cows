using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCowsUI
{
    public static class Program
    {
        public static void Main()
        {
            Run();
        }

        internal static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new StartForm().ShowDialog();
        }
    }
}
