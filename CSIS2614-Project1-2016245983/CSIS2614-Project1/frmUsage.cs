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
    public partial class frmUsage : Form
    {
       
        public frmUsage()
        {
            
            InitializeComponent();
        }
      

        private void btnOk_Click(object sender, EventArgs e)
        {
            Usage();
            Month();
            this.DialogResult = DialogResult.OK;

        }
       public string Month()
        {
            return cmbMonths.Text;
        }
       public int Usage()
        {
            return (int)nudUsage.Value;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsage_Load(object sender, EventArgs e)
        {
            cmbMonths.Items.Add("January");
            cmbMonths.Items.Add("February");
            cmbMonths.Items.Add("March");
            cmbMonths.Items.Add("April");
            cmbMonths.Items.Add("May");
            cmbMonths.Items.Add("June");
            cmbMonths.Items.Add("June");
            cmbMonths.Items.Add("August");
            cmbMonths.Items.Add("September");
            cmbMonths.Items.Add("October");
            cmbMonths.Items.Add("November");
            cmbMonths.Items.Add("December");
        }

        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
