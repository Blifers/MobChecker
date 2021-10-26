using System;
using System.Linq;
using System.Windows.Forms;
using MobChecker.Classes;

namespace MobChecker
{
    public partial class MainMenu : Form
    {
        private Manager Manager = new Manager();

        public MainMenu()
        {
            InitializeComponent();
            Manager.UploadTwinBots();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            ofdUpload.ShowDialog();

            if (ofdUpload.FileNames.Count() == 0)
                return;
            else if (ofdUpload.FileNames.Count() == 1)
            {
                if (!Manager.UploadFile(ofdUpload.FileNames))
                    MessageBox.Show("Файл не был загружен!");
            }
            else if (ofdUpload.FileNames.Count() > 1)
            {
                if (!Manager.UploadFile(ofdUpload.FileNames))
                    MessageBox.Show("Файлы не были загружены!");
            }
        }

        private void btnGetFailures_Click(object sender, EventArgs e)
        {
            rtbFailures.Text = Manager.GetAllFailures();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Manager.FormExcel();
        }
    }
}
