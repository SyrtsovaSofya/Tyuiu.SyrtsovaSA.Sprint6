using Tyuiu.SyrtsovaSA.Sprint6.Task7.V19.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task7.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SSA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SSA.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|(*.*)";
        }
        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, colums];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_SSA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SSA.ShowDialog();
            openFilePath = openFileDialogTask_SSA.FileName;
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInPutData_SSA.ColumnCount = colums;
            dataGridViewInPutData_SSA.RowCount = rows;
            dataGridViewOutPutData_SSA.ColumnCount = colums;
            dataGridViewOutPutData_SSA.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInPutData_SSA.Columns[i].Width = 25;
                dataGridViewOutPutData_SSA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPutData_SSA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SSA.Enabled = true;


        }

        private void buttonDone_SSA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutPutData_SSA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_SSA.Enabled = true;
        }

        private void buttonSaveFile_SSA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SSA.FileName = "OutPutFileTask7V5.csv";
            saveFileDialogMatrix_SSA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SSA.ShowDialog();
            string path = saveFileDialogMatrix_SSA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutPutData_SSA.RowCount;
            int columns = dataGridViewOutPutData_SSA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPutData_SSA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPutData_SSA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_SSA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SSA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SSA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SSA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SSA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_SSA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SSA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SSA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SSA.ToolTipTitle = "Справка";
        }
    }
}
