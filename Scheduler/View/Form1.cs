using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace laba_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataBase.metkas.Add(new Metka {
                name = "Малые убытки",
                begin = 1,
                max_begin = 100,
                max_end = 200,
                end = 300,
                max = 1
            });
            DataBase.metkas.Add(new Metka
            {
                name = "Средние убытки",
                begin = 200,
                max_begin = 300,
                max_end = 400,
                end = 500,
                max = 1
            });
            DataBase.metkas.Add(new Metka
            {
                name = "Большие убытки",
                begin = 400 ,
                max_begin = 500,
                max_end = 600,
                end = 700,
                max =1
            });
            init_chart();
            init_data_grid();
        }

        public void init_chart() {
            chart1.Series.Clear();
            Random random = new Random();
            for (int i = 0; i < DataBase.metkas.Count; i++) {
                Series series = new Series(DataBase.metkas[i].name);
                series.ChartType = SeriesChartType.Line;
                series.ChartArea = "Оценка убытков";
                series.Points.AddXY(DataBase.metkas[i].begin, 0);
                series.Points.AddXY(DataBase.metkas[i].max_begin, DataBase.metkas[i].max);
                series.Points.AddXY(DataBase.metkas[i].max_end, DataBase.metkas[i].max);
                series.Points.AddXY(DataBase.metkas[i].end, 0);
                series.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                series.BorderWidth = 5;

                chart1.Series.Add(series);
            }
        }

        public void init_data_grid() {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataBase.metkas;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;

                string name = dataGridView1[0, CurrentRow].Value.ToString();
                for (int i = 0; i < DataBase.metkas.Count; i++)
                {
                    if (DataBase.metkas[i].name == name)
                    {
                        textBox1.Text = DataBase.metkas[i].name;
                        textBox2.Text = DataBase.metkas[i].begin.ToString();
                        textBox3.Text = DataBase.metkas[i].max_begin.ToString();
                        textBox4.Text = DataBase.metkas[i].max_end.ToString();
                        textBox5.Text = DataBase.metkas[i].end.ToString();
                        //textBox6.Text = DataBase.metkas[i].max.ToString();
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox2.Text) ||
                !String.IsNullOrEmpty(textBox3.Text) || !String.IsNullOrEmpty(textBox4.Text)
                || !String.IsNullOrEmpty(textBox5.Text)) {
                bool check = false;
                for (int i = 0; i < DataBase.metkas.Count; i++)
                {
                    if (DataBase.metkas[i].name == textBox1.Text)
                    {
                        DataBase.metkas[i].name = textBox1.Text;
                        DataBase.metkas[i].begin = Convert.ToDouble(textBox2.Text);
                        DataBase.metkas[i].max_begin = Convert.ToDouble(textBox3.Text);
                        DataBase.metkas[i].max_end = Convert.ToDouble(textBox4.Text);
                        DataBase.metkas[i].end = Convert.ToDouble(textBox5.Text);
                        //DataBase.metkas[i].max = Convert.ToDouble(textBox6.Text);
                        check = true;

                    }
                }
                if (!check)
                {
					DataBase.metkas.Add(new Metka
					{
						name = textBox1.Text,
						begin = Convert.ToDouble(textBox2.Text),
						max_begin = Convert.ToDouble(textBox3.Text),
						max_end = Convert.ToDouble(textBox4.Text),
						end = Convert.ToDouble(textBox5.Text),
						max = 1 //Convert.ToDouble(textBox6.Text)
                    }
                    );
                }
                init_chart();
                init_data_grid();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                //textBox6.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;

                string name = dataGridView1[0, CurrentRow].Value.ToString();
                for (int i = 0; i < DataBase.metkas.Count; i++)
                {
                    if (DataBase.metkas[i].name == name)
                    {
                        DataBase.metkas.RemoveAt(i);
                    }
                }
                init_data_grid();
                init_chart();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }
    }
}
