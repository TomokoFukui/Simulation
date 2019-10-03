using System;
using System.Windows.Forms;

namespace 不平等の自然発生シミュレーション
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormOperation());
        }
    }
}
