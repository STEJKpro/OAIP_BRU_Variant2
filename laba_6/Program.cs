using System;


namespace laba_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Заданные параметры
            double a = Math.PI / 4; // Начало отрезка
            double b = Math.PI / 2; // Конец отрезка
            int m = 15; // кол-во разбиений

            // Шаг разбиения
            double step = (b - a) / m;

            // Заголовок таблицы
            Console.WriteLine("{0,10}\t{1,10}", "x", "f(x)");

            // Вычисление и вывод значений
            for (int i = 0; i <= m; i++)
            {
                
                double x = a + i * step;
                double fx = Math.Sin(x);
                Console.WriteLine("{0,10:F3}\t{1,10:F3}", x, fx);
            }


            // Задание 2: (1+1)(1+x^2) L .... (1+x^2n)
            double x1 = 10;
            int n = 2;  // n >=0
            double result = 1;
            for (int i = 0; i <= n; i++)
            {
                double current_value = (1 + Math.Pow(x1, 2 * i));
                result = result * current_value;

            }
            Console.WriteLine($"Конечное произведение: {result}");
            Console.ReadKey();

        }
    }
}
