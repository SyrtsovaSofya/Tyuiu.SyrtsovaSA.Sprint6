using Tyuiu.SyrtsovaSA.Sprint6.Task4.V25.Properties;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task4.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SSA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SSA = new System.Windows.Forms.PictureBox();
            this.labelInfo_SSA = new System.Windows.Forms.Label();
            this.groupBoxInPutData_SSA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_SSA = new System.Windows.Forms.Label();
            this.labelStartStep_SSA = new System.Windows.Forms.Label();
            this.textBoxStopStep_SSA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SSA = new System.Windows.Forms.TextBox();
            this.buttonDone_SSA = new System.Windows.Forms.Button();
            this.buttonSave_SSA = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_SSA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SSA = new System.Windows.Forms.TextBox();
            this.chartFunction_SSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_SSA = new System.Windows.Forms.Button();
            this.labelGrafik_SSA = new System.Windows.Forms.Label();
            this.groupBoxTask_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SSA)).BeginInit();
            this.groupBoxInPutData_SSA.SuspendLayout();
            this.groupBoxOutPutData_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SSA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SSA
            // 
            this.groupBoxTask_SSA.Controls.Add(this.pictureBoxFormula_SSA);
            this.groupBoxTask_SSA.Controls.Add(this.labelInfo_SSA);
            this.groupBoxTask_SSA.Location = new System.Drawing.Point(16, 15);
            this.groupBoxTask_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_SSA.Name = "groupBoxTask_SSA";
            this.groupBoxTask_SSA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_SSA.Size = new System.Drawing.Size(595, 160);
            this.groupBoxTask_SSA.TabIndex = 0;
            this.groupBoxTask_SSA.TabStop = false;
            this.groupBoxTask_SSA.Text = "Условие";
            // 
            // pictureBoxFormula_SSA
            // 
            this.pictureBoxFormula_SSA.Image = global::Tyuiu.SyrtsovaSA.Sprint6.Task4.V25.Properties.Resources._1;
            this.pictureBoxFormula_SSA.Location = new System.Drawing.Point(13, 90);
            this.pictureBoxFormula_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFormula_SSA.Name = "pictureBoxFormula_SSA";
            this.pictureBoxFormula_SSA.Size = new System.Drawing.Size(504, 49);
            this.pictureBoxFormula_SSA.TabIndex = 1;
            this.pictureBoxFormula_SSA.TabStop = false;
            // 
            // labelInfo_SSA
            // 
            this.labelInfo_SSA.AutoSize = true;
            this.labelInfo_SSA.Location = new System.Drawing.Point(9, 25);
            this.labelInfo_SSA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_SSA.Name = "labelInfo_SSA";
            this.labelInfo_SSA.Size = new System.Drawing.Size(508, 48);
            this.labelInfo_SSA.TabIndex = 0;
            this.labelInfo_SSA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V25.txt по на" +
    "жатию кнопки.\r\n";
            // 
            // groupBoxInPutData_SSA
            // 
            this.groupBoxInPutData_SSA.Controls.Add(this.labelStopStep_SSA);
            this.groupBoxInPutData_SSA.Controls.Add(this.labelStartStep_SSA);
            this.groupBoxInPutData_SSA.Controls.Add(this.textBoxStopStep_SSA);
            this.groupBoxInPutData_SSA.Controls.Add(this.textBoxStartStep_SSA);
            this.groupBoxInPutData_SSA.Location = new System.Drawing.Point(619, 15);
            this.groupBoxInPutData_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInPutData_SSA.Name = "groupBoxInPutData_SSA";
            this.groupBoxInPutData_SSA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInPutData_SSA.Size = new System.Drawing.Size(311, 75);
            this.groupBoxInPutData_SSA.TabIndex = 1;
            this.groupBoxInPutData_SSA.TabStop = false;
            this.groupBoxInPutData_SSA.Text = "Ввод данных";
            // 
            // labelStopStep_SSA
            // 
            this.labelStopStep_SSA.AutoSize = true;
            this.labelStopStep_SSA.Location = new System.Drawing.Point(148, 20);
            this.labelStopStep_SSA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStopStep_SSA.Name = "labelStopStep_SSA";
            this.labelStopStep_SSA.Size = new System.Drawing.Size(84, 16);
            this.labelStopStep_SSA.TabIndex = 3;
            this.labelStopStep_SSA.Text = "Конец шага:";
            // 
            // labelStartStep_SSA
            // 
            this.labelStartStep_SSA.AutoSize = true;
            this.labelStartStep_SSA.Location = new System.Drawing.Point(8, 20);
            this.labelStartStep_SSA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartStep_SSA.Name = "labelStartStep_SSA";
            this.labelStartStep_SSA.Size = new System.Drawing.Size(83, 16);
            this.labelStartStep_SSA.TabIndex = 2;
            this.labelStartStep_SSA.Text = "Старт шага:";
            // 
            // textBoxStopStep_SSA
            // 
            this.textBoxStopStep_SSA.Location = new System.Drawing.Point(152, 41);
            this.textBoxStopStep_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStopStep_SSA.Name = "textBoxStopStep_SSA";
            this.textBoxStopStep_SSA.Size = new System.Drawing.Size(132, 22);
            this.textBoxStopStep_SSA.TabIndex = 1;
            this.textBoxStopStep_SSA.Text = "5";
            // 
            // textBoxStartStep_SSA
            // 
            this.textBoxStartStep_SSA.Location = new System.Drawing.Point(12, 39);
            this.textBoxStartStep_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartStep_SSA.Name = "textBoxStartStep_SSA";
            this.textBoxStartStep_SSA.Size = new System.Drawing.Size(132, 22);
            this.textBoxStartStep_SSA.TabIndex = 0;
            this.textBoxStartStep_SSA.Text = "-5";
            // 
            // buttonDone_SSA
            // 
            this.buttonDone_SSA.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonDone_SSA.Location = new System.Drawing.Point(945, 17);
            this.buttonDone_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDone_SSA.Name = "buttonDone_SSA";
            this.buttonDone_SSA.Size = new System.Drawing.Size(115, 71);
            this.buttonDone_SSA.TabIndex = 2;
            this.buttonDone_SSA.Text = "Выполнить";
            this.buttonDone_SSA.UseVisualStyleBackColor = false;
            this.buttonDone_SSA.Click += new System.EventHandler(this.buttonDone_SSA_Click);
            // 
            // buttonSave_SSA
            // 
            this.buttonSave_SSA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSave_SSA.Location = new System.Drawing.Point(1068, 18);
            this.buttonSave_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave_SSA.Name = "buttonSave_SSA";
            this.buttonSave_SSA.Size = new System.Drawing.Size(115, 71);
            this.buttonSave_SSA.TabIndex = 3;
            this.buttonSave_SSA.Text = "Сохранить";
            this.buttonSave_SSA.UseVisualStyleBackColor = false;
            this.buttonSave_SSA.Click += new System.EventHandler(this.buttonSave_SSA_Click);
            // 
            // groupBoxOutPutData_SSA
            // 
            this.groupBoxOutPutData_SSA.Controls.Add(this.textBoxResult_SSA);
            this.groupBoxOutPutData_SSA.Location = new System.Drawing.Point(16, 183);
            this.groupBoxOutPutData_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOutPutData_SSA.Name = "groupBoxOutPutData_SSA";
            this.groupBoxOutPutData_SSA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOutPutData_SSA.Size = new System.Drawing.Size(359, 408);
            this.groupBoxOutPutData_SSA.TabIndex = 5;
            this.groupBoxOutPutData_SSA.TabStop = false;
            this.groupBoxOutPutData_SSA.Text = "Вывод";
            // 
            // textBoxResult_SSA
            // 
            this.textBoxResult_SSA.Location = new System.Drawing.Point(9, 25);
            this.textBoxResult_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult_SSA.Multiline = true;
            this.textBoxResult_SSA.Name = "textBoxResult_SSA";
            this.textBoxResult_SSA.ReadOnly = true;
            this.textBoxResult_SSA.Size = new System.Drawing.Size(329, 370);
            this.textBoxResult_SSA.TabIndex = 0;
            // 
            // chartFunction_SSA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SSA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SSA.Legends.Add(legend1);
            this.chartFunction_SSA.Location = new System.Drawing.Point(383, 183);
            this.chartFunction_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.chartFunction_SSA.Name = "chartFunction_SSA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SSA.Series.Add(series1);
            this.chartFunction_SSA.Size = new System.Drawing.Size(923, 408);
            this.chartFunction_SSA.TabIndex = 6;
            this.chartFunction_SSA.Text = "chart1";
            // 
            // buttonHelp_SSA
            // 
            this.buttonHelp_SSA.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHelp_SSA.Location = new System.Drawing.Point(1191, 19);
            this.buttonHelp_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp_SSA.Name = "buttonHelp_SSA";
            this.buttonHelp_SSA.Size = new System.Drawing.Size(115, 70);
            this.buttonHelp_SSA.TabIndex = 7;
            this.buttonHelp_SSA.Text = "Справка";
            this.buttonHelp_SSA.UseVisualStyleBackColor = false;
            this.buttonHelp_SSA.Click += new System.EventHandler(this.buttonHelp_SSA_Click);
            // 
            // labelGrafik_SSA
            // 
            this.labelGrafik_SSA.AutoSize = true;
            this.labelGrafik_SSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrafik_SSA.ForeColor = System.Drawing.Color.Blue;
            this.labelGrafik_SSA.Location = new System.Drawing.Point(767, 159);
            this.labelGrafik_SSA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrafik_SSA.Name = "labelGrafik_SSA";
            this.labelGrafik_SSA.Size = new System.Drawing.Size(166, 20);
            this.labelGrafik_SSA.TabIndex = 8;
            this.labelGrafik_SSA.Text = "График функции";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 604);
            this.Controls.Add(this.labelGrafik_SSA);
            this.Controls.Add(this.buttonHelp_SSA);
            this.Controls.Add(this.chartFunction_SSA);
            this.Controls.Add(this.groupBoxOutPutData_SSA);
            this.Controls.Add(this.buttonSave_SSA);
            this.Controls.Add(this.buttonDone_SSA);
            this.Controls.Add(this.groupBoxInPutData_SSA);
            this.Controls.Add(this.groupBoxTask_SSA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1261, 641);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 25 | Сырцова С.А.";
            this.groupBoxTask_SSA.ResumeLayout(false);
            this.groupBoxTask_SSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SSA)).EndInit();
            this.groupBoxInPutData_SSA.ResumeLayout(false);
            this.groupBoxInPutData_SSA.PerformLayout();
            this.groupBoxOutPutData_SSA.ResumeLayout(false);
            this.groupBoxOutPutData_SSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SSA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SSA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SSA;
        private System.Windows.Forms.Label labelInfo_SSA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SSA;
        private System.Windows.Forms.Label labelStopStep_SSA;
        private System.Windows.Forms.Label labelStartStep_SSA;
        private System.Windows.Forms.TextBox textBoxStopStep_SSA;
        private System.Windows.Forms.TextBox textBoxStartStep_SSA;
        private System.Windows.Forms.Button buttonDone_SSA;
        private System.Windows.Forms.Button buttonSave_SSA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SSA;
        private System.Windows.Forms.TextBox textBoxResult_SSA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SSA;
        private System.Windows.Forms.Button buttonHelp_SSA;
        private System.Windows.Forms.Label labelGrafik_SSA;
    }
}

