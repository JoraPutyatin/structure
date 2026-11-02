//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace structure
//{
//    internal class Program8
//    {
//        static void Main(string[] args)
//        {
//            Point a = new Point(0, 0);
//            Point b = new Point(3, 0);
//            Point c = new Point(0, 4);

//            Triangle t1 = new Triangle(a, b, c);

//            Console.WriteLine("Сторона AB: " + t1.GetSideAB());
//            Console.WriteLine("Сторона BC: " + t1.GetSideBC());
//            Console.WriteLine("Сторона CA: " + t1.GetSideCA());

//            Console.WriteLine("Периметр: " + t1.Perimeter());
//            Console.WriteLine("Площадь: " + t1.Area());

//            Console.ReadLine();
//        }
//    }
//    public struct Point
//    {
//        public int x;
//        public int y;

//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }

//        public double DistanceTo(Point other)
//        {
//            return Math.Sqrt(Math.Pow(other.x - x, 2) + Math.Pow(other.y - y, 2));
//        }
//    }

//    public struct Triangle
//    {
//        public Point A;
//        public Point B;
//        public Point C;

//        public Triangle(Point a, Point b, Point c)
//        {
//            this.A = a;
//            this.B = b;
//            this.C = c;
//        }

//        public double GetSideAB()
//        {
//            return A.DistanceTo(B);
//        }

//        public double GetSideBC()
//        {
//            return B.DistanceTo(C);
//        }

//        public double GetSideCA()
//        {
//            return C.DistanceTo(A);
//        }

//        public double Perimeter()
//        {
//            return GetSideAB() + GetSideBC() + GetSideCA();
//        }

//        public double Area()
//        {
//            double ab = GetSideAB();
//            double bc = GetSideBC();
//            double ca = GetSideCA();
//            double p = Perimeter() / 2.0;

//            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
//        }
//    }
//}
