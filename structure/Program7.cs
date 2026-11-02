//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace structure
//{
//    internal class Program7
//    {
//        static void Main(string[] args)
//        {
//            Money m1 = new Money(150, 80);
//            Money m2 = new Money(20, 50);

//            Console.WriteLine("Первая сумма: " + m1.ToString());
//            Console.WriteLine("Вторая сумма: " + m2.ToString());

//            Money sum = m1.Add(m2);
//            Console.WriteLine("Сложение: " + sum.ToString());

//            Money diff = m1.Subtract(m2);
//            Console.WriteLine("Вычитание: " + diff.ToString());

//            bool isGreater = m1.IsGreater(m2);
//            Console.WriteLine($"m1 больше m2? {isGreater}");

//            Console.ReadLine();
//        }
//    }

//    public struct Money
//    {
//        public int Rubles;
//        public int Kopeks;

//        public Money(int rubles, int kopeks)
//        {
//            this.Rubles = rubles;
//            this.Kopeks = kopeks;
//        }

//        private int TotalKopeks()
//        {
//            return Rubles * 100 + Kopeks;
//        }

//        public Money Add(Money other)
//        {
//            int total = this.TotalKopeks() + other.TotalKopeks();
//            return new Money(total / 100, total % 100);
//        }

//        public Money Subtract(Money other)
//        {
//            int total = this.TotalKopeks() - other.TotalKopeks();

//            if (total < 0) return new Money(0, 0);

//            return new Money(total / 100, total % 100);
//        }

//        public bool IsGreater(Money other)
//        {
//            return this.TotalKopeks() > other.TotalKopeks();
//        }

//        public override string ToString()
//        {
//            return $"{Rubles} руб. {Kopeks} коп.";
//        }
//    }
//}
