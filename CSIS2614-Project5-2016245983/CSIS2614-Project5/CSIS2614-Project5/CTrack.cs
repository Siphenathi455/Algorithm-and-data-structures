//Nxele Siphenathi
//2016245983
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614_Project5
{
    class CTrack
    {
        public CTrack( int _CenterX, int _CenterY, int _radius, int _width)
        {
            CenterX = _CenterX;
            CenterY = _CenterY;
            Radius = _radius;
            width = _width;
        }
        public int CenterX { get; }
        public int CenterY { get; }
        public int Radius { get; }
        private int width { get; }
    }
}
