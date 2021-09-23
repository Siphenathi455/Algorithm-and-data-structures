using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;


namespace CSIS2614_Project1
{
    public partial class frmRestrictionLevels : Form
    {
        List<CRestrictions> RestrictionList = new List<CRestrictions>();
        string Filename = "Restictions.txt";
        public frmRestrictionLevels()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteLevel_Click(object sender, EventArgs e)
        {
            if (lstbxLevels.SelectedIndex >= 0)
            {
                if (CfrmWaterManagement.Delete(lstbxLevels.Text))
                {

                    try
                    {
                        RestrictionList.Clear();
                        string sRead;
                        string[] Reading;
                        StreamReader Strm = new StreamReader(Filename);
                        while (!Strm.EndOfStream)
                        {
                            sRead = Strm.ReadLine();
                            Reading = sRead.Split('\t');
                            if (Reading[0] != lstbxLevels.SelectedItem.ToString())
                            {
                                RestrictionList.Add(new CRestrictions(Reading[0], Reading[1], int.Parse(Reading[2])));
                            }

                        }
                        Strm.Close();
                       lstbxLevels.Items.Clear();
                        StreamWriter f = new StreamWriter(Filename, false);
                        for (int i = 0; i < RestrictionList.Count; i++)
                        {

                            f.WriteLine(RestrictionList[i].Levels + '\t' + RestrictionList[i].Restrictions + '\t' + RestrictionList[i].Restrictions.ToString());
                            lstbxLevels.Items.Add(RestrictionList[i].Levels);
                            
                        }
                        f.Close();
                        txtRestrictions.Clear();
                    }
                    catch { }
                }
            }
            else
                MessageBox.Show("Select a level to delete.");
        }

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
          
            int x = (Screen.PrimaryScreen.Bounds.Width - 360) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - 150) / 2;

            string sLevel = Interaction.InputBox("New level:", "Enter new level", "0", x , y);
            if (sLevel != "")
            {

                RestrictionList.Add(new CRestrictions(sLevel, txtRestrictions.Text, (int)nudMaxLitres.Value));

                StreamWriter f = new StreamWriter(Filename, true);
                f.WriteLine(sLevel + '\t' + txtRestrictions.Text + '\t' + nudMaxLitres.Value.ToString());
                f.Close();

                lstbxLevels.Items.Add(sLevel);
            }
        }

        private void lstbxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRestrictions.Clear();
            string sLine;
            string[] Level;
            StreamReader Strm = new StreamReader(Filename);
            while (!Strm.EndOfStream)
            {
                sLine = Strm.ReadLine();
                Level = sLine.Split('\t');
                if ( Level[0] == lstbxLevels.SelectedItem.ToString())
                {
                    txtRestrictions.Text = Level[1];
                }
                

            }
            Strm.Close();
        }

        private void frmRestrictionLevels_Load(object sender, EventArgs e)
        {
            try
            {
                txtRestrictions.Clear();
                string sLine;
                string[] Level;
                StreamReader Strm = new StreamReader(Filename);
                while (!Strm.EndOfStream)
                {
                    sLine = Strm.ReadLine();
                    Level = sLine.Split('\t');
                    lstbxLevels.Items.Add(Level[0]);

                }
                Strm.Close();
            }
            catch { };
        }
    }
 }

