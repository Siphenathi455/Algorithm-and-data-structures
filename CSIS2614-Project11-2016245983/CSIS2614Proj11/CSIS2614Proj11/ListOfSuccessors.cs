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
    class ListOfSuccessors : Graph
    {

        List<Successor>[] successor;
        Dictionary<string, int> dicVertices;
        bool isWrite = true;

        public ListOfSuccessors(Dictionary<string, int> Vertices)
        {
            this.successor = new List<Successor>[Vertices.Count]; 
            for (int i = 0; i < Vertices.Count; i++)
                this.successor[i] = new List<Successor>();
            dicVertices = Vertices;
        }

        private List<Successor> GetSuccesor(int index)
        {
           return successor[index];
        }
        public override void AddEdge(string Start, string End, int Distance, int Time)
        {
            successor[dicVertices[Start]].Add(new Successor(End, Distance, Time));
            lstAllEdges.Add(new Edge(Start, End, Distance, Time));

        } //AddEdge

        List<string> lstVisited = new List<string>();
        public override void PrintDepthFirst(string Town)
        {

            if (!lstVisited.Contains(Town))
            {
                lstVisited.Add(Town);
                Console.Write(Town +",");
                foreach (Successor child in this.GetSuccesor(dicVertices[Town]))
                {
                    PrintDepthFirst(child.Name);
                }

            }

        }// PrintDepthFirst



        public override void ListRoutes(string Origin, string Destination, string Start, string Route, int Distance, int Time)
        {
        
          
            foreach (Edge edge in lstAllEdges) 
            {
                
                if (edge.Start == Start && edge.End != Origin && !Route.Contains(edge.End)) 
                {

                    ListRoutes(Origin, Destination, edge.End, Route + edge.End + " ", Distance + edge.Distance, Time + edge.Time);
                  
                    if (edge.End == Destination)
                    {
                       
                        lstRoutes.Add(Route+ edge.End + " ");
                        if (isWrite)
                        {
                            Console.WriteLine(Origin + ", " + Route + edge.End + " (" + (Distance + edge.Distance) + " km  ," + (Time + edge.Time) + " min" + ")"); //For debugging and explanation
                        }
                          lstDistances.Add(Distance + edge.Distance);
                          lstTimes.Add(Time + edge.Time);
                    } //if
                } //if 
            } //foreach
        

        } //AddRoute
        public override void ShortestRoute(string Origin, string Destination, out string Route, out int Distance)
        {
            lstRoutes = new List<string>();
            lstDistances = new List<int>();
            lstTimes = new List<int>();
            isWrite = false;
            ListRoutes(Origin, Destination, Origin, "", 0, 0);
            isWrite = true;
            Distance = int.MaxValue;
            Route = "";
            for (int i = 0; i < lstDistances.Count; i++)
            {
                if (lstDistances[i] < Distance && lstRoutes[i].Contains(Destination))
                {
   
                    Distance = lstDistances[i];
                    Route = lstRoutes[i];

                        Console.WriteLine("\n\nThe shortest route from " + Origin + " to " + Destination +" :");
                        Console.Write(Origin+", "+lstRoutes[i] +" ( " +lstDistances[i] +" km " + (lstTimes[i]) +" min )"+ "\n\n");

                   
                }
            } //for

        } //ShortestRoute
       

        int i = 0;
      

    }
}
