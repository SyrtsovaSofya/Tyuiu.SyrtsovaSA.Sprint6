namespace Tyuiu.SyrtsovaSA.Sprint6.Task2.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SSA = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_SSA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SSA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SSA = new System.Windows.Forms.TextBox();
            this.labelStop_SSA = new System.Windows.Forms.Label();
            this.labelStart_SSA = new System.Windows.Forms.Label();
            this.groupBoxRes_SSA = new System.Windows.Forms.GroupBox();
            this.chartRes_SSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewRes_SSA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonHelp_SSA = new System.Windows.Forms.Button();
            this.buttonRes_SSA = new System.Windows.Forms.Button();
            this.labelTask_SSA = new System.Windows.Forms.Label();
            this.groupBoxTask_SSA.SuspendLayout();
            this.groupBoxInput_SSA.SuspendLayout();
            this.groupBoxRes_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_SSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_SSA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SSA
            // 
            this.groupBoxTask_SSA.Controls.Add(this.labelTask_SSA);
            this.groupBoxTask_SSA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_SSA.Name = "groupBoxTask_SSA";
            this.groupBoxTask_SSA.Size = new System.Drawing.Size(543, 289);
            this.groupBoxTask_SSA.TabIndex = 0;
            this.groupBoxTask_SSA.TabStop = false;
            this.groupBoxTask_SSA.Text = "Условие:";
            // 
            // groupBoxInput_SSA
            // 
            this.groupBoxInput_SSA.Controls.Add(this.textBoxStop_SSA);
            this.groupBoxInput_SSA.Controls.Add(this.textBoxStart_SSA);
            this.groupBoxInput_SSA.Controls.Add(this.labelStop_SSA);
            this.groupBoxInput_SSA.Controls.Add(this.labelStart_SSA);
            this.groupBoxInput_SSA.Location = new System.Drawing.Point(13, 309);
            this.groupBoxInput_SSA.Name = "groupBoxInput_SSA";
            this.groupBoxInput_SSA.Size = new System.Drawing.Size(282, 106);
            this.groupBoxInput_SSA.TabIndex = 1;
            this.groupBoxInput_SSA.TabStop = false;
            this.groupBoxInput_SSA.Text = "Ввод данных";
            // 
            // textBoxStop_SSA
            // 
            this.textBoxStop_SSA.Location = new System.Drawing.Point(154, 51);
            this.textBoxStop_SSA.Name = "textBoxStop_SSA";
            this.textBoxStop_SSA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_SSA.TabIndex = 3;
            // 
            // textBoxStart_SSA
            // 
            this.textBoxStart_SSA.Location = new System.Drawing.Point(10, 51);
            this.textBoxStart_SSA.Name = "textBoxStart_SSA";
            this.textBoxStart_SSA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_SSA.TabIndex = 2;
            // 
            // labelStop_SSA
            // 
            this.labelStop_SSA.AutoSize = true;
            this.labelStop_SSA.Location = new System.Drawing.Point(151, 32);
            this.labelStop_SSA.Name = "labelStop_SSA";
            this.labelStop_SSA.Size = new System.Drawing.Size(84, 16);
            this.labelStop_SSA.TabIndex = 1;
            this.labelStop_SSA.Text = "Конец шага:";
            // 
            // labelStart_SSA
            // 
            this.labelStart_SSA.AutoSize = true;
            this.labelStart_SSA.Location = new System.Drawing.Point(6, 32);
            this.labelStart_SSA.Name = "labelStart_SSA";
            this.labelStart_SSA.Size = new System.Drawing.Size(83, 16);
            this.labelStart_SSA.TabIndex = 0;
            this.labelStart_SSA.Text = "Старт шага:";
            // 
            // groupBoxRes_SSA
            // 
            this.groupBoxRes_SSA.Controls.Add(this.chartRes_SSA);
            this.groupBoxRes_SSA.Controls.Add(this.dataGridViewRes_SSA);
            this.groupBoxRes_SSA.Location = new System.Drawing.Point(562, 13);
            this.groupBoxRes_SSA.Name = "groupBoxRes_SSA";
            this.groupBoxRes_SSA.Size = new System.Drawing.Size(695, 402);
            this.groupBoxRes_SSA.TabIndex = 2;
            this.groupBoxRes_SSA.TabStop = false;
            this.groupBoxRes_SSA.Text = "Вывод данных";
            // 
            // chartRes_SSA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRes_SSA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRes_SSA.Legends.Add(legend3);
            this.chartRes_SSA.Location = new System.Drawing.Point(266, 22);
            this.chartRes_SSA.Name = "chartRes_SSA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRes_SSA.Series.Add(series3);
            this.chartRes_SSA.Size = new System.Drawing.Size(423, 374);
            this.chartRes_SSA.TabIndex = 1;
            this.chartRes_SSA.Text = "chart1";
            // 
            // dataGridViewRes_SSA
            // 
            this.dataGridViewRes_SSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_SSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Result});
            this.dataGridViewRes_SSA.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewRes_SSA.Name = "dataGridViewRes_SSA";
            this.dataGridViewRes_SSA.ReadOnly = true;
            this.dataGridViewRes_SSA.RowHeadersVisible = false;
            this.dataGridViewRes_SSA.RowHeadersWidth = 51;
            this.dataGridViewRes_SSA.RowTemplate.Height = 24;
            this.dataGridViewRes_SSA.Size = new System.Drawing.Size(240, 374);
            this.dataGridViewRes_SSA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 125;
            // 
            // Result
            // 
            this.Result.HeaderText = "F(X)";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 125;
            // 
            // buttonHelp_SSA
            // 
            this.buttonHelp_SSA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHelp_SSA.Location = new System.Drawing.Point(301, 309);
            this.buttonHelp_SSA.Name = "buttonHelp_SSA";
            this.buttonHelp_SSA.Size = new System.Drawing.Size(99, 104);
            this.buttonHelp_SSA.TabIndex = 3;
            this.buttonHelp_SSA.Text = " Справка";
            this.buttonHelp_SSA.UseVisualStyleBackColor = false;
            this.buttonHelp_SSA.Click += new System.EventHandler(this.buttonHelp_SSA_Click);
            // 
            // buttonRes_SSA
            // 
            this.buttonRes_SSA.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRes_SSA.Location = new System.Drawing.Point(406, 309);
            this.buttonRes_SSA.Name = "buttonRes_SSA";
            this.buttonRes_SSA.Size = new System.Drawing.Size(150, 104);
            this.buttonRes_SSA.TabIndex = 4;
            this.buttonRes_SSA.Text = "Выполнить";
            this.buttonRes_SSA.UseVisualStyleBackColor = false;
            this.buttonRes_SSA.Click += new System.EventHandler(this.buttonRes_SSA_Click);
            // 
            // labelTask_SSA
            // 
            this.labelTask_SSA.AutoSize = true;
            this.labelTask_SSA.Location = new System.Drawing.Point(10, 22);
            this.labelTask_SSA.Name = "labelTask_SSA";
            this.labelTask_SSA.Size = new System.Drawing.Size(429, 48);
            this.labelTask_SSA.TabIndex = 0;
            this.labelTask_SSA.Text = "Протабулировать функцию \r\ny = (5*x + 2.5)/(Math.Sin(x) + 2) + 2*x + 2;на заданном" +
    " диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 425);
            this.Controls.Add(this.buttonRes_SSA);
            this.Controls.Add(this.buttonHelp_SSA);
            this.Controls.Add(this.groupBoxRes_SSA);
            this.Controls.Add(this.groupBoxInput_SSA);
            this.Controls.Add(this.groupBoxTask_SSA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 4 | Сырцова С.А.";
            this.groupBoxTask_SSA.ResumeLayout(false);
            this.groupBoxTask_SSA.PerformLayout();
            this.groupBoxInput_SSA.ResumeLayout(false);
            this.groupBoxInput_SSA.PerformLayout();
            this.groupBoxRes_SSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_SSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_SSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SSA;
        private System.Windows.Forms.GroupBox groupBoxInput_SSA;
        private System.Windows.Forms.TextBox textBoxStop_SSA;
        private System.Windows.Forms.TextBox textBoxStart_SSA;
        private System.Windows.Forms.Label labelStop_SSA;
        private System.Windows.Forms.Label labelStart_SSA;
        private System.Windows.Forms.GroupBox groupBoxRes_SSA;
        private System.Windows.Forms.DataGridView dataGridViewRes_SSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.Button buttonHelp_SSA;
        private System.Windows.Forms.Button buttonRes_SSA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_SSA;
        private System.Windows.Forms.Label labelTask_SSA;
    }
}

