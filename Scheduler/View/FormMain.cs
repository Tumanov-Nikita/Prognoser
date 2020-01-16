using Prognoser.Controller;
using Prognoser.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Prognoser.View
{
    public partial class FormMain : Form
    {
        static PrognoserContext DB;
        List<Mark> allMarks;
        List<Trend> trends;
        List<Mark> marksOfLiterature;
        public FormMain()
        {
            InitializeComponent();
            DB = new PrognoserContext();
        }

        private void список_литературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLiteratureList formLiterature = new FormLiteratureList();
            formLiterature.ShowDialog();
        }

        private void меткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarks formMarks = new FormMarks();
            formMarks.ShowDialog();
        }

        private void ComputeChart()
        {
            DB.Literatures.Load();
            Literature emptyCheck = (Literature)DB.Literatures.Where(x => x.Id > -1).FirstOrDefault();
            if (emptyCheck != null)
            {
                DB.Marks.Load();
                allMarks = DB.Marks.ToList();
                marksOfLiterature = new List<Mark>();
                foreach (Literature literature in DB.Literatures)
                {
                    double sum = literature.Price * literature.SoldCopies;
                    marksOfLiterature.Add(ComputeBelonging(sum));
                }
                trends = new List<Trend>();
                int time = 0;
                for (int i = 0; i < marksOfLiterature.Count - 1; i++)
                {
                    Trend newTrend = new Trend(marksOfLiterature[i], marksOfLiterature[i + 1]);
                    if (newTrend.First.Max_end < newTrend.Second.Max_end)
                    {
                        newTrend.Name = "Рост";
                        newTrend.Count = 1;
                    }
                    else if (newTrend.First.Max_end == newTrend.Second.Max_end)
                    {
                        newTrend.Name = "Стабильность";
                        newTrend.Count = 0;
                    }
                    else
                    {
                        newTrend.Name = "Спад";
                        newTrend.Count = -1;
                    }
                    newTrend.Time = time;
                    trends.Add(newTrend);
                    time ++;
                }
            }
            if (trends.Count > 0)
            {
                int maxTime = trends[trends.Count - 1].Time;
                chart1.ChartAreas[0].AxisX.Maximum = maxTime;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                DrawChart();
                DrawDatagrid(dataGridView);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ComputeChart();   
        }

        public void DrawDatagrid(DataGridView dataGridView)
        {
            List<DataSource> dataSources = new List<DataSource>();
            for (int i = 0; i < trends.Count; i++)
            {
                dataSources.Add(new DataSource
                {
                    name = trends[i].Name,
                    name_first = trends[i].First.Name,
                    name_second = trends[i].Second.Name,
                    time = trends[i].Time,
                    count = trends[i].Count
                });
            }
            dataGridView.DataSource = null;
            dataGridView.DataSource = dataSources;
            dataGridView.Update();
            dataGridView.Refresh();
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonTimeLine_Click(object sender, EventArgs e)
        {
            ComputeChart();
        }

        public void DrawChart()
        {
            chart1.Series.Clear();
            Random random = new Random();
            Series series = new Series("Временной ряд");
            series.ChartType = SeriesChartType.Line;
            series.ChartArea = "Временные ряды";
            foreach (Trend trend in trends)
            {
                series.Points.AddXY(trend.Time, trend.Count);
            }
            series.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            series.BorderWidth = 4;
            chart1.Series.Add(series);

        }

        public Mark ComputeBelonging(double solds)
        {
            Mark resultMark = new Mark();
            double differ = double.MaxValue;
            
            foreach(Mark mark in allMarks)
            {
                if (Math.Abs(mark.Max_begin - solds) < differ)
                {
                    differ = Math.Abs(mark.Begin - solds);
                    resultMark = mark;
                }
                if (Math.Abs(mark.Max_end - solds) < differ)
                {
                    differ = Math.Abs(mark.Begin - solds);
                    resultMark = mark;
                }
            }

            return resultMark;
        }

        private void buttonPrognose_Click(object sender, EventArgs e)
        {
            Mark first = marksOfLiterature[marksOfLiterature.Count - 2];
            Mark second = marksOfLiterature[marksOfLiterature.Count - 1];


            Mark mark = null;
            int max = 0;
            foreach (var trend in trends)
            {
                if (trend.First == first & trend.Second == second)
                {
                    if (trend.Count > max)
                    {
                        mark = trend.Prognosed;
                        max = trend.Count;
                    }
                    if (trend.Count == max)
                    {
                        if (mark == null)
                        {
                            int maxM = 0;
                            foreach (var m in allMarks)
                            {
                                if (m.Direction >= maxM)
                                {
                                    maxM = m.Direction;
                                    mark = m;
                                }
                            }
                            max = 0;
                            break;
                        }
                        Mark m1 = trend.Prognosed;
                        Mark m2 = mark;

                        if (m1.Direction > m2.Direction)
                        {
                            mark = trend.Prognosed;
                            max = trend.Count;
                        }
                    }
                }
            }

            Console.WriteLine(mark.Name);
            MessageBox.Show("Прогнозное значение: " + mark.Name);
        }
    }
}
