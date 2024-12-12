namespace Tyuiu.SyrtsovaSA.Sprint6.Task0.V11
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask_SSA = new GroupBox();
            pictureBoxTask_SSA = new PictureBox();
            labelTask_SSA = new Label();
            groupBoxInput_SSA = new GroupBox();
            textBoxInput_SSA = new TextBox();
            labelInput_SSA = new Label();
            groupBoxResult_SSA = new GroupBox();
            textBoxResult_SSA = new TextBox();
            labelResult_SSA = new Label();
            buttonDone_SSA = new Button();
            buttonHelp_SSA = new Button();
            groupBoxTask_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SSA).BeginInit();
            groupBoxInput_SSA.SuspendLayout();
            groupBoxResult_SSA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SSA
            // 
            groupBoxTask_SSA.Controls.Add(pictureBoxTask_SSA);
            groupBoxTask_SSA.Controls.Add(labelTask_SSA);
            groupBoxTask_SSA.Location = new Point(14, 16);
            groupBoxTask_SSA.Name = "groupBoxTask_SSA";
            groupBoxTask_SSA.Size = new Size(765, 218);
            groupBoxTask_SSA.TabIndex = 0;
            groupBoxTask_SSA.TabStop = false;
            groupBoxTask_SSA.Text = "Условие";
            // 
            // pictureBoxTask_SSA
            // 
            pictureBoxTask_SSA.Image = Properties.Resources._1;
            pictureBoxTask_SSA.Location = new Point(439, 27);
            pictureBoxTask_SSA.Name = "pictureBoxTask_SSA";
            pictureBoxTask_SSA.Size = new Size(320, 46);
            pictureBoxTask_SSA.TabIndex = 1;
            pictureBoxTask_SSA.TabStop = false;
            // 
            // labelTask_SSA
            // 
            labelTask_SSA.AutoSize = true;
            labelTask_SSA.Location = new Point(13, 27);
            labelTask_SSA.Name = "labelTask_SSA";
            labelTask_SSA.Size = new Size(257, 20);
            labelTask_SSA.TabIndex = 0;
            labelTask_SSA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_SSA
            // 
            groupBoxInput_SSA.Controls.Add(textBoxInput_SSA);
            groupBoxInput_SSA.Controls.Add(labelInput_SSA);
            groupBoxInput_SSA.Location = new Point(14, 240);
            groupBoxInput_SSA.Name = "groupBoxInput_SSA";
            groupBoxInput_SSA.Size = new Size(403, 141);
            groupBoxInput_SSA.TabIndex = 1;
            groupBoxInput_SSA.TabStop = false;
            groupBoxInput_SSA.Text = "Ввод данных:";
            // 
            // textBoxInput_SSA
            // 
            textBoxInput_SSA.Location = new Point(14, 56);
            textBoxInput_SSA.Name = "textBoxInput_SSA";
            textBoxInput_SSA.Size = new Size(125, 27);
            textBoxInput_SSA.TabIndex = 1;
            textBoxInput_SSA.KeyPress += textBoxInput_SSA_KeyPress;
            // 
            // labelInput_SSA
            // 
            labelInput_SSA.AutoSize = true;
            labelInput_SSA.Location = new Point(11, 29);
            labelInput_SSA.Name = "labelInput_SSA";
            labelInput_SSA.Size = new Size(114, 20);
            labelInput_SSA.TabIndex = 0;
            labelInput_SSA.Text = "Переменная Х:";
            // 
            // groupBoxResult_SSA
            // 
            groupBoxResult_SSA.Controls.Add(textBoxResult_SSA);
            groupBoxResult_SSA.Controls.Add(labelResult_SSA);
            groupBoxResult_SSA.Location = new Point(423, 240);
            groupBoxResult_SSA.Name = "groupBoxResult_SSA";
            groupBoxResult_SSA.Size = new Size(356, 141);
            groupBoxResult_SSA.TabIndex = 2;
            groupBoxResult_SSA.TabStop = false;
            groupBoxResult_SSA.Text = "Вывод данных";
            // 
            // textBoxResult_SSA
            // 
            textBoxResult_SSA.Location = new Point(15, 53);
            textBoxResult_SSA.Name = "textBoxResult_SSA";
            textBoxResult_SSA.ReadOnly = true;
            textBoxResult_SSA.Size = new Size(142, 27);
            textBoxResult_SSA.TabIndex = 1;
            // 
            // labelResult_SSA
            // 
            labelResult_SSA.AutoSize = true;
            labelResult_SSA.Location = new Point(11, 30);
            labelResult_SSA.Name = "labelResult_SSA";
            labelResult_SSA.Size = new Size(78, 20);
            labelResult_SSA.TabIndex = 0;
            labelResult_SSA.Text = "Результат:";
            // 
            // buttonDone_SSA
            // 
            buttonDone_SSA.Location = new Point(595, 387);
            buttonDone_SSA.Name = "buttonDone_SSA";
            buttonDone_SSA.Size = new Size(184, 51);
            buttonDone_SSA.TabIndex = 3;
            buttonDone_SSA.Text = "Выполнить";
            buttonDone_SSA.UseVisualStyleBackColor = true;
            buttonDone_SSA.Click += buttonDone_SSA_Click;
            // 
            // buttonHelp_SSA
            // 
            buttonHelp_SSA.Location = new Point(525, 387);
            buttonHelp_SSA.Name = "buttonHelp_SSA";
            buttonHelp_SSA.Size = new Size(55, 51);
            buttonHelp_SSA.TabIndex = 4;
            buttonHelp_SSA.Text = "?";
            buttonHelp_SSA.UseVisualStyleBackColor = true;
            buttonHelp_SSA.Click += buttonHelp_SSA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_SSA);
            Controls.Add(buttonDone_SSA);
            Controls.Add(groupBoxResult_SSA);
            Controls.Add(groupBoxInput_SSA);
            Controls.Add(groupBoxTask_SSA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 11 | Сырцова С.А.";
            groupBoxTask_SSA.ResumeLayout(false);
            groupBoxTask_SSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SSA).EndInit();
            groupBoxInput_SSA.ResumeLayout(false);
            groupBoxInput_SSA.PerformLayout();
            groupBoxResult_SSA.ResumeLayout(false);
            groupBoxResult_SSA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SSA;
        private PictureBox pictureBoxTask_SSA;
        private Label labelTask_SSA;
        private GroupBox groupBoxInput_SSA;
        private TextBox textBoxInput_SSA;
        private Label labelInput_SSA;
        private GroupBox groupBoxResult_SSA;
        private TextBox textBoxResult_SSA;
        private Label labelResult_SSA;
        private Button buttonDone_SSA;
        private Button buttonHelp_SSA;
    }
}
