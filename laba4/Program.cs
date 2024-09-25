using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод значения x
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 0;

            if (x <= 0) 
            {
                Console.WriteLine($"\"При x <= 0 \"");
                y = Math.Cos(x);
            }
            else if (x > 0 && x <= Math.PI / 2)
            {
                Console.WriteLine($"\"При x > Пи/2 и x <= 64  \"");
                y = Math.Asin(x); // результат в радианах
            }
            else if (x > Math.PI / 2 && x <= 64)
            {
                Console.WriteLine($"\"При x > Пи/2 и x <= 64  \"");
                y = Math.Log(x, 4); // log4(x)
            }
            else
            {
                Console.WriteLine($"\"Остальной случай\"");
                y = 1 / (x * x);
            }

            // Вывод результата
            Console.WriteLine($"Значение функции y при x = {x}: {y}");
        }
    }
}
