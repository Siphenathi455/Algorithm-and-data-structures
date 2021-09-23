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
    public partial class CfrmAddmonth : Form
    {
        string sMax;
        string Filename = "Restictions.txt";
        String[] Months = {"January", "February" ,"March","April","May","June","July","August","Öctober","November","December"};
        public CfrmAddmonth()
        {
            InitializeComponent();
        }

        private void CfrmAddmonth_Load(object sender, EventArgs e)
        {
            cmbMonth.DataSource = Months;
            try
            {

                string sLine;
                string[] Level;
                StreamReader Strm = new StreamReader(Filename);
                while (!Strm.EndOfStream)
                {
                    sLine = Strm.ReadLine();
                    Level = sLine.Split('\t');
                    cmbLevel.Items.Add(Level[0]);

                }
                Strm.Close();

            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
        public string Month()
        {
           return cmbMonth.Text;
        }
        public string Level()
        {
            return cmbLevel.Text;
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string sLine;
                string[] Level;
                StreamReader Strm = new StreamReader(Filename);
                while (!Strm.EndOfStream)
                {
                    sLine = Strm.ReadLine();
                    Level = sLine.Split('\t');
                    if(Level[0] == cmbLevel.Text)
                    {
                        sMax = Level[2];
                    }

                }
                Strm.Close();

            }
            catch { }
        }
        public string Max()
        {
            return sMax;
        }
    }
}
