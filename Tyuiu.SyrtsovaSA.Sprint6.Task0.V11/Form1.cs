using Tyuiu.SyrtsovaSA.Sprint6.Task0.V11.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task0.V11
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SSA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SSA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_SSA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInput_SSA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != ',' && e.KeyChar != 8)
                e.Handled = true;
        }

        private void buttonHelp_SSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-24-1 Сырцова Софья Алексеевна", "Сообщение");
        }
    }
}
