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

        public void Coordinate ()
        {
            Console.WriteLine($"Координаты точки : x = {CoordinateX} y = {CoordinateY}");
        }

        //public void Controller ()
    }
}
