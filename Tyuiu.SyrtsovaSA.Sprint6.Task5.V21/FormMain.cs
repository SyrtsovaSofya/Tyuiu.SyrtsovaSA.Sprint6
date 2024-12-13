using System;
using System.Windows.Forms;
using Tyuiu.SyrtsovaSA.Sprint6.Task5.V21.Lib.Old;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint6\Tyuiu.SyrtsovaSA.Sprint6.Task5.V21\bin\Debug\InPutDataFileTask5V21.txt";
        private void buttonHelp_SSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-24-1 Сырцова Софья Алексеевна", "Сообщение");
        }

        private void buttonDone_SSA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SSA.ColumnCount = 2;
            dataGridViewResult_SSA.Columns[0].Width = 20;
            dataGridViewResult_SSA.Columns[1].Width = 50;
            this.chartDiag_SSA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SSA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDiag_SSA.Series[0].Points.Clear();
            double[] mas = new double[ds.len];
            mas = ds.LoadFromDataFile(path);
            for (int i = 0; i < mas.Length; i++)
            {
                dataGridViewResult_SSA.Rows.Add(Convert.ToString(i), Convert.ToString(mas[i]));
                chartDiag_SSA.Series[0].Points.AddXY(i, mas[i]);
            }
        }

        private void buttonOpenFile_SSA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
