using System;

using triangleApp.model;

namespace TriangleApp.model
{

    public class Triangle
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double Sguare { get; set; }
        public double Perimeter { get; set; }

        public Triangle(int px1, int py1, int px2, int py2, int px3, int py3)
        {
            Point1 = new Point(px1, py1);
            Point2 = new Point(px2, py2);
            Point3 = new Point(px3, py3);

            Side side1 = new Side(Point1, Point2);
            Side side2 = new Side(Point2, Point3);
            Side side3 = new Side(Point3, Point1);

            Side1 = side1.CalcLeght();
            Side2 = side2.CalcLeght();
            Side3 = side3.CalcLeght();
        }

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;

            Side side1 = new Side(point1, point2);
            Side side2 = new Side(point2, point3);
            Side side3 = new Side(point3, point1);

            Side1 = side1.CalcLeght();
            Side2 = side2.CalcLeght();
            Side3 = side3.CalcLeght();
        }

        public double CalkPerimeter()
        {

            Perimeter = Side1 + Side2 + Side3;

            Console.WriteLine(Perimeter);
            return Perimeter;
        }

        public double CalkSquare()
        {
            double p = Perimeter / 2;

            Sguare = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
                        
            Console.WriteLine(Sguare);
            Console.Read();
            return Sguare;
        }

        public void CalcRadiusBig()
        {
            double R = Side1 * Side2 * Side3 / 4 / Sguare;

            Console.WriteLine($"Радиус описанной окружности равен {R}");
        }

        public void CalcRadiusSmal()
        {
            double r = Sguare / Perimeter;

            Console.WriteLine($"Радиус вписанной окружности равен {r}");
        }

        public void CalcСorners()
        {
            double conserValue1 = Math.Acos(Math.Sqrt((Side1 * Side1 + Side2 * Side2 - Side3 * Side3) / (2 * Side1 * Side2)));
            double conserValue2 = Math.Acos(Math.Sqrt((Side1 * Side1 + Side3 * Side3 - Side2 * Side2) / (2 * Side1 * Side3)));
            double conserValue3 = Math.Acos(Math.Sqrt((Side2 * Side2 + Side3 * Side3 - Side1 * Side1) / (2 * Side3 * Side2)));

            Console.WriteLine(conserValue1);
            Console.WriteLine(conserValue2);
            Console.WriteLine(conserValue3);
            Console.Read();
        }

        public void TypeOfTringle()
        {

            if (Side1 == Side2 && Side1 == Side3)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (Side1 == Side2 || Side3 == Side2 || Side1 == Side3)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
            }

            if (Side1 * Side1 - (Side3 * Side3 + Side2 * Side2) <= 0.000001 ||
                Side3 * Side3 - (Side1 * Side1 + Side2 * Side2) <= 0.000001 ||
                Side2 * Side2 - (Side1 * Side1 + Side3 * Side3) <= 0.000001 )
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
            }
        }

        public static bool operator ==(Triangle triangle, Triangle tria0)
        {
            if ( triangle.Equally(tria0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Triangle triangle, Triangle tria0)
        {
            if (triangle.Equally(tria0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Equally(Triangle tria0)
        {
            if (Side1 == tria0.Side1 && Side2 == tria0.Side2 && Side3 == tria0.Side3 ||
                Side1 == tria0.Side2 && Side2 == tria0.Side3 && Side3 == tria0.Side1 ||
                Side1 == tria0.Side3 && Side2 == tria0.Side1 && Side3 == tria0.Side2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}