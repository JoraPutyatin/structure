/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
   internal class Program1
   {
       static void Main(string[] args)
       {
           Rectangle r1 = new Rectangle(5, 10);
           Console.WriteLine(r1.ToString());
           Console.ReadLine();
       }
   }
   public struct Rectangle
   {
       public int Width;
       public int Height;

       public Rectangle(int width, int height)
       {
           this.Width = width;
           this.Height = height;
       }

       public override string ToString()
       {
           int area = Width * Height;
           int perimeter = (Width + Height) * 2;
           return $"Площадь: {area}, Периметр: {perimeter}";
       }
   }
}
 */