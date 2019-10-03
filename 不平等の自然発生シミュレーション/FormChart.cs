using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 不平等の自然発生シミュレーション
{
    public partial class FormChart : Form
    {
        private int Population;
        private long Balance;
        private int Pay;
        private long[] people;       // 人々の所持金リスト
        private Random rand = new Random();

        private readonly string chart_area1 = "Area1";
        private readonly string legend1 = "Graph1";

        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea(chart_area1));
            chart1.ChartAreas[0].AxisX.Title = "所持金(%)";
            chart1.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Title = "人数";
            chart1.ChartAreas[0].AxisY.IsLabelAutoFit = false;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            people = new long[Population];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = Balance;
            }
            DrawChart();
        }

        public void SetParameters(int population, long blance, int pay)
        {
            Population = population;
            Balance = blance;
            Pay = pay;
        }

        public void DoWork()
        {
            while(true)
            {
                RunGame();
                DrawChart();
                Thread.Sleep(100);
            }
        }

        private void RunGame()
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] > 0)
                {
                    int selected = rand.Next(Population);
                    if (selected == i)
                    {
                        selected = rand.Next(Population);
                    }
                    people[selected] += Pay;
                    people[i] -= Pay;
                }
            }
        }

        private void DrawChart()
        {
            var table = new Dictionary<long, int>();
            for (int i = 0; i < people.Length; i++)
            {
                long key = people[i];

                if (table.ContainsKey(key) == true)
                {
                    int count = table[key] + 1;
                    table[key] = count;
                }
                else
                {
                    table.Add(key, 1);
                }
            }

            chart1.Series.Clear();
            chart1.Series.Add(legend1);
            chart1.Series[0].ChartType = SeriesChartType.Point;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series[0].IsValueShownAsLabel = false;

            foreach (var item in table)
            {
                double coordxPopulation = (double)item.Value;
                double percentBalance = (double)item.Key / (double)Balance * 100.0;
                DataPoint dp = new DataPoint(percentBalance, coordxPopulation);
                chart1.Series[0].Points.Add(dp);
            }
            chart1.Update();
        }
    }
}
