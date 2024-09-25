using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Пример вызова функции с углом в радианах
            double alpha = 30; // Угол в градусах
            double result_z1 = CalculateZ1(alpha);
            double result_z2 = CalculateZ1(alpha);
            bool is_equal = result_z1 == result_z2;

            Console.WriteLine(
                $"z1 = {result_z1}\n" +
                $"z2 = {result_z2}\n" +
                $"{(result_z1 == result_z2 ? "Вычисления верны" : "Ошибка в вычислениях")}"
                );
        }
        static double CalculateZ1(double alpha)
        {
            double alpha_rad = DegreesToRadians(alpha);
            return Math.Cos(alpha_rad) + Math.Sin(alpha_rad) + Math.Cos(3 * alpha_rad) + Math.Sin(3 * alpha_rad);
        }

        static double CalculateZ2(double alpha)
        {
            double alpha_rad = DegreesToRadians(alpha);
            double sqrt2 = Math.Sqrt(2); // Вычисляем корень из 2
            return 2 * sqrt2 * Math.Cos(alpha_rad) * Math.Sin((Math.PI / 4) + 2 * alpha_rad);
        }

        static double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
    }
}
