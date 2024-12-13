namespace Tyuiu.SyrtsovaSA.Sprint6.Task7.V19
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_SSA = new Panel();
            groupBoxTask_SSA = new GroupBox();
            labelTask_SSA = new Label();
            labelInfo_SSA = new Label();
            buttonHelp_SSA = new Button();
            buttonSaveFile_SSA = new Button();
            buttonDone_SSA = new Button();
            buttonOpenFile_SSA = new Button();
            panelLeft_SSA = new Panel();
            groupBoxInPutData_SSA = new GroupBox();
            dataGridViewInPutData_SSA = new DataGridView();
            panelFill_SSA = new Panel();
            groupBoxOutPutData_SSA = new GroupBox();
            dataGridViewOutPutData_SSA = new DataGridView();
            splitterLeft_SSA = new Splitter();
            openFileDialogTask_SSA = new OpenFileDialog();
            toolTip_SSA = new ToolTip(components);
            saveFileDialogMatrix_SSA = new SaveFileDialog();
            panelTop_SSA.SuspendLayout();
            groupBoxTask_SSA.SuspendLayout();
            panelLeft_SSA.SuspendLayout();
            groupBoxInPutData_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutData_SSA).BeginInit();
            panelFill_SSA.SuspendLayout();
            groupBoxOutPutData_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPutData_SSA).BeginInit();
            SuspendLayout();
            // 
            // panelTop_SSA
            // 
            panelTop_SSA.Controls.Add(groupBoxTask_SSA);
            panelTop_SSA.Controls.Add(buttonHelp_SSA);
            panelTop_SSA.Controls.Add(buttonSaveFile_SSA);
            panelTop_SSA.Controls.Add(buttonDone_SSA);
            panelTop_SSA.Controls.Add(buttonOpenFile_SSA);
            panelTop_SSA.Dock = DockStyle.Top;
            panelTop_SSA.Location = new Point(0, 0);
            panelTop_SSA.Margin = new Padding(4, 5, 4, 5);
            panelTop_SSA.Name = "panelTop_SSA";
            panelTop_SSA.Size = new Size(1193, 192);
            panelTop_SSA.TabIndex = 0;
            // 
            // groupBoxTask_SSA
            // 
            groupBoxTask_SSA.Controls.Add(labelTask_SSA);
            groupBoxTask_SSA.Controls.Add(labelInfo_SSA);
            groupBoxTask_SSA.Dock = DockStyle.Bottom;
            groupBoxTask_SSA.Location = new Point(0, 101);
            groupBoxTask_SSA.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask_SSA.Name = "groupBoxTask_SSA";
            groupBoxTask_SSA.Padding = new Padding(4, 5, 4, 5);
            groupBoxTask_SSA.Size = new Size(1193, 91);
            groupBoxTask_SSA.TabIndex = 4;
            groupBoxTask_SSA.TabStop = false;
            groupBoxTask_SSA.Text = "Условие";
            // 
            // labelTask_SSA
            // 
            labelTask_SSA.AutoSize = true;
            labelTask_SSA.Location = new Point(9, 22);
            labelTask_SSA.Name = "labelTask_SSA";
            labelTask_SSA.Size = new Size(1047, 60);
            labelTask_SSA.TabIndex = 1;
            labelTask_SSA.Text = resources.GetString("labelTask_SSA.Text");
            // 
            // labelInfo_SSA
            // 
            labelInfo_SSA.AutoSize = true;
            labelInfo_SSA.Dock = DockStyle.Bottom;
            labelInfo_SSA.Location = new Point(4, 66);
            labelInfo_SSA.Margin = new Padding(4, 0, 4, 0);
            labelInfo_SSA.Name = "labelInfo_SSA";
            labelInfo_SSA.Size = new Size(0, 20);
            labelInfo_SSA.TabIndex = 0;
            // 
            // buttonHelp_SSA
            // 
            buttonHelp_SSA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SSA.Image = Properties.Resources.help;
            buttonHelp_SSA.Location = new Point(1089, 5);
            buttonHelp_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_SSA.Name = "buttonHelp_SSA";
            buttonHelp_SSA.Size = new Size(100, 88);
            buttonHelp_SSA.TabIndex = 3;
            toolTip_SSA.SetToolTip(buttonHelp_SSA, "Сведения о программе");
            buttonHelp_SSA.UseVisualStyleBackColor = true;
            buttonHelp_SSA.Click += buttonHelp_SSA_Click;
            buttonHelp_SSA.MouseEnter += buttonHelp_SSA_MouseEnter;
            // 
            // buttonSaveFile_SSA
            // 
            buttonSaveFile_SSA.Enabled = false;
            buttonSaveFile_SSA.Image = Properties.Resources.page_save;
            buttonSaveFile_SSA.Location = new Point(220, 5);
            buttonSaveFile_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonSaveFile_SSA.Name = "buttonSaveFile_SSA";
            buttonSaveFile_SSA.Size = new Size(100, 88);
            buttonSaveFile_SSA.TabIndex = 2;
            toolTip_SSA.SetToolTip(buttonSaveFile_SSA, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_SSA.UseVisualStyleBackColor = true;
            buttonSaveFile_SSA.Click += buttonSaveFile_SSA_Click;
            buttonSaveFile_SSA.MouseEnter += buttonSaveFile_SSA_MouseEnter;
            // 
            // buttonDone_SSA
            // 
            buttonDone_SSA.Enabled = false;
            buttonDone_SSA.Image = Properties.Resources.page_white_go;
            buttonDone_SSA.Location = new Point(112, 5);
            buttonDone_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonDone_SSA.Name = "buttonDone_SSA";
            buttonDone_SSA.Size = new Size(100, 88);
            buttonDone_SSA.TabIndex = 1;
            toolTip_SSA.SetToolTip(buttonDone_SSA, "Выполнить обработку данных");
            buttonDone_SSA.UseVisualStyleBackColor = true;
            buttonDone_SSA.Click += buttonDone_SSA_Click;
            buttonDone_SSA.MouseEnter += buttonDone_SSA_MouseEnter;
            // 
            // buttonOpenFile_SSA
            // 
            buttonOpenFile_SSA.Image = Properties.Resources.folder_page;
            buttonOpenFile_SSA.Location = new Point(4, 5);
            buttonOpenFile_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonOpenFile_SSA.Name = "buttonOpenFile_SSA";
            buttonOpenFile_SSA.Size = new Size(100, 88);
            buttonOpenFile_SSA.TabIndex = 0;
            toolTip_SSA.SetToolTip(buttonOpenFile_SSA, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_SSA.UseVisualStyleBackColor = true;
            buttonOpenFile_SSA.Click += buttonOpenFile_SSA_Click;
            buttonOpenFile_SSA.MouseEnter += buttonOpenFile_SSA_MouseEnter;
            // 
            // panelLeft_SSA
            // 
            panelLeft_SSA.Controls.Add(groupBoxInPutData_SSA);
            panelLeft_SSA.Dock = DockStyle.Left;
            panelLeft_SSA.Location = new Point(0, 192);
            panelLeft_SSA.Margin = new Padding(4, 5, 4, 5);
            panelLeft_SSA.Name = "panelLeft_SSA";
            panelLeft_SSA.Size = new Size(581, 533);
            panelLeft_SSA.TabIndex = 1;
            // 
            // groupBoxInPutData_SSA
            // 
            groupBoxInPutData_SSA.Controls.Add(dataGridViewInPutData_SSA);
            groupBoxInPutData_SSA.Dock = DockStyle.Fill;
            groupBoxInPutData_SSA.Location = new Point(0, 0);
            groupBoxInPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            groupBoxInPutData_SSA.Name = "groupBoxInPutData_SSA";
            groupBoxInPutData_SSA.Padding = new Padding(4, 5, 4, 5);
            groupBoxInPutData_SSA.Size = new Size(581, 533);
            groupBoxInPutData_SSA.TabIndex = 0;
            groupBoxInPutData_SSA.TabStop = false;
            groupBoxInPutData_SSA.Text = "Ввод:";
            // 
            // dataGridViewInPutData_SSA
            // 
            dataGridViewInPutData_SSA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewInPutData_SSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPutData_SSA.ColumnHeadersVisible = false;
            dataGridViewInPutData_SSA.Dock = DockStyle.Fill;
            dataGridViewInPutData_SSA.Location = new Point(4, 25);
            dataGridViewInPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            dataGridViewInPutData_SSA.Name = "dataGridViewInPutData_SSA";
            dataGridViewInPutData_SSA.ReadOnly = true;
            dataGridViewInPutData_SSA.RowHeadersVisible = false;
            dataGridViewInPutData_SSA.RowHeadersWidth = 51;
            dataGridViewInPutData_SSA.Size = new Size(573, 503);
            dataGridViewInPutData_SSA.TabIndex = 0;
            // 
            // panelFill_SSA
            // 
            panelFill_SSA.Controls.Add(groupBoxOutPutData_SSA);
            panelFill_SSA.Dock = DockStyle.Fill;
            panelFill_SSA.Location = new Point(581, 192);
            panelFill_SSA.Margin = new Padding(4, 5, 4, 5);
            panelFill_SSA.Name = "panelFill_SSA";
            panelFill_SSA.Size = new Size(612, 533);
            panelFill_SSA.TabIndex = 2;
            // 
            // groupBoxOutPutData_SSA
            // 
            groupBoxOutPutData_SSA.Controls.Add(dataGridViewOutPutData_SSA);
            groupBoxOutPutData_SSA.Dock = DockStyle.Fill;
            groupBoxOutPutData_SSA.Location = new Point(0, 0);
            groupBoxOutPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutPutData_SSA.Name = "groupBoxOutPutData_SSA";
            groupBoxOutPutData_SSA.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutPutData_SSA.Size = new Size(612, 533);
            groupBoxOutPutData_SSA.TabIndex = 0;
            groupBoxOutPutData_SSA.TabStop = false;
            groupBoxOutPutData_SSA.Text = "Вывод:";
            // 
            // dataGridViewOutPutData_SSA
            // 
            dataGridViewOutPutData_SSA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOutPutData_SSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPutData_SSA.ColumnHeadersVisible = false;
            dataGridViewOutPutData_SSA.Dock = DockStyle.Fill;
            dataGridViewOutPutData_SSA.Location = new Point(4, 25);
            dataGridViewOutPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOutPutData_SSA.Name = "dataGridViewOutPutData_SSA";
            dataGridViewOutPutData_SSA.ReadOnly = true;
            dataGridViewOutPutData_SSA.RowHeadersVisible = false;
            dataGridViewOutPutData_SSA.RowHeadersWidth = 51;
            dataGridViewOutPutData_SSA.Size = new Size(604, 503);
            dataGridViewOutPutData_SSA.TabIndex = 0;
            // 
            // splitterLeft_SSA
            // 
            splitterLeft_SSA.Location = new Point(581, 192);
            splitterLeft_SSA.Margin = new Padding(4, 5, 4, 5);
            splitterLeft_SSA.Name = "splitterLeft_SSA";
            splitterLeft_SSA.Size = new Size(4, 533);
            splitterLeft_SSA.TabIndex = 3;
            splitterLeft_SSA.TabStop = false;
            // 
            // openFileDialogTask_SSA
            // 
            openFileDialogTask_SSA.FileName = "openFileDialog1";
            // 
            // toolTip_SSA
            // 
            toolTip_SSA.IsBalloon = true;
            toolTip_SSA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SSA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 725);
            Controls.Add(splitterLeft_SSA);
            Controls.Add(panelFill_SSA);
            Controls.Add(panelLeft_SSA);
            Controls.Add(panelTop_SSA);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 19 | Сырцова С.А.";
            panelTop_SSA.ResumeLayout(false);
            groupBoxTask_SSA.ResumeLayout(false);
            groupBoxTask_SSA.PerformLayout();
            panelLeft_SSA.ResumeLayout(false);
            groupBoxInPutData_SSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutData_SSA).EndInit();
            panelFill_SSA.ResumeLayout(false);
            groupBoxOutPutData_SSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPutData_SSA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SSA;
        private System.Windows.Forms.Button buttonHelp_SSA;
        private System.Windows.Forms.Button buttonSaveFile_SSA;
        private System.Windows.Forms.Button buttonDone_SSA;
        private System.Windows.Forms.Button buttonOpenFile_SSA;
        private System.Windows.Forms.Panel panelLeft_SSA;
        private System.Windows.Forms.Panel panelFill_SSA;
        private System.Windows.Forms.Splitter splitterLeft_SSA;
        private System.Windows.Forms.GroupBox groupBoxTask_SSA;
        private System.Windows.Forms.Label labelInfo_SSA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SSA;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_SSA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SSA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_SSA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SSA;
        private System.Windows.Forms.ToolTip toolTip_SSA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SSA;
        private Label labelTask_SSA;
    }
}
