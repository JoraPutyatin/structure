/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Война и мир", "Толстой", 1869);
            Console.WriteLine(b1.ToString());
            Console.ReadLine();
        }
    }
    public struct Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }

        public override string ToString()
        {
            return $"{Title} - {Author} {Year}";
        }
    }
}*/
