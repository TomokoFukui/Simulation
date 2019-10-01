using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 不平等の自然発生シミュレーション
{
    public partial class FormChart : Form
    {
        readonly int population = 100000;           // 人口
        readonly int money = 10000;                 // 所持金
        int[] people;                               // 人々の所持金リスト
        Random rand = new Random();

        readonly string chart_area1 = "Area1";
        readonly string legend1 = "Graph1";

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
            chart1.ChartAreas[0].AxisY.Title = "人数比(%)";
            chart1.ChartAreas[0].AxisY.IsLabelAutoFit = false;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            people = new int[population];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = money;
            }
            DrawChart();
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
                    int selected = rand.Next(population);
                    if (selected == i)
                    {
                        selected = rand.Next(population);
                    }
                    people[selected] += 1000;
                    people[i] -= 1000;
                }
            }
        }

        private void DrawChart()
        {
            var table = new Dictionary<int, int>();
            for (int i = 0; i < people.Length; i++)
            {
                int key = people[i];

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
                double percentPopulation = (double)item.Value * 100.0 / (double)population;
                double percentMoney = (double)item.Key * 100.0 / (double)money;
                DataPoint dp = new DataPoint(percentMoney, percentPopulation);
                chart1.Series[0].Points.Add(dp);
            }
            chart1.Update();
        }
    }
}
