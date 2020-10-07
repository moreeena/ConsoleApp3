using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            long c;
            string g;
            do
            {
                Console.WriteLine("Введите значение int");
                g = Console.ReadLine();
            }
            while (!int.TryParse(g, out a));
            do
            {
                Console.WriteLine("Введите значение double");
                g = Console.ReadLine();
            }
            while (!double.TryParse(g, out b));
            do
            {
                Console.WriteLine("Введите значение long");
                g = Console.ReadLine();
            }
            while (!long.TryParse(g, out c));
            Console.WriteLine($"a={0},b={1},c={2}", a, b, c);
            Console.ReadKey();

        }
    }
}
