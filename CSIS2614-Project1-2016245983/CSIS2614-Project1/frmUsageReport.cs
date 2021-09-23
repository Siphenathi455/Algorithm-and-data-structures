using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSIS2614_Project1
{
    public partial class frmUsageReport : Form
    {
        string Filename2 = "LPerMonth.txt";
        string Filename = "Household.txt";
        public frmUsageReport()
        {
            InitializeComponent();
        }

        private void frmUsageReport_Load(object sender, EventArgs e)
        {
            cmbMonths.Items.Add("January");
            cmbMonths.Items.Add("February");
            cmbMonths.Items.Add("March");
            cmbMonths.Items.Add("April");
            cmbMonths.Items.Add("May");
            cmbMonths.Items.Add("June");
            cmbMonths.Items.Add("July");
            cmbMonths.Items.Add("August");
            cmbMonths.Items.Add("September");
            cmbMonths.Items.Add("October");
            cmbMonths.Items.Add("November");
            cmbMonths.Items.Add("December");
        }

        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxUsage.Items.Clear();
            string sLine;
            string[] Report;
            StreamReader Strm = new StreamReader(Filename);
            while (!Strm.EndOfStream)
            {
                sLine = Strm.ReadLine();
                Report = sLine.Split('*');
                if (Report[3] == cmbMonths.Text)
                {
                    lstbxUsage.Items.Add(Report[2] +" "+ Report[0] + " " + Report[1] );
                }

            }
            Strm.Close();

        }

        private void chkExceededLimits_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExceededLimits.Checked)
            {
                int n = 0;
                string sLine2;
                string[] Level;
                StreamReader Strm2 = new StreamReader(Filename2);
                while (!Strm2.EndOfStream)
                {
                    sLine2 = Strm2.ReadLine();
                    Level = sLine2.Split('\t');
                    if (Level[0] == cmbMonths.Text)
                    {
                        n = int.Parse(Level[1]);
                    }

                }
                Strm2.Close();



                lstbxUsage.Items.Clear();
                string sLine;
                string[] Report;
                StreamReader Strm = new StreamReader(Filename);
                while (!Strm.EndOfStream)
                {
                    sLine = Strm.ReadLine();
                    Report = sLine.Split('*');
                    if (Report[3] == cmbMonths.Text && int.Parse(Report[1]) > n)
                    {
                        lstbxUsage.Items.Add(Report[2] + " " + Report[0] + " " + Report[1]);
                    }

                }
                Strm.Close();
            }
            else
            {
                lstbxUsage.Items.Clear();
                string sLine;
                string[] Report;
                StreamReader Strm = new StreamReader(Filename);
                while (!Strm.EndOfStream)
                {
                    sLine = Strm.ReadLine();
                    Report = sLine.Split('*');
                    if (Report[3] == cmbMonths.Text)
                    {
                        lstbxUsage.Items.Add(Report[2] + " " + Report[0] + " " + Report[1]);
                    }

                }
                Strm.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
