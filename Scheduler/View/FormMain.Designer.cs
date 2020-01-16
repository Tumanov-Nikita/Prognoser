namespace Prognoser.View
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебныеГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPrognose = new System.Windows.Forms.Button();
            this.buttonTimeLine = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(980, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учебныеГруппыToolStripMenuItem,
            this.меткиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // учебныеГруппыToolStripMenuItem
            // 
            this.учебныеГруппыToolStripMenuItem.Name = "учебныеГруппыToolStripMenuItem";
            this.учебныеГруппыToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.учебныеГруппыToolStripMenuItem.Text = "Список литературы";
            this.учебныеГруппыToolStripMenuItem.Click += new System.EventHandler(this.список_литературыToolStripMenuItem_Click);
            // 
            // меткиToolStripMenuItem
            // 
            this.меткиToolStripMenuItem.Name = "меткиToolStripMenuItem";
            this.меткиToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.меткиToolStripMenuItem.Text = "Метки";
            this.меткиToolStripMenuItem.Click += new System.EventHandler(this.меткиToolStripMenuItem_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "Временные ряды";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Временные ряды";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 31);
            this.chart1.Name = "chart1";
            series2.ChartArea = "Временные ряды";
            series2.Legend = "Временные ряды";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(980, 273);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Временной ряд";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 302);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(980, 207);
            this.dataGridView.TabIndex = 2;
            // 
            // buttonPrognose
            // 
            this.buttonPrognose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrognose.Location = new System.Drawing.Point(853, 515);
            this.buttonPrognose.Name = "buttonPrognose";
            this.buttonPrognose.Size = new System.Drawing.Size(115, 39);
            this.buttonPrognose.TabIndex = 3;
            this.buttonPrognose.Text = "Прогноз";
            this.buttonPrognose.UseVisualStyleBackColor = true;
            this.buttonPrognose.Click += new System.EventHandler(this.buttonPrognose_Click);
            // 
            // buttonTimeLine
            // 
            this.buttonTimeLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimeLine.Location = new System.Drawing.Point(519, 515);
            this.buttonTimeLine.Name = "buttonTimeLine";
            this.buttonTimeLine.Size = new System.Drawing.Size(223, 39);
            this.buttonTimeLine.TabIndex = 4;
            this.buttonTimeLine.Text = "Построить временной ряд";
            this.buttonTimeLine.UseVisualStyleBackColor = true;
            this.buttonTimeLine.Click += new System.EventHandler(this.buttonTimeLine_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 566);
            this.Controls.Add(this.buttonTimeLine);
            this.Controls.Add(this.buttonPrognose);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебныеГруппыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem меткиToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonPrognose;
        private System.Windows.Forms.Button buttonTimeLine;
    }
}