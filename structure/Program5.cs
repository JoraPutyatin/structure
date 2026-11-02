//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace structure
//{
//    internal class Program5
//    {
//        static void Main(string[] args)
//        {
//            SimpleDate d1 = new SimpleDate(1, 1, 2020);
//            Console.WriteLine(d1.ToString());
//            Console.ReadLine();
//        }
//    }
//    public struct SimpleDate
//    {
//        public int Day;
//        public int Month;
//        public int Year;

//        public SimpleDate(int day, int month, int year)
//        {
//            this.Day = day;
//            this.Month = month;
//            this.Year = year;
//        }

//        public override string ToString()
//        {
//            bool isLeapYear = (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
//            return $"Дата: {Day}.{Month}.{Year}, Високосный: {isLeapYear}";
//        }
//    }
//}
