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
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            Task.Run(() => RunSimulation());
        }

        private void RunSimulation()
        {
            FormChart formChart = new FormChart();
            formChart.Show();
            formChart.DoWork();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
