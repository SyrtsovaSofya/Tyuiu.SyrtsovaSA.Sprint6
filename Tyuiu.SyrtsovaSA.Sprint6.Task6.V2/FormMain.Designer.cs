namespace Tyuiu.SyrtsovaSA.Sprint6.Task6.V2
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
            buttonHelp_SSA = new Button();
            buttonDone_SSA = new Button();
            groupBoxTask_SSA = new GroupBox();
            labelTask_SSA = new Label();
            labelInfo_SSA = new Label();
            buttonOpenFile_SSA = new Button();
            panelLeft_SSA = new Panel();
            groupBoxInPutData_SSA = new GroupBox();
            textBoxInPutData_SSA = new TextBox();
            splitterLeft_SSA = new Splitter();
            panelFill_SSA = new Panel();
            groupBoxOutPutData_SSA = new GroupBox();
            textBoxOutPutData_SSA = new TextBox();
            openFileDialogTask_SSA = new OpenFileDialog();
            toolTip_SSA = new ToolTip(components);
            panelTop_SSA.SuspendLayout();
            groupBoxTask_SSA.SuspendLayout();
            panelLeft_SSA.SuspendLayout();
            groupBoxInPutData_SSA.SuspendLayout();
            panelFill_SSA.SuspendLayout();
            groupBoxOutPutData_SSA.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_SSA
            // 
            panelTop_SSA.BackColor = Color.White;
            panelTop_SSA.Controls.Add(buttonHelp_SSA);
            panelTop_SSA.Controls.Add(buttonDone_SSA);
            panelTop_SSA.Controls.Add(groupBoxTask_SSA);
            panelTop_SSA.Controls.Add(buttonOpenFile_SSA);
            panelTop_SSA.Dock = DockStyle.Top;
            panelTop_SSA.Location = new Point(0, 0);
            panelTop_SSA.Margin = new Padding(4, 5, 4, 5);
            panelTop_SSA.Name = "panelTop_SSA";
            panelTop_SSA.Size = new Size(845, 205);
            panelTop_SSA.TabIndex = 0;
            // 
            // buttonHelp_SSA
            // 
            buttonHelp_SSA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SSA.Image = Properties.Resources.help;
            buttonHelp_SSA.Location = new Point(735, 6);
            buttonHelp_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_SSA.Name = "buttonHelp_SSA";
            buttonHelp_SSA.Size = new Size(100, 86);
            buttonHelp_SSA.TabIndex = 3;
            toolTip_SSA.SetToolTip(buttonHelp_SSA, "Сведения о программе");
            buttonHelp_SSA.UseVisualStyleBackColor = true;
            buttonHelp_SSA.Click += buttonHelp_SSA_Click;
            // 
            // buttonDone_SSA
            // 
            buttonDone_SSA.Enabled = false;
            buttonDone_SSA.Image = Properties.Resources.page_go;
            buttonDone_SSA.Location = new Point(112, 6);
            buttonDone_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonDone_SSA.Name = "buttonDone_SSA";
            buttonDone_SSA.Size = new Size(100, 86);
            buttonDone_SSA.TabIndex = 2;
            toolTip_SSA.SetToolTip(buttonDone_SSA, "Выполнить\r\nВыполнить обработку данных");
            buttonDone_SSA.UseVisualStyleBackColor = true;
            buttonDone_SSA.Click += buttonDone_SSA_Click;
            // 
            // groupBoxTask_SSA
            // 
            groupBoxTask_SSA.BackColor = Color.White;
            groupBoxTask_SSA.Controls.Add(labelTask_SSA);
            groupBoxTask_SSA.Controls.Add(labelInfo_SSA);
            groupBoxTask_SSA.Dock = DockStyle.Bottom;
            groupBoxTask_SSA.Location = new Point(0, 111);
            groupBoxTask_SSA.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask_SSA.Name = "groupBoxTask_SSA";
            groupBoxTask_SSA.Padding = new Padding(4, 5, 4, 5);
            groupBoxTask_SSA.Size = new Size(845, 94);
            groupBoxTask_SSA.TabIndex = 1;
            groupBoxTask_SSA.TabStop = false;
            groupBoxTask_SSA.Text = "Условие";
            // 
            // labelTask_SSA
            // 
            labelTask_SSA.AutoSize = true;
            labelTask_SSA.Location = new Point(12, 25);
            labelTask_SSA.Name = "labelTask_SSA";
            labelTask_SSA.Size = new Size(645, 60);
            labelTask_SSA.TabIndex = 1;
            labelTask_SSA.Text = resources.GetString("labelTask_SSA.Text");
            // 
            // labelInfo_SSA
            // 
            labelInfo_SSA.AutoSize = true;
            labelInfo_SSA.Dock = DockStyle.Fill;
            labelInfo_SSA.Location = new Point(4, 25);
            labelInfo_SSA.Margin = new Padding(4, 0, 4, 0);
            labelInfo_SSA.Name = "labelInfo_SSA";
            labelInfo_SSA.Size = new Size(0, 20);
            labelInfo_SSA.TabIndex = 0;
            // 
            // buttonOpenFile_SSA
            // 
            buttonOpenFile_SSA.Image = Properties.Resources.folder_page;
            buttonOpenFile_SSA.Location = new Point(4, 5);
            buttonOpenFile_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonOpenFile_SSA.Name = "buttonOpenFile_SSA";
            buttonOpenFile_SSA.Size = new Size(100, 86);
            buttonOpenFile_SSA.TabIndex = 0;
            toolTip_SSA.SetToolTip(buttonOpenFile_SSA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_SSA.UseVisualStyleBackColor = true;
            buttonOpenFile_SSA.Click += buttonOpenFile_SSA_Click;
            // 
            // panelLeft_SSA
            // 
            panelLeft_SSA.Controls.Add(groupBoxInPutData_SSA);
            panelLeft_SSA.Dock = DockStyle.Left;
            panelLeft_SSA.Location = new Point(0, 205);
            panelLeft_SSA.Margin = new Padding(4, 5, 4, 5);
            panelLeft_SSA.Name = "panelLeft_SSA";
            panelLeft_SSA.Size = new Size(412, 347);
            panelLeft_SSA.TabIndex = 1;
            // 
            // groupBoxInPutData_SSA
            // 
            groupBoxInPutData_SSA.BackColor = Color.White;
            groupBoxInPutData_SSA.Controls.Add(textBoxInPutData_SSA);
            groupBoxInPutData_SSA.Dock = DockStyle.Fill;
            groupBoxInPutData_SSA.Location = new Point(0, 0);
            groupBoxInPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            groupBoxInPutData_SSA.Name = "groupBoxInPutData_SSA";
            groupBoxInPutData_SSA.Padding = new Padding(4, 5, 4, 5);
            groupBoxInPutData_SSA.Size = new Size(412, 347);
            groupBoxInPutData_SSA.TabIndex = 0;
            groupBoxInPutData_SSA.TabStop = false;
            groupBoxInPutData_SSA.Text = "Ввод:";
            // 
            // textBoxInPutData_SSA
            // 
            textBoxInPutData_SSA.BackColor = Color.White;
            textBoxInPutData_SSA.Dock = DockStyle.Bottom;
            textBoxInPutData_SSA.Location = new Point(4, 30);
            textBoxInPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            textBoxInPutData_SSA.Multiline = true;
            textBoxInPutData_SSA.Name = "textBoxInPutData_SSA";
            textBoxInPutData_SSA.ReadOnly = true;
            textBoxInPutData_SSA.Size = new Size(404, 312);
            textBoxInPutData_SSA.TabIndex = 1;
            // 
            // splitterLeft_SSA
            // 
            splitterLeft_SSA.Location = new Point(412, 205);
            splitterLeft_SSA.Margin = new Padding(4, 5, 4, 5);
            splitterLeft_SSA.Name = "splitterLeft_SSA";
            splitterLeft_SSA.Size = new Size(4, 347);
            splitterLeft_SSA.TabIndex = 2;
            splitterLeft_SSA.TabStop = false;
            // 
            // panelFill_SSA
            // 
            panelFill_SSA.BackColor = SystemColors.ActiveCaption;
            panelFill_SSA.Controls.Add(groupBoxOutPutData_SSA);
            panelFill_SSA.Dock = DockStyle.Fill;
            panelFill_SSA.Location = new Point(416, 205);
            panelFill_SSA.Margin = new Padding(4, 5, 4, 5);
            panelFill_SSA.Name = "panelFill_SSA";
            panelFill_SSA.Size = new Size(429, 347);
            panelFill_SSA.TabIndex = 3;
            // 
            // groupBoxOutPutData_SSA
            // 
            groupBoxOutPutData_SSA.BackColor = Color.White;
            groupBoxOutPutData_SSA.Controls.Add(textBoxOutPutData_SSA);
            groupBoxOutPutData_SSA.Dock = DockStyle.Fill;
            groupBoxOutPutData_SSA.Location = new Point(0, 0);
            groupBoxOutPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutPutData_SSA.Name = "groupBoxOutPutData_SSA";
            groupBoxOutPutData_SSA.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutPutData_SSA.Size = new Size(429, 347);
            groupBoxOutPutData_SSA.TabIndex = 0;
            groupBoxOutPutData_SSA.TabStop = false;
            groupBoxOutPutData_SSA.Text = "Вывод:";
            // 
            // textBoxOutPutData_SSA
            // 
            textBoxOutPutData_SSA.Dock = DockStyle.Fill;
            textBoxOutPutData_SSA.Location = new Point(4, 25);
            textBoxOutPutData_SSA.Margin = new Padding(4, 5, 4, 5);
            textBoxOutPutData_SSA.Multiline = true;
            textBoxOutPutData_SSA.Name = "textBoxOutPutData_SSA";
            textBoxOutPutData_SSA.Size = new Size(421, 317);
            textBoxOutPutData_SSA.TabIndex = 0;
            // 
            // openFileDialogTask_SSA
            // 
            openFileDialogTask_SSA.FileName = "openFileDialog1";
            // 
            // toolTip_SSA
            // 
            toolTip_SSA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SSA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 552);
            Controls.Add(panelFill_SSA);
            Controls.Add(splitterLeft_SSA);
            Controls.Add(panelLeft_SSA);
            Controls.Add(panelTop_SSA);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 2 | Сырцова С.А.";
            panelTop_SSA.ResumeLayout(false);
            groupBoxTask_SSA.ResumeLayout(false);
            groupBoxTask_SSA.PerformLayout();
            panelLeft_SSA.ResumeLayout(false);
            groupBoxInPutData_SSA.ResumeLayout(false);
            groupBoxInPutData_SSA.PerformLayout();
            panelFill_SSA.ResumeLayout(false);
            groupBoxOutPutData_SSA.ResumeLayout(false);
            groupBoxOutPutData_SSA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SSA;
        private System.Windows.Forms.Panel panelLeft_SSA;
        private System.Windows.Forms.Button buttonOpenFile_SSA;
        private System.Windows.Forms.GroupBox groupBoxTask_SSA;
        private System.Windows.Forms.Label labelInfo_SSA;
        private System.Windows.Forms.Button buttonHelp_SSA;
        private System.Windows.Forms.Button buttonDone_SSA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SSA;
        private System.Windows.Forms.Splitter splitterLeft_SSA;
        private System.Windows.Forms.Panel panelFill_SSA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SSA;
        private System.Windows.Forms.TextBox textBoxOutPutData_SSA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SSA;
        private System.Windows.Forms.ToolTip toolTip_SSA;
        private Label labelTask_SSA;
        private TextBox textBoxInPutData_SSA;
    }
}
