namespace Tyuiu.SyrtsovaSA.Sprint6.Task1.V18
{
    partial class Form1
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
            labelTask_SSA = new Label();
            groupBoxResult_SSA = new GroupBox();
            textBoxResult_SSA = new TextBox();
            labelResult_SSA = new Label();
            groupBoxInput_SSA = new GroupBox();
            textBoxStopStep_SSA = new TextBox();
            textBoxStartStep_SSA = new TextBox();
            labelStopStep_SSA = new Label();
            labelStartStep_SSA = new Label();
            buttonHelp_SSA = new Button();
            buttonDone_SSA = new Button();
            groupBoxTask_SSA.SuspendLayout();
            groupBoxResult_SSA.SuspendLayout();
            groupBoxInput_SSA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SSA
            // 
            groupBoxTask_SSA.Controls.Add(labelTask_SSA);
            groupBoxTask_SSA.Location = new Point(12, 12);
            groupBoxTask_SSA.Name = "groupBoxTask_SSA";
            groupBoxTask_SSA.Size = new Size(610, 327);
            groupBoxTask_SSA.TabIndex = 0;
            groupBoxTask_SSA.TabStop = false;
            groupBoxTask_SSA.Text = "Условие";
            // 
            // labelTask_SSA
            // 
            labelTask_SSA.AutoSize = true;
            labelTask_SSA.Location = new Point(7, 27);
            labelTask_SSA.Name = "labelTask_SSA";
            labelTask_SSA.Size = new Size(415, 40);
            labelTask_SSA.TabIndex = 0;
            labelTask_SSA.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult_SSA
            // 
            groupBoxResult_SSA.Controls.Add(textBoxResult_SSA);
            groupBoxResult_SSA.Controls.Add(labelResult_SSA);
            groupBoxResult_SSA.Location = new Point(628, 12);
            groupBoxResult_SSA.Name = "groupBoxResult_SSA";
            groupBoxResult_SSA.Size = new Size(268, 426);
            groupBoxResult_SSA.TabIndex = 1;
            groupBoxResult_SSA.TabStop = false;
            groupBoxResult_SSA.Text = "Вывод данных";
            // 
            // textBoxResult_SSA
            // 
            textBoxResult_SSA.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SSA.Location = new Point(12, 47);
            textBoxResult_SSA.Multiline = true;
            textBoxResult_SSA.Name = "textBoxResult_SSA";
            textBoxResult_SSA.ReadOnly = true;
            textBoxResult_SSA.Size = new Size(250, 373);
            textBoxResult_SSA.TabIndex = 1;
            // 
            // labelResult_SSA
            // 
            labelResult_SSA.AutoSize = true;
            labelResult_SSA.Location = new Point(9, 21);
            labelResult_SSA.Name = "labelResult_SSA";
            labelResult_SSA.Size = new Size(78, 20);
            labelResult_SSA.TabIndex = 0;
            labelResult_SSA.Text = "Результат:";
            // 
            // groupBoxInput_SSA
            // 
            groupBoxInput_SSA.Controls.Add(textBoxStopStep_SSA);
            groupBoxInput_SSA.Controls.Add(textBoxStartStep_SSA);
            groupBoxInput_SSA.Controls.Add(labelStopStep_SSA);
            groupBoxInput_SSA.Controls.Add(labelStartStep_SSA);
            groupBoxInput_SSA.Location = new Point(12, 345);
            groupBoxInput_SSA.Name = "groupBoxInput_SSA";
            groupBoxInput_SSA.Size = new Size(288, 93);
            groupBoxInput_SSA.TabIndex = 2;
            groupBoxInput_SSA.TabStop = false;
            groupBoxInput_SSA.Text = "Ввод данных";
            // 
            // textBoxStopStep_SSA
            // 
            textBoxStopStep_SSA.Location = new Point(147, 50);
            textBoxStopStep_SSA.Name = "textBoxStopStep_SSA";
            textBoxStopStep_SSA.Size = new Size(125, 27);
            textBoxStopStep_SSA.TabIndex = 3;
            // 
            // textBoxStartStep_SSA
            // 
            textBoxStartStep_SSA.Location = new Point(13, 50);
            textBoxStartStep_SSA.Name = "textBoxStartStep_SSA";
            textBoxStartStep_SSA.Size = new Size(125, 27);
            textBoxStartStep_SSA.TabIndex = 2;
            // 
            // labelStopStep_SSA
            // 
            labelStopStep_SSA.AutoSize = true;
            labelStopStep_SSA.Location = new Point(147, 23);
            labelStopStep_SSA.Name = "labelStopStep_SSA";
            labelStopStep_SSA.Size = new Size(94, 20);
            labelStopStep_SSA.TabIndex = 1;
            labelStopStep_SSA.Text = "Конец шага:";
            // 
            // labelStartStep_SSA
            // 
            labelStartStep_SSA.AutoSize = true;
            labelStartStep_SSA.Location = new Point(9, 23);
            labelStartStep_SSA.Name = "labelStartStep_SSA";
            labelStartStep_SSA.Size = new Size(88, 20);
            labelStartStep_SSA.TabIndex = 0;
            labelStartStep_SSA.Text = "Старт шага:";
            // 
            // buttonHelp_SSA
            // 
            buttonHelp_SSA.BackColor = Color.SkyBlue;
            buttonHelp_SSA.Location = new Point(307, 355);
            buttonHelp_SSA.Name = "buttonHelp_SSA";
            buttonHelp_SSA.Size = new Size(102, 83);
            buttonHelp_SSA.TabIndex = 3;
            buttonHelp_SSA.Text = "Справка";
            buttonHelp_SSA.UseVisualStyleBackColor = false;
            buttonHelp_SSA.Click += buttonHelp_SSA_Click;
            // 
            // buttonDone_SSA
            // 
            buttonDone_SSA.BackColor = Color.SpringGreen;
            buttonDone_SSA.Location = new Point(416, 356);
            buttonDone_SSA.Name = "buttonDone_SSA";
            buttonDone_SSA.Size = new Size(206, 82);
            buttonDone_SSA.TabIndex = 4;
            buttonDone_SSA.Text = "Выполнить";
            buttonDone_SSA.UseVisualStyleBackColor = false;
            buttonDone_SSA.Click += buttonDone_SSA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(buttonDone_SSA);
            Controls.Add(buttonHelp_SSA);
            Controls.Add(groupBoxInput_SSA);
            Controls.Add(groupBoxResult_SSA);
            Controls.Add(groupBoxTask_SSA);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 18 | Сырцова С.А.";
            groupBoxTask_SSA.ResumeLayout(false);
            groupBoxTask_SSA.PerformLayout();
            groupBoxResult_SSA.ResumeLayout(false);
            groupBoxResult_SSA.PerformLayout();
            groupBoxInput_SSA.ResumeLayout(false);
            groupBoxInput_SSA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SSA;
        private GroupBox groupBoxResult_SSA;
        private GroupBox groupBoxInput_SSA;
        private Label labelTask_SSA;
        private TextBox textBoxResult_SSA;
        private Label labelResult_SSA;
        private TextBox textBoxStopStep_SSA;
        private TextBox textBoxStartStep_SSA;
        private Label labelStopStep_SSA;
        private Label labelStartStep_SSA;
        private Button buttonHelp_SSA;
        private Button buttonDone_SSA;
    }
}
