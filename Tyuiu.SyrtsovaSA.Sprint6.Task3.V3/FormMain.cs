using Tyuiu.SyrtsovaSA.Sprint6.Task3.V3.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task3.V3
{
    public partial class FormMain_SSA : Form
    {
        public FormMain_SSA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {
        {-18, 21, 10, -2, 12 },
        {-18, -10, 33, -20, 32},
        {14, -15, -14, 12, -18},
        {-19, 5, -3, 28, -17},
        {-14, -9, 23, -13, 11}};

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-24-1 Сырцова Софья Алексеевна", "Сообщение");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);
            UpdateDataGridView(dataGridViewMatrix2_SSA);
        }

        private void UpdateDataGridView(DataGridView dataGridView)
        {
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);
            dataGridView.ColumnCount = columns;
            dataGridView.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridView.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewMatrix_SSA.ColumnCount = columns;
            dataGridViewMatrix_SSA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SSA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewMatrix_SSA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
