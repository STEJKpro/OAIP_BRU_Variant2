using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Задание 1 (2):	Разработать метод f(n, x), который для заданного натурального числа n и вещественного х находит значение выражения  . 
 * Вычислить с помощью данного метода значение выражения  x^2/2 + x^4/4 + x^6/6.
 * 
 * Задание 2 (2):
 * Постройте таблицу значений функции y =  f (x) для х  [a, b]  с шагом h.
 * Для решения задачи использовать вспомогательный метод.
 */
namespace laba_13
{
    internal class Program
    {
        static double function_f_x(double x, int n)
        {
            return Math.Pow(x, n) / n;
        }


        static double function_f_x_2(double x)
        {
            if (x < 0) return 0;
            if (x == 1) return 1;
            return Math.Pow(x, 2) + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1!");
            Console.Write($"Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double res = function_f_x(x, 2) + function_f_x(x, 4) + function_f_x(x, 6);
            Console.WriteLine($"Задание 1. Результат: {res}");


            Console.WriteLine("Задание 2!");
            Console.WriteLine("Введите диапозон значений");
            Console.WriteLine("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nb: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите шаг h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Задание 2. Результат: ");

            Console.WriteLine("value\tresult");
            for (double i = a; i < b; i=i+h) Console.WriteLine($"{i}\t{function_f_x_2(i)}");

        }
    }
}
