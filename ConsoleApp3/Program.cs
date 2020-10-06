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
            bool t = true;
            while (t)
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
                 }
                catch
                {
                    Console.WriteLine($"Неправильно введенная перемнная");
                }
                Console.WriteLine("\nPress \"q\" to exit or another key to continue: ");
                t = Console.ReadKey().Key != ConsoleKey.Q;
            }
        }
    }
}
