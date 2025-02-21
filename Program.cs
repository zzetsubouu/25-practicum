using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            var edition1 = new Edition("", "", 1800);
            var edition2 = new Edition("каки", "пьяник", 2000);

            Console.Write("введите название ");
            string title = Console.ReadLine();
            Console.Write("введите фаилю автора ");
            string surname = Console.ReadLine();
            Console.Write("введите год ");
            int year = int.Parse(Console.ReadLine());
            Edition edition3 = new Edition(title, surname, year);
            Console.WriteLine($"{edition3.ToString()}\n{edition3.ToChangePublicationYear(year)}\n{edition3.FallIntoYear(year)}");
            Console.ReadKey();
        }
    }
}
