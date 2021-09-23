using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614Proj11
{
    public class Edge
        {
            public string Start { get; set; }
    public string End { get; set; }
    public int Distance { get; set; }
    public int Time { get; set; }

    public Edge(string Start, string End, int Distance, int Time)
    {
        this.Start = Start;
        this.End = End;
        this.Distance = Distance;
        this.Time = Time;
    }
} //Edge
}
