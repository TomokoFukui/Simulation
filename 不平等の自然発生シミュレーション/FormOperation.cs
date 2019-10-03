using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 不平等の自然発生シミュレーション
{
    public partial class FormOperation : Form
    {
        public FormOperation()
        {
            InitializeComponent();
        }

        private void FormOperation_Load(object sender, EventArgs e)
        {
            labelCaption.Text = "平等な初期状態からランダムに行動すると"+ Environment.NewLine + "偏りが生じた状態で安定するという事象をシミュレートします。";

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            int population = int.Parse(textBoxPopulation.Text);
            long blance = int.Parse(textBoxBlance.Text) * 10000;
            int pay = int.Parse(textBoxPay.Text);
            Task.Run(() => RunSimulation(population, blance, pay));
        }

        private void RunSimulation(int population, long balance, int pay)
        {
            FormChart formChart = new FormChart();
            formChart.SetParameters(population, balance, pay);
            formChart.Show();
            formChart.DoWork();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
