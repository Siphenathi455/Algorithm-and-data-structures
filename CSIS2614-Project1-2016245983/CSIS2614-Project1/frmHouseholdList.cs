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
    public partial class frmHouseholdList : Form
    {
        string Filename = "Household.txt";
         List<CHousehold> HouseholdList = new List<CHousehold>();
        string sMonth;
        int iUsage;

        public frmHouseholdList()
        {
            InitializeComponent();
        }

        private void btnUsage_Click(object sender, EventArgs e)
        {
            frmUsage Usage = new frmUsage();
            Usage.ShowDialog();
            if (Usage.DialogResult == DialogResult.OK)
            {
                sMonth = Usage.Month();
                iUsage = Usage.Usage();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lstbxHouseholds.SelectedIndex >= 0)
            {
                if (CfrmWaterManagement.Delete("Household"))
                {

                    try
                    {
                        HouseholdList.Clear();
                        string sRead;
                        string[] Reading;
                        StreamReader Strm = new StreamReader(Filename);
                        while (!Strm.EndOfStream)
                        {
                            sRead = Strm.ReadLine();
                            Reading = sRead.Split('*');
                            if (Reading[1] + "  " + Reading[0] != lstbxHouseholds.SelectedItem.ToString())
                            {
                                HouseholdList.Add(new CHousehold(Reading[0], int.Parse(Reading[1]), int.Parse(Reading[2]),Reading[3]));
                            }

                        }
                        Strm.Close();
                        lstbxHouseholds.Items.Clear();
                        StreamWriter f = new StreamWriter(Filename, false);
                        for (int i = 0; i < HouseholdList.Count; i++)
                        {

                            f.WriteLine(HouseholdList[i].Adress + '*' + HouseholdList[i].People + '*' + HouseholdList[i].Usage.ToString() +"*"+ HouseholdList[i].Month);
                            lstbxHouseholds.Items.Add(HouseholdList[i].People +"  "+ HouseholdList[i].Adress);

                        }
                    f.Close();
                }
                    catch { }
            }
            }
            else
                MessageBox.Show("Select a household to delete.");
        }

        private void btnAddHouseHold_Click(object sender, EventArgs e)
        {
           
            HouseholdList.Add(new CHousehold(txtAdress.Text, iUsage, (int)nudNumOfPeople.Value, sMonth));

            StreamWriter f = new StreamWriter(Filename, true);
            f.WriteLine(txtAdress.Text + "*" + iUsage.ToString() + "*"+ nudNumOfPeople.Value.ToString() +"*"+ sMonth);
            f.Close();


            lstbxHouseholds.Items.Add(nudNumOfPeople.Value.ToString()+"  "+ txtAdress.Text); 
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
