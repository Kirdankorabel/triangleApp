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

        public double LeghtValue(Side side)
        {

            Point1 = side.Point1;
            Point2 = side.Point2;

            int px1 = Point1.CoordinateX;
            int py1 = Point1.CoordinateY;
            int px2 = Point2.CoordinateX;
            int py2 = Point2.CoordinateY;

            double leght = Math.Sqrt((px1 - px2) * (px1 - px2) + (py1 - py2) * (py1 - py2));

            Leght = leght;
            return Leght;
        }

    }
        
}
