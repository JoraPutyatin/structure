//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace structure
//{
//    internal class Program6
//    {
//        static void Main(string[] args)
//        {
//            Vector2D v1 = new Vector2D(3, 4);
//            Console.WriteLine(v1.ToString());
//            Console.ReadLine();
//        }
//    }
//    public struct Vector2D
//    {
//        public int x;
//        public int y;

//        public Vector2D(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }

//        public override string ToString()
//        {
//            double length = Math.Sqrt(x * x + y * y);
//            return $"x = {x}, y = {y}, Длина вектора: {length}";
//        }
//    }
//}
