
using Tyuiu.SyrtsovaSA.Sprint6.Task6.V2.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_SSA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SSA.ShowDialog();
            openFilePath = openFileDialogTask_SSA.FileName;
            textBoxInPutData_SSA.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_SSA.Text = groupBoxInPutData_SSA.Text + " " + openFileDialogTask_SSA.FileName;
            buttonDone_SSA.Enabled = true;

        }

        private void buttonDone_SSA_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_SSA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SSA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
