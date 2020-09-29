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
            int q;
            do
            {
                try
                {
                    Console.WriteLine($"Введите значение типа int");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Введите значение типа double");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Введите значение типа long");
                    long c = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("a ={0}, b={1}, c={2}", a, b, c);
                    Console.WriteLine($"Чтобы закончить программу, введите 1");
                }
                catch
                {
                    Console.WriteLine($"Неправильно введенная переменная");
                }
                q = Convert.ToInt32(Console.ReadLine());

            }
            while (q != 1);
        }
    }
}
