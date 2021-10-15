using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            ofdUpload.ShowDialog();

            if (ofdUpload.FileNames.Count() == 0)
                return;
            else if (ofdUpload.FileNames.Count() == 1)
            {
                if (!Manager.UploadFile(ofdUpload.FileNames))
                    MessageBox.Show("Файл не были загружены!");
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
    }
}
