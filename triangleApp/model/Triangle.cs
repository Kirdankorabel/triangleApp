using System;
using System.Collections.Generic;

using triangleApp.model;
using System.Text;

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

        public double S { get; set; }
        public double P { get; set; }

        public Triangle(int px1, int py1, int px2, int py2, int px3, int py3)
        {
        }
        
        public Triangle (Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;

            Side side1 = new Side(point1, point2);
            Side side2 = new Side(point2, point3);
            Side side3 = new Side(point3, point1);

            double side1Leght = side1.LeghtValue(side1);
            double side2Leght = side2.LeghtValue(side2);
            double side3Leght = side3.LeghtValue(side3);

            Side1 = side1Leght;
            Side2 = side2Leght;
            Side3 = side3Leght;

        }
                 
        public double Perimeter(Triangle triangle)
        {
            double p;

            p = triangle.Side1 + triangle.Side2 + triangle.Side3;

            Console.WriteLine(p);
            P = p;
            return P;
        }

        public double Square(Triangle triangle)
        {
            double s;
            double p = triangle.P / 2;

            s = Math.Sqrt(p * (p - triangle.Side1) * (p - triangle.Side2) * (p - triangle.Side3));

            S = s;
            Console.WriteLine(S);
            Console.Read();
            return S;
        }

        public void CalcRadiusBig(Triangle triangle)
        {
            double side1 = triangle.Side1;
            double side2 = triangle.Side2;
            double side3 = triangle.Side3;

            double s = triangle.S;

            double R = side1 * side2 * side3 / 4 / s;

            Console.WriteLine($"Радиус описанной окружности равен {R}");
        }

        public void CalcRadiusSmal(Triangle triangle)
        {
            double p = triangle.P;

            double s = triangle.S;
            double r = s / p;

            Console.WriteLine($"Радиус вписанной окружности равен {r}");
        }

        public void CalcСorners(Triangle triangle)
        {
            Triangle Trial = triangle;

            double side1 = triangle.Side1;
            double side2 = triangle.Side2;
            double side3 = triangle.Side3;

            Conser conser = new Conser(Trial);

            double conser1 = conser.calcConser(side1, side2, side3);
            double conser2 = conser.calcConser(side2, side3, side1);
            double conser3 = conser.calcConser(side3, side1, side2);

            double ConserValue1 = conser1;
            double ConserValue2 = conser2;
            double ConserValue3 = conser3;

            Console.WriteLine(ConserValue1);
            Console.WriteLine(ConserValue2);
            Console.WriteLine(ConserValue3);
            Console.Read();
        }

        public void TypeOfTringle(Triangle triangle)
        {
            double s1 = triangle.Side1;
            double s2 = triangle.Side2;
            double s3 = triangle.Side3;
            
            if (s1 == s2 && s1 == s3)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (s1 == s2)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
            }

            if (s3 * s3 + s2 * s2 == s1 * s1 ||
                s1 * s1 + s2 * s2 == s3 * s2 ||
                s1 * s1 + s3 * s3 == s2 * s2 )
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {

            }
        }

        public static bool operator ==(Triangle triangle, Triangle tria0)
        {
            if (triangle.Side1 == tria0.Side1 && triangle.Side2 == tria0.Side2 && triangle.Side3 == tria0.Side3 ||
                triangle.Side1 == tria0.Side2 && triangle.Side2 == tria0.Side3 && triangle.Side3 == tria0.Side1 ||
                triangle.Side1 == tria0.Side3 && triangle.Side2 == tria0.Side1 && triangle.Side3 == tria0.Side2 )
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
            if (triangle.Side1 == tria0.Side1 && triangle.Side2 == tria0.Side2 && triangle.Side3 == tria0.Side3 ||
                triangle.Side1 == tria0.Side2 && triangle.Side2 == tria0.Side3 && triangle.Side3 == tria0.Side1 ||
                triangle.Side1 == tria0.Side3 && triangle.Side2 == tria0.Side1 && triangle.Side3 == tria0.Side2)
            {
                return false;
            }
            else
            {
                return true;
            }

        }





    }
}
