using Prognoser;
using Prognoser.Controller;
using Prognoser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Prognoser.View
{
    public partial class FormMarks : Form
    {
        Checkers check = new Checkers();
        MarkController Controller;
        static PrognoserContext db;
        List<TextBox> TextBoxes;
        public FormMarks()
        {
            InitializeComponent();
            db = new PrognoserContext();
            TextBoxes = new List<TextBox>();
            TextBoxes.Add(textBoxName);
            TextBoxes.Add(textBoxBegin);
            TextBoxes.Add(textBoxMaxBegin);
            TextBoxes.Add(textBoxMaxEnd);
            TextBoxes.Add(textBoxEnd);
            DrawChart();
        }

        public void DrawChart()
        {
            chart1.Series.Clear();
            Random random = new Random();
            foreach(Mark currentMark in db.Marks)
            {
                
                if (currentMark != null)
                {
                    Series series = new Series(currentMark.Name);
                    series.ChartType = SeriesChartType.Line;
                    series.ChartArea = "Оценка продаж";
                    series.Points.AddXY(currentMark.Begin, 0);
                    series.Points.AddXY(currentMark.Max_begin, 1);
                    series.Points.AddXY(currentMark.Max_end, 1);
                    series.Points.AddXY(currentMark.End, 0);
                    series.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    series.BorderWidth = 4;

                    chart1.Series.Add(series);
                    if (chart1.ChartAreas[0].AxisX.Maximum < currentMark.End)
                    {
                        chart1.ChartAreas[0].AxisX.Maximum = currentMark.End;
                    }
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count == 1)
            {
                int CurrentRow = dataGridViewMarks.SelectedCells[0].RowIndex;
                string nameId1 = dataGridViewMarks[1, CurrentRow].Value.ToString();
                string nameId2 = dataGridViewMarks[2, CurrentRow].Value.ToString();
                string nameId3 = dataGridViewMarks[3, CurrentRow].Value.ToString();
                string nameId4 = dataGridViewMarks[4, CurrentRow].Value.ToString();
                string nameId5 = dataGridViewMarks[5, CurrentRow].Value.ToString();
                textBoxName.Text = nameId1;
                textBoxBegin.Text = nameId2;
                textBoxMaxBegin.Text = nameId3;
                textBoxMaxEnd.Text = nameId4;
                textBoxEnd.Text = nameId5;
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (check.Firmness(textBoxName)&& check.Firmness(textBoxBegin)&& 
                check.Firmness(textBoxMaxBegin) && check.Firmness(textBoxMaxEnd)&&
                check.Firmness(textBoxEnd))
            {
                Controller.Add(textBoxName.Text, Convert.ToDouble(textBoxBegin.Text), 
                               Convert.ToDouble(textBoxMaxBegin.Text), Convert.ToDouble(textBoxMaxEnd.Text),
                               Convert.ToDouble(textBoxEnd.Text));
                DrawChart();
                refreshForm(dataGridViewMarks, TextBoxes);
            }  
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (check.Firmness(textBoxName) && check.Firmness(textBoxBegin) &&
                check.Firmness(textBoxMaxBegin) && check.Firmness(textBoxMaxEnd) &&
                check.Firmness(textBoxEnd))
            {
                int CurrentRow = dataGridViewMarks.SelectedCells[0].RowIndex;
                Controller.Edit(textBoxName.Text, Convert.ToDouble(textBoxBegin.Text),
                               Convert.ToDouble(textBoxMaxBegin.Text), Convert.ToDouble(textBoxMaxEnd.Text),
                               Convert.ToDouble(textBoxEnd.Text), Convert.ToInt32(dataGridViewMarks[0, CurrentRow].Value));
                DrawChart();
                refreshForm(dataGridViewMarks, TextBoxes);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridViewMarks.SelectedCells[0].RowIndex;
            int rowId = Convert.ToInt32(dataGridViewMarks[0, selectedId].Value);
            Controller.DeleteByIndex(rowId);
        }

        private void FormMarks_Load(object sender, EventArgs e)
        {
            Controller = new MarkController(db);
            db.Marks.Load();
            dataGridViewMarks.DataSource = db.Marks.Local.ToBindingList();
            dataGridViewMarks.Columns[0].Visible = false;
            dataGridViewMarks.Columns[6].Visible = false;
        }

        public static void refreshForm(DataGridView dataGridView, List<TextBox> textBoxes)
        {
            db.Marks.Load();
            dataGridView.DataSource = db.Marks.Local.ToBindingList();
            dataGridView.Update();
            dataGridView.Refresh();
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }

        private void textBox_KeyPressDouble(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < '0' || c > '9') && c != '\b' && c != '.')
            {
                e.Handled = true;
            }
        }
    }
}
