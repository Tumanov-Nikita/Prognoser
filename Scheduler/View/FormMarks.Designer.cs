namespace Prognoser.View
{
    partial class FormMarks
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBegin = new System.Windows.Forms.TextBox();
            this.textBoxMaxBegin = new System.Windows.Forms.TextBox();
            this.textBoxMaxEnd = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 1000D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 2D;
            chartArea1.Name = "Оценка продаж";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Оценка объёмов продаж";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 14);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(845, 303);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Оценка продаж";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(96, 346);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxBegin
            // 
            this.textBoxBegin.Location = new System.Drawing.Point(171, 377);
            this.textBoxBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBegin.Name = "textBoxBegin";
            this.textBoxBegin.Size = new System.Drawing.Size(47, 22);
            this.textBoxBegin.TabIndex = 2;
            this.textBoxBegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressDouble);
            // 
            // textBoxMaxBegin
            // 
            this.textBoxMaxBegin.Location = new System.Drawing.Point(171, 404);
            this.textBoxMaxBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaxBegin.Name = "textBoxMaxBegin";
            this.textBoxMaxBegin.Size = new System.Drawing.Size(47, 22);
            this.textBoxMaxBegin.TabIndex = 3;
            this.textBoxMaxBegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressDouble);
            // 
            // textBoxMaxEnd
            // 
            this.textBoxMaxEnd.Location = new System.Drawing.Point(171, 433);
            this.textBoxMaxEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaxEnd.Name = "textBoxMaxEnd";
            this.textBoxMaxEnd.Size = new System.Drawing.Size(47, 22);
            this.textBoxMaxEnd.TabIndex = 4;
            this.textBoxMaxEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressDouble);
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(171, 461);
            this.textBoxEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(47, 22);
            this.textBoxEnd.TabIndex = 5;
            this.textBoxEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressDouble);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Начало";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Начало максимума";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Конец максимума";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Конец";
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.AllowUserToAddRows = false;
            this.dataGridViewMarks.AllowUserToDeleteRows = false;
            this.dataGridViewMarks.AllowUserToResizeRows = false;
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(366, 346);
            this.dataGridViewMarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.ReadOnly = true;
            this.dataGridViewMarks.RowHeadersVisible = false;
            this.dataGridViewMarks.RowTemplate.Height = 24;
            this.dataGridViewMarks.Size = new System.Drawing.Size(474, 153);
            this.dataGridViewMarks.TabIndex = 11;
            this.dataGridViewMarks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(235, 346);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 38);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 461);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewMarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxMaxEnd);
            this.Controls.Add(this.textBoxMaxBegin);
            this.Controls.Add(this.textBoxBegin);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMarks";
            this.Text = "Метки";
            this.Load += new System.EventHandler(this.FormMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBegin;
        private System.Windows.Forms.TextBox textBoxMaxBegin;
        private System.Windows.Forms.TextBox textBoxMaxEnd;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMarks;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}