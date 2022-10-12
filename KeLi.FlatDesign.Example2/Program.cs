using System;
using System.Windows.Forms;

using KeLi.FlatDesign.Example2.Forms;

namespace KeLi.FlatDesign.Example2
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}