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

namespace MobChecker
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            ofdUpload.ShowDialog();
            int t = 0;
            /*foreach (string file in ofdUpload.FileNames)
            {
                MessageBox.Show(file);
                //Filename Contains full path to the file with the extension
            }*/

            //Can't do this cause the multiselect is on... but for test
            using(var reader = new StreamReader(ofdUpload.FileName))
            {
                List<string> Values = new List<string>();
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (t == 0)
                        MessageBox.Show(values[2]);
                    t++;
                }
            }

        }
    }
}
