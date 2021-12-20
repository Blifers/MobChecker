using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobChecker.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            FirstLevel.Value = Properties.Settings.Default.FirstLvlPoints;
            SecondLevel.Value = Properties.Settings.Default.SecondLvlPoints;
            ThirdLevel.Value = Properties.Settings.Default.ThirdLvlPoints;
            FourthLevel.Value = Properties.Settings.Default.FourthLvlPoints;
            FifthLevel.Value = Properties.Settings.Default.FifthLvlPoints;
            TotalPoints.Value = Properties.Settings.Default.NeededPoints;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FirstLvlPoints = Convert.ToInt32(FirstLevel.Value);
            Properties.Settings.Default.SecondLvlPoints = Convert.ToInt32(SecondLevel.Value);
            Properties.Settings.Default.ThirdLvlPoints = Convert.ToInt32(ThirdLevel.Value);
            Properties.Settings.Default.FourthLvlPoints = Convert.ToInt32(FourthLevel.Value);
            Properties.Settings.Default.FifthLvlPoints = Convert.ToInt32(FifthLevel.Value);
            Properties.Settings.Default.NeededPoints = Convert.ToInt32(TotalPoints.Value);

            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
