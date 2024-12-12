using Tyuiu.SyrtsovaSA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task1.V18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_SSA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SSA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SSA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_SSA.Text = "";
                textBoxResult_SSA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_SSA.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_SSA.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}     |   {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_SSA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_SSA.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-24-1 Сырцова Софья Алексеевна", "Сообщение");
        }
    }
}

