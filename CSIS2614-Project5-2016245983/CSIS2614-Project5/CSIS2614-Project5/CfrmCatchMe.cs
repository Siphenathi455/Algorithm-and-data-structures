//Nxele Siphenathi
//2016245983
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS2614_Project5
{
    public partial class CfrmCatchMe : Form
    {
        Timer tmrDraw = new Timer();
        CTarget target = new CTarget();
        CCatcher catcher = new CCatcher();
        CTrack track;
        public CfrmCatchMe()
        {
            
            InitializeComponent();
        }



        private void CfrmCatcher_Paint(object sender, PaintEventArgs e)
        {
            track = new CTrack(0,0,100,200);

            Graphics g = this.CreateGraphics();
          
            g.FillEllipse(new SolidBrush(Color.White), (this.Width/2)-300, 20, 600, 600);
            g.FillEllipse(new SolidBrush(this.BackColor), 213, 120, 400, 400);

        //  g.FillEllipse(new SolidBrush(Color.Black))
        }
    }
}
