using System;
using triangleApp.model;
using TriangleApp.model;

namespace triangleApp
{
    class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine("введите координаты точки 1 по оси абсцисс");
            //var x1 = Console.ReadLine();
            //int coordinateX1 = Convert.ToInt32(x1);
            //Console.WriteLine("введите координаты точки 1 по оси ординат");
            //var y1 = Console.ReadLine();
            //int coordinateY1 = Convert.ToInt32(y1);

            //Console.WriteLine("введите координаты точки 2 по оси абсцисс");
            //var x2 = Console.ReadLine();
            //int coordinateX2 = Convert.ToInt32(x2);
            //Console.WriteLine("введите координаты точки 2 по оси ординат");
            //var y2 = Console.ReadLine();
            //int coordinateY2 = Convert.ToInt32(y2);

            //Console.WriteLine("введите координаты точки 3 по оси абсцисс");
            //var x3 = Console.ReadLine();
            //int coordinateX3 = Convert.ToInt32(x3);
            //Console.WriteLine("введите координаты точки 3 по оси ординат");
            //var y3 = Console.ReadLine();
            //int coordinateY3 = Convert.ToInt32(y3);

            //Point point1 = new Point(coordinateX1, coordinateY1);
            //Point point2 = new Point(coordinateX2, coordinateY2);
            //Point point3 = new Point(coordinateX3, coordinateY3);

            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 0);
            Point point3 = new Point(0, 3);

            Triangle triangle = new Triangle(point1, point2, point3);

            Point point01 = new Point(0, 0);
            Point point02 = new Point(4, 0);
            Point point03 = new Point(0, 3);

            Triangle tria0 = new Triangle(point01, point02, point03);

            point1.Coordinate();
            point2.Coordinate();
            point3.Coordinate();

            triangle.CalkPerimeter();
            triangle.CalkSquare();
            triangle.CalcСorners();
            triangle.CalcRadiusBig();
            triangle.CalcRadiusSmal();
            triangle.TypeOfTringle();

            if (triangle == tria0)
            {
                Console.WriteLine("=");
            }
            if (triangle != tria0)
            {
                Console.WriteLine("!=");
            }

            Console.Read();
        }
    }
}
