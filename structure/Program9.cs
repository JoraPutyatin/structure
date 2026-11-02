//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace structure
//{
//    internal class Program9
//    {
//        static void Main(string[] args)
//        {
//            Point3D p1 = new Point3D(0, 0, 0);
//            Point3D p2 = new Point3D(1, 2, 2);

//            Console.WriteLine("Расстояние между точками: " + p1.DistanceTo(p2));

//            Console.ReadLine();
//        }
//    }
//    public struct Point3D
//    {
//        public int x;
//        public int y;
//        public int z;

//        public Point3D(int x, int y, int z)
//        {
//            this.x = x;
//            this.y = y;
//            this.z = z;
//        }

//        public double DistanceTo(Point3D other)
//        {
//            return Math.Sqrt(Math.Pow(other.x - x, 2) + Math.Pow(other.y - y, 2) + Math.Pow(other.z - z, 2));
//        }
//    }
//}
