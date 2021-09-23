//2016245983
//Nxele Siphenathi
//CSIS2614 Project 10 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614Proj11
{
   abstract class Graph
    {

        protected List<Edge> lstAllEdges;
        protected List<string> lstRoutes;
        protected List<int> lstDistances;
        protected List<int> lstTimes;

        public Graph() 
        {
            lstAllEdges = new List<Edge>();
            lstDistances = new List<int>();
            lstTimes = new List<int>();
            lstRoutes = new List<string>();
        } //Construct
        public abstract void AddEdge(string Start, string End, int Distance, int Time);
        public abstract void PrintDepthFirst(string Town);
        public abstract void ListRoutes(string Origin, string Destination, string Start, string Route, int Distance, int Time);
        public abstract void ShortestRoute(string Origin, string Destination, out string Route, out int Distance);
    

    }
}
