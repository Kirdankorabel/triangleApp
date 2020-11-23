using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleApp.model
{
    public class Conser
    {
        public double ConserValue { get; set; }
        public double ConserValu1 { get; set; }
        public double ConserValu2 { get; set; }
        public double ConserValu3 { get; set; }

        public Conser(Triangle triangle)
        {            
        }

        public double calcConser(double Side1, double Side2, double Side3 )
        {

            double side1 = Side1;
            double side2 = Side2;
            double side3 = Side3;

            double conserValue = Math.Acos(Math.Sqrt((side1 * side1 + side2 * side2 - side3 * side3) / (2 * side1 * side2)));

            ConserValue = conserValue;

            return ConserValue;
        }

    }
   
}
