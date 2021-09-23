//Name : Nxele Siphenathi
//Student number : 2016245983
//CSIS2614 project 7
//Due date 25 March 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyClasses
{
    public enum Makes
    {
        BMW, Ferrari, Ford, Honda, LandRover, Mercedes, Toyota, Volkswagen
    } //Makes
    public class CCar : IComparable
    {
        int n = 1;
        public Makes Make { get; set; }
        public string Model { get; set; }
        public Color Colour { get; set; }
        public int ODO { get; set; }
        public int Value { get; set; }
        public int CompareTo(object obj)
        {
            string Alphabets = "abcdefghijklmnopqrsruvwxyz0123456789";
            string Obj1 = "";
            string Obj2 = "";

            if (n % 2 == 0 )
            Obj2 = obj.ToString().ToLower();
            else
            Obj1 = obj.ToString().ToLower();

           for(int i = 0; i < Obj1.Length; i++)
            {
                int i1 = Alphabets.IndexOf(Obj1[i]);
                int i2 = Alphabets.IndexOf(Obj2[i]);
                if (i1 < i2)
                    return 1;
                else if (i2 < i1)
                    return 2;
            }
            n++;
           return 0;

        } //CompareTo

        public override string ToString()
        {

            return Make.ToString() + " " + Model;
        } //ToString
    }
}
