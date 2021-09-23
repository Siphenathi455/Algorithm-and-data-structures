using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614_Project1
{
    class CLevelsPerMonth
    {
        public CLevelsPerMonth(string _Month, string _Level, string _LimitPP)
        {
            Month = _Month;
            Level = _Level;
            LimitPP = _LimitPP;
        }
        public string Month { get; set; }
        public string Level { get; set; }
        public string LimitPP { get; set; }
    }
}
