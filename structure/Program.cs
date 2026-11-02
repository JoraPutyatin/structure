/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
   internal class Program
   {
       static void Main(string[] args)
       {
           Point p1 = new Point(15, 5);
           Console.WriteLine(p1.ToString());
           Console.ReadLine();
       }
   }
   public struct Point
   {
       public int x;
       public int y;

       public Point(int x, int y)
       {
           this.x = x;
           this.y = y;
       }

       public override string ToString()
       {
           return $"x = {x}, y = {y}, расстояние между точками: {Math.Abs(y - x)}";
       }
   }
}*/
