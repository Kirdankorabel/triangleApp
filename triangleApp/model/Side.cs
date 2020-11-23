using System;
using System.Collections.Generic;
using System.Text;
using triangleApp.model;

namespace TriangleApp.model
{
    public class Side
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public double Leght { get; set; }
        public Side (Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public double CalcLeght()
        {
            double Leght = Math.Sqrt((Point1.CoordinateX - Point2.CoordinateX) * (Point1.CoordinateX - Point2.CoordinateX) 
                                   + (Point1.CoordinateY - Point2.CoordinateY) * (Point1.CoordinateY - Point2.CoordinateY));
            return Leght;
        }
    }        
}
