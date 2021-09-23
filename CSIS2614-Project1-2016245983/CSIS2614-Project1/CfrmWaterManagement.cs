using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS2614_Project1
{
    public partial class CfrmWaterManagement : Form
    {
        public CfrmWaterManagement()
        {
            InitializeComponent();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHouseholdList frmList = new frmHouseholdList();
            frmList.ShowDialog();
        }

        private void usageReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsageReport frmReport = new frmUsageReport();
            frmReport.ShowDialog();
        }

        private void levelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestrictionLevels frmRestrictions = new frmRestrictionLevels();
            frmRestrictions.ShowDialog();
        }

        private void levelsPerMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLevelsPerMonth LevelsPM = new frmLevelsPerMonth();
            LevelsPM.ShowDialog();
        }

        public static bool Delete(string sName)
        {

            if (MessageBox.Show("Are you sure you want to delete this " + sName.ToLower() + " ?", "Delete " + sName.ToLower(),
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        private void kjlkHkHJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.ShowDialog();
        }
    }
}
