//Nxele Siphenathi
//2016245983
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614_Project5
{
    public delegate void delOnScoreChanged();
    class CCatcher : ICatcher
    {
        public event delOnScoreChanged ScoreChanged;
        Color ccolour;
        public Color colour { get; }
        public int Hits { get; }
        public int Radius { get; }


        public void Reset()
        {
          
        }

        public void SetPosition(CTrack track, CTarget target, int X, int Y)
        {
            ccolour = Color.Blue;

         
        }
        private double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        } //Distance
    }
}
