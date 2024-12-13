using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.SyrtsovaSA.Sprint6.Task4.V25.Lib.Old;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task4.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_SSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-24-1 Сырцова Софья Алексеевна", "Сообщение");
        }

        private void buttonDone_SSA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SSA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SSA.Text);
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;
                chartFunction_SSA.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_SSA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_SSA.Text = "";
                chartFunction_SSA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    chartFunction_SSA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_SSA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_SSA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V25.txt";
                File.WriteAllText(path, textBoxResult_SSA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
