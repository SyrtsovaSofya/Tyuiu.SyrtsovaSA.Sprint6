using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task5.V21
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
            this.panelTop_SSA = new System.Windows.Forms.Panel();
            this.buttonHelp_SSA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SSA = new System.Windows.Forms.Button();
            this.buttonDone_SSA = new System.Windows.Forms.Button();
            this.groupBoxTask_SSA = new System.Windows.Forms.GroupBox();
            this.labelInfo_SSA = new System.Windows.Forms.Label();
            this.panelFill_SSA = new System.Windows.Forms.Panel();
            this.chartDiag_SSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPutData_SSA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SSA = new System.Windows.Forms.DataGridView();
            this.panelLeft_SSA = new System.Windows.Forms.Panel();
            this.panelTop_SSA.SuspendLayout();
            this.groupBoxTask_SSA.SuspendLayout();
            this.panelFill_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SSA)).BeginInit();
            this.groupBoxOutPutData_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SSA)).BeginInit();
            this.panelLeft_SSA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_SSA
            // 
            this.panelTop_SSA.BackColor = System.Drawing.Color.White;
            this.panelTop_SSA.Controls.Add(this.buttonHelp_SSA);
            this.panelTop_SSA.Controls.Add(this.buttonOpenFile_SSA);
            this.panelTop_SSA.Controls.Add(this.buttonDone_SSA);
            this.panelTop_SSA.Controls.Add(this.groupBoxTask_SSA);
            this.panelTop_SSA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SSA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop_SSA.Name = "panelTop_SSA";
            this.panelTop_SSA.Size = new System.Drawing.Size(970, 98);
            this.panelTop_SSA.TabIndex = 0;
            // 
            // buttonHelp_SSA
            // 
            this.buttonHelp_SSA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SSA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SSA.Location = new System.Drawing.Point(847, 15);
            this.buttonHelp_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp_SSA.Name = "buttonHelp_SSA";
            this.buttonHelp_SSA.Size = new System.Drawing.Size(100, 76);
            this.buttonHelp_SSA.TabIndex = 3;
            this.buttonHelp_SSA.Text = "Справка";
            this.buttonHelp_SSA.UseVisualStyleBackColor = false;
            this.buttonHelp_SSA.Click += new System.EventHandler(this.buttonHelp_SSA_Click);
            // 
            // buttonOpenFile_SSA
            // 
            this.buttonOpenFile_SSA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_SSA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_SSA.Location = new System.Drawing.Point(739, 15);
            this.buttonOpenFile_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFile_SSA.Name = "buttonOpenFile_SSA";
            this.buttonOpenFile_SSA.Size = new System.Drawing.Size(100, 76);
            this.buttonOpenFile_SSA.TabIndex = 2;
            this.buttonOpenFile_SSA.Text = "Открыть файл";
            this.buttonOpenFile_SSA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SSA.Click += new System.EventHandler(this.buttonOpenFile_SSA_Click);
            // 
            // buttonDone_SSA
            // 
            this.buttonDone_SSA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_SSA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SSA.Location = new System.Drawing.Point(631, 15);
            this.buttonDone_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDone_SSA.Name = "buttonDone_SSA";
            this.buttonDone_SSA.Size = new System.Drawing.Size(100, 76);
            this.buttonDone_SSA.TabIndex = 1;
            this.buttonDone_SSA.Text = "Выполнить";
            this.buttonDone_SSA.UseVisualStyleBackColor = false;
            this.buttonDone_SSA.Click += new System.EventHandler(this.buttonDone_SSA_Click);
            // 
            // groupBoxTask_SSA
            // 
            this.groupBoxTask_SSA.Controls.Add(this.labelInfo_SSA);
            this.groupBoxTask_SSA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_SSA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_SSA.Name = "groupBoxTask_SSA";
            this.groupBoxTask_SSA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_SSA.Size = new System.Drawing.Size(623, 98);
            this.groupBoxTask_SSA.TabIndex = 0;
            this.groupBoxTask_SSA.TabStop = false;
            this.groupBoxTask_SSA.Text = "Условие";
            // 
            // labelInfo_SSA
            // 
            this.labelInfo_SSA.AutoSize = true;
            this.labelInfo_SSA.Location = new System.Drawing.Point(9, 25);
            this.labelInfo_SSA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_SSA.Name = "labelInfo_SSA";
            this.labelInfo_SSA.Size = new System.Drawing.Size(488, 32);
            this.labelInfo_SSA.TabIndex = 0;
            this.labelInfo_SSA.Text = "Прочитать данные из файла InPutFileTask5V18.txt. Вывести в dataGridView.\r\n Вывест" +
    "и все числа кратные 3.  Построить диаграмму по этим значениям.";
            // 
            // panelFill_SSA
            // 
            this.panelFill_SSA.BackColor = System.Drawing.Color.Gold;
            this.panelFill_SSA.Controls.Add(this.chartDiag_SSA);
            this.panelFill_SSA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SSA.Location = new System.Drawing.Point(236, 98);
            this.panelFill_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.panelFill_SSA.Name = "panelFill_SSA";
            this.panelFill_SSA.Size = new System.Drawing.Size(734, 430);
            this.panelFill_SSA.TabIndex = 1;
            // 
            // chartDiag_SSA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiag_SSA.ChartAreas.Add(chartArea1);
            this.chartDiag_SSA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiag_SSA.Legends.Add(legend1);
            this.chartDiag_SSA.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.chartDiag_SSA.Name = "chartDiag_SSA";
            this.chartDiag_SSA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_SSA.Series.Add(series1);
            this.chartDiag_SSA.Size = new System.Drawing.Size(734, 430);
            this.chartDiag_SSA.TabIndex = 0;
            this.chartDiag_SSA.Text = "chart1";
            // 
            // groupBoxOutPutData_SSA
            // 
            this.groupBoxOutPutData_SSA.BackColor = System.Drawing.Color.White;
            this.groupBoxOutPutData_SSA.Controls.Add(this.dataGridViewResult_SSA);
            this.groupBoxOutPutData_SSA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutPutData_SSA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOutPutData_SSA.Name = "groupBoxOutPutData_SSA";
            this.groupBoxOutPutData_SSA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOutPutData_SSA.Size = new System.Drawing.Size(231, 430);
            this.groupBoxOutPutData_SSA.TabIndex = 0;
            this.groupBoxOutPutData_SSA.TabStop = false;
            this.groupBoxOutPutData_SSA.Text = "Вывод данных";
            // 
            // dataGridViewResult_SSA
            // 
            this.dataGridViewResult_SSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SSA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SSA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewResult_SSA.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewResult_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewResult_SSA.Name = "dataGridViewResult_SSA";
            this.dataGridViewResult_SSA.RowHeadersVisible = false;
            this.dataGridViewResult_SSA.RowHeadersWidth = 51;
            this.dataGridViewResult_SSA.Size = new System.Drawing.Size(219, 407);
            this.dataGridViewResult_SSA.TabIndex = 0;
            // 
            // panelLeft_SSA
            // 
            this.panelLeft_SSA.BackColor = System.Drawing.Color.White;
            this.panelLeft_SSA.Controls.Add(this.groupBoxOutPutData_SSA);
            this.panelLeft_SSA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SSA.Location = new System.Drawing.Point(0, 98);
            this.panelLeft_SSA.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft_SSA.Name = "panelLeft_SSA";
            this.panelLeft_SSA.Size = new System.Drawing.Size(236, 430);
            this.panelLeft_SSA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 528);
            this.Controls.Add(this.panelFill_SSA);
            this.Controls.Add(this.panelLeft_SSA);
            this.Controls.Add(this.panelTop_SSA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 21 | Сырцова С.А. ";
            this.panelTop_SSA.ResumeLayout(false);
            this.groupBoxTask_SSA.ResumeLayout(false);
            this.groupBoxTask_SSA.PerformLayout();
            this.panelFill_SSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SSA)).EndInit();
            this.groupBoxOutPutData_SSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SSA)).EndInit();
            this.panelLeft_SSA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SSA;
        private System.Windows.Forms.GroupBox groupBoxTask_SSA;
        private System.Windows.Forms.Panel panelFill_SSA;
        private System.Windows.Forms.Button buttonHelp_SSA;
        private System.Windows.Forms.Button buttonOpenFile_SSA;
        private System.Windows.Forms.Button buttonDone_SSA;
        private System.Windows.Forms.Label labelInfo_SSA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SSA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SSA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SSA;
        private System.Windows.Forms.Panel panelLeft_SSA;
    }
}

