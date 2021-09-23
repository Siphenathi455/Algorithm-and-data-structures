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
    public partial class frmLevelsPerMonth : Form
    {
       string Filename = "LPerMonth.txt";
        List<CLevelsPerMonth> LPerMom = new List<CLevelsPerMonth>();
        public frmLevelsPerMonth()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteMon_Click(object sender, EventArgs e)
        {
            if (lstbxLevelsPerMon.SelectedIndex >= 0)
            {
               if(CfrmWaterManagement.Delete(lblMonth.Text))
                {

                    try
                    {
                        LPerMom.Clear();
                        string sRead;
                        string[] Reading;
                        StreamReader Strm = new StreamReader(Filename);
                        while (!Strm.EndOfStream)
                        {
                            sRead = Strm.ReadLine();
                            Reading =  sRead.Split('\t');
                            if (Reading[0] + '\t' + '\t' + Reading[1] + '\t' + '\t' + Reading[2] != lstbxLevelsPerMon.SelectedItem.ToString())
                            {
                                LPerMom.Add(new CLevelsPerMonth(Reading[0], Reading[1], Reading[2]));
                            }

                        }
                        Strm.Close();
                    lstbxLevelsPerMon.Items.Clear();
                    StreamWriter f = new StreamWriter(Filename,false);
                        for (int i = 0; i < LPerMom.Count; i++)
                        {

                            f.WriteLine(LPerMom[i].Month + '\t' + LPerMom[i].Level + '\t' + LPerMom[i].LimitPP);
                        lstbxLevelsPerMon.Items.Add(LPerMom[i].Month + '\t' + '\t' + LPerMom[i].Level + '\t' + '\t' + LPerMom[i].LimitPP);

                    }
                    f.Close();
                }
                    catch { }
            }
            }
            else
                MessageBox.Show("Select a month to delete.");
        }

        private void btnAddMon_Click(object sender, EventArgs e)
        {
            CfrmAddmonth frmMonth = new CfrmAddmonth();
            frmMonth.ShowDialog();

            if(frmMonth.DialogResult == DialogResult.OK)
            {
                LPerMom.Add(new CLevelsPerMonth(frmMonth.Month(), frmMonth.Level(),frmMonth.Max()));
                StreamWriter f = new StreamWriter(Filename, true);
                f.WriteLine(frmMonth.Month() + '\t' + frmMonth.Level() + '\t' + frmMonth.Max());
                f.Close();

                lstbxLevelsPerMon.Items.Add(frmMonth.Month() + '\t'+'\t' + frmMonth.Level() + '\t' + '\t' + frmMonth.Max());
            }

        }

        private void frmLevelsPerMonth_Load(object sender, EventArgs e)
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
                    lstbxLevelsPerMon.Items.Add(Level[0] + '\t' + '\t' + Level[1] + '\t' + '\t' + Level[2]);

                }
                Strm.Close();
            }
            catch { }
        }

    }
}
