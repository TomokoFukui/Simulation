using System;
using System.Windows.Forms;

/// <summary>
/// 平等な初期状態からランダムに行動した結果、偏りが生じた状態で安定するという事象のシミュレーション。
/// 最初の所持金は全員等しく１万円。ランダムに決めた相手に1000円渡す。お金がないときは渡せない。
/// </summary>
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
