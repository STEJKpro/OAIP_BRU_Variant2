using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
        2. Вводить последовательность до тех пор, пока не встретятся три подряд идущих положительных числа.
            Тогда прервать ввод и сообщить, сколько во введенной последовательности было: 
                а) всего чисел; 
                б) положительных чисел; 
                в) отрицательных чисел.
*/
namespace laba_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = 0;
            int positiveNumbers = 0;
            int negativeNumbers = 0;
            int positiveLine = 0;
            while (positiveLine < 3) //check number of positive numbers in row
            {
                Console.Write("Введите число: ");
                double number = double.Parse(Console.ReadLine());
                totalNumbers++; // counter of total numbers

                if (number > 0)
                {
                    positiveNumbers++;     // increase of positive numbers
                    positiveLine++;      // increase positive numbers in row
                }
                else
                {
                    positiveLine = 0;    // reset counter o positive numbers in row
                    if (number < 0)
                    {
                        negativeNumbers++; // increase of neggative numbers
                    }
                }

            }

            // Results output
            Console.WriteLine($"Всего чисел: {totalNumbers}");
            Console.WriteLine($"Положительных чисел: {positiveNumbers}");
            Console.WriteLine($"Отрицательных чисел: {negativeNumbers}");

        }
    }
}
