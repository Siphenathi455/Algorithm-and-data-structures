using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614_Project1
{
    class CRestrictions
    {
        public CRestrictions(string _Levels, string _Restrictions, int _Limitpp)
        {
            Levels = _Levels;
            Restrictions = _Restrictions;
            Limitpp = _Limitpp;
        }
        public string Levels { get; set; }
        public string Restrictions { get; set; }
        public int Limitpp { get; set; }
    }
}
