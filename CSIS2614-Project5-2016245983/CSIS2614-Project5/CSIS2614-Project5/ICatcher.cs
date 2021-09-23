//Nxele Siphenathi
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614_Project5
{
    interface ICatcher
    {
        Color colour { get; }
        int Radius { get; }
        int Hits { get; }
        void SetPosition(CTrack track, CTarget target, int X, int Y);
        void Reset();
    }
}
