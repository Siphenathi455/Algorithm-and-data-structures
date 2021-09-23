//Nxele Siphenathi
//2016245983
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614_Project5
{
    public delegate void delOnSpeedChanged();
    public delegate void delOnRotationsChanged();
    class CTarget
    {
       
        public event delOnSpeedChanged SpeedChanged;
        public event delOnRotationsChanged RotationsChanged;
        private int iSPeed;
        private int iPositionX;
        private int iPositionY;
        int iAngle;



        public int PositionX { get { return iPositionX; } }
        public int PositionY { get { return iPositionY; } }
        public double Rotations { get; }
        public int Angle { get { return iAngle; } }
        public int Speed
        {
            get { return iSPeed; }
            set
            {
                iSPeed = value;
                if (SpeedChanged != null)
                    SpeedChanged();
            }
        }

        public void SetAngle(CTrack track, int angle)
        {
            iAngle = angle;
            double radians = Angle * Math.PI / 180;
            iPositionX = (int)(track.CenterX + track.Radius * Math.Cos(radians));
            iPositionY = (int)(track.CenterY + track.Radius * Math.Sin(radians));
            if (RotationsChanged != null)
                RotationsChanged();
        }
    }
}
