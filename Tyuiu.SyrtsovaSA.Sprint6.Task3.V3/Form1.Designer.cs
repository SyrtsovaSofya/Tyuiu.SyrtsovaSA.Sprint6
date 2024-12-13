namespace Tyuiu.SyrtsovaSA.Sprint6.Task3.V3
{
    partial class FormMain_SSA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SSA));
            groupBoxTask_SSA = new GroupBox();
            dataGridViewMatrix_SSA = new DataGridView();
            labelInfo_SSA = new Label();
            groupBoxOutPutData_SSA = new GroupBox();
            dataGridViewMatrix2_SSA = new DataGridView();
            buttonDone_SSA = new Button();
            buttonHelp_SSA = new Button();
            groupBoxTask_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SSA).BeginInit();
            groupBoxOutPutData_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix2_SSA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_SSA
            // 
            groupBoxTask_SSA.Controls.Add(dataGridViewMatrix_SSA);
            groupBoxTask_SSA.Controls.Add(labelInfo_SSA);
            groupBoxTask_SSA.Location = new Point(17, 20);
            groupBoxTask_SSA.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask_SSA.Name = "groupBoxTask_SSA";
            groupBoxTask_SSA.Padding = new Padding(4, 5, 4, 5);
            groupBoxTask_SSA.Size = new Size(689, 392);
            groupBoxTask_SSA.TabIndex = 0;
            groupBoxTask_SSA.TabStop = false;
            groupBoxTask_SSA.Text = "Условие";
            // 
            // dataGridViewMatrix_SSA
            // 
            dataGridViewMatrix_SSA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMatrix_SSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_SSA.ColumnHeadersVisible = false;
            dataGridViewMatrix_SSA.Location = new Point(355, 31);
            dataGridViewMatrix_SSA.Margin = new Padding(4, 5, 4, 5);
            dataGridViewMatrix_SSA.Name = "dataGridViewMatrix_SSA";
            dataGridViewMatrix_SSA.ReadOnly = true;
            dataGridViewMatrix_SSA.RowHeadersVisible = false;
            dataGridViewMatrix_SSA.RowHeadersWidth = 60;
            dataGridViewMatrix_SSA.Size = new Size(320, 343);
            dataGridViewMatrix_SSA.TabIndex = 1;
            // 
            // labelInfo_SSA
            // 
            labelInfo_SSA.AutoSize = true;
            labelInfo_SSA.Location = new Point(9, 31);
            labelInfo_SSA.Margin = new Padding(4, 0, 4, 0);
            labelInfo_SSA.Name = "labelInfo_SSA";
            labelInfo_SSA.Size = new Size(241, 160);
            labelInfo_SSA.TabIndex = 0;
            labelInfo_SSA.Text = resources.GetString("labelInfo_SSA.Text");
            // 
            // groupBoxOutPutData_SSA
            // 
            groupBoxOutPutData_SSA.Controls.Add(dataGridViewMatrix2_SSA);
            groupBoxOutPutData_SSA.Location = new Point(715, 20);
            groupBoxOutPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutPutData_SSA.Name = "groupBoxOutPutData_SSA";
            groupBoxOutPutData_SSA.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutPutData_SSA.Size = new Size(336, 392);
            groupBoxOutPutData_SSA.TabIndex = 1;
            groupBoxOutPutData_SSA.TabStop = false;
            groupBoxOutPutData_SSA.Text = "Вывод данных";
            // 
            // dataGridViewMatrix2_SSA
            // 
            dataGridViewMatrix2_SSA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMatrix2_SSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix2_SSA.ColumnHeadersVisible = false;
            dataGridViewMatrix2_SSA.Location = new Point(8, 29);
            dataGridViewMatrix2_SSA.Margin = new Padding(4, 5, 4, 5);
            dataGridViewMatrix2_SSA.Name = "dataGridViewMatrix2_SSA";
            dataGridViewMatrix2_SSA.ReadOnly = true;
            dataGridViewMatrix2_SSA.RowHeadersVisible = false;
            dataGridViewMatrix2_SSA.RowHeadersWidth = 60;
            dataGridViewMatrix2_SSA.Size = new Size(320, 343);
            dataGridViewMatrix2_SSA.TabIndex = 0;
            // 
            // buttonDone_SSA
            // 
            buttonDone_SSA.Location = new Point(912, 412);
            buttonDone_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonDone_SSA.Name = "buttonDone_SSA";
            buttonDone_SSA.Size = new Size(139, 69);
            buttonDone_SSA.TabIndex = 2;
            buttonDone_SSA.Text = "Выполнить";
            buttonDone_SSA.UseVisualStyleBackColor = true;
            buttonDone_SSA.Click += buttonDone_Click;
            // 
            // buttonHelp_SSA
            // 
            buttonHelp_SSA.Location = new Point(826, 412);
            buttonHelp_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_SSA.Name = "buttonHelp_SSA";
            buttonHelp_SSA.Size = new Size(78, 69);
            buttonHelp_SSA.TabIndex = 3;
            buttonHelp_SSA.Text = "?";
            buttonHelp_SSA.UseVisualStyleBackColor = true;
            buttonHelp_SSA.Click += buttonHelp_Click;
            // 
            // FormMain_SSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 495);
            Controls.Add(buttonHelp_SSA);
            Controls.Add(buttonDone_SSA);
            Controls.Add(groupBoxOutPutData_SSA);
            Controls.Add(groupBoxTask_SSA);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain_SSA";
            Text = "Спринт 6 | Таск 3 | Вариант 3 |  Сырцова С.А.";
            Load += FormMain_Load;
            groupBoxTask_SSA.ResumeLayout(false);
            groupBoxTask_SSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SSA).EndInit();
            groupBoxOutPutData_SSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix2_SSA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SSA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SSA;
        private System.Windows.Forms.Label labelInfo_SSA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SSA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix2_SSA;
        private System.Windows.Forms.Button buttonDone_SSA;
        private System.Windows.Forms.Button buttonHelp_SSA;
    }
}
