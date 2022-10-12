using System;
using System.Windows.Forms;

using KeLi.FlatDesign.Example1.Forms;

namespace KeLi.FlatDesign.Example1
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}