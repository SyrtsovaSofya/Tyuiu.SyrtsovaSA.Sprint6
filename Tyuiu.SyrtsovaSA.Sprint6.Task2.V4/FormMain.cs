using System;
using System.Windows.Forms;
using Tyuiu.SyrtsovaSA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task2.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonRes_SSA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxStart_SSA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SSA.Text);
                double[] array = ds.GetMassFunction(startStep, stopStep);
                chartRes_SSA.Titles.Add("График функции (5*x + 2.5)/(Math.Sin(x) + 2) + 2*x + 2;");

                chartRes_SSA.ChartAreas[0].AxisX.Title = "Ось X";
                chartRes_SSA.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    dataGridViewRes_SSA.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));
                    chartRes_SSA.Series[0].Points.AddXY(startStep, array[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_SSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-24-1 Сырцова Софья Алексеевна", "Сообщение");
        }
    }
}
