//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace structure
//{
//    internal class Program3
//    {
//        static void Main(string[] args)
//        {
//            ComplexNumber c1 = new ComplexNumber(1, 2);
//            ComplexNumber c2 = new ComplexNumber(3, 4);
//            Console.WriteLine(c1.ToString());
//            Console.WriteLine($"Сложение с (3, 4): {c1.Add(c2).Real} + {c1.Add(c2).Imag}i");
//            Console.ReadLine();
//        }
//    }
//    public struct ComplexNumber
//    {
//        public int Real;
//        public int Imag;

//        public ComplexNumber(int real, int imag)
//        {
//            this.Real = real;
//            this.Imag = imag;
//        }

//        public ComplexNumber Add(ComplexNumber other)
//        {
//            return new ComplexNumber(this.Real + other.Real, this.Imag + other.Imag);
//        }

//        public override string ToString()
//        {
//            return $"Real = {Real}, Imag = {Imag}";
//        }
//    }
//}
