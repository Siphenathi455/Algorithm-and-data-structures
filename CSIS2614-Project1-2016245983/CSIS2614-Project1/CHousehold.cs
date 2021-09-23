using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614_Project1
{
    class CHousehold
    {
        public CHousehold(string _Adress , int _People , int _Usage , string _Month)
        {
            Adress = _Adress;
            People = _People;
            Usage = _Usage;
            Month = _Month;


        }

        public string Adress { get; set; }
        public int People { get; set; }
        public int Usage { get; set; }
        public string Month { get; set; }
    }
}
