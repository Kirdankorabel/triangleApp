using System;
using System.Collections.Generic;
using System.Text;

namespace triangleApp.model
{
    public class Point
    {

        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
                
        public Point ( int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;

        }

        public void Coordinate (Point point)
        {
            double coordinateX = point.CoordinateX;
            double coordinateY = point.CoordinateY;

            Console.WriteLine($"Координаты точки {nameof(point)} : x = {coordinateX} y = {coordinateY}");
        }
    }
}
