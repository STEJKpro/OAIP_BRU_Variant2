using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 2 В одномерном массиве, состоящем из n вещественных элементов, вычис-лить: 
        а) сумму положительных элементов массива; 
        б) произведение элементов массива, расположенных между максимальным по модулю и минимальным по модулю элементами; 
        в) упорядочить элементы массива по убыванию.
 */
namespace laba_9
{
    internal class Program
    {
        static void BubbleSortDes(ref double[] array) //Descending Bubble Sort
        {
            int n = array.Length;
            bool swapped;

            double temp;
            // Проходим по массиву n-1 раз
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                // Проходим по неотсортированной части массива
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Если элементы стоят в неправильном порядке, меняем их местами
                    if (array[j] < array[j + 1]) // < - по убыванию -- > - по возрастанию
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                // Если не было обменов, массив уже отсортирован
                if (!swapped)
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 50;
            double[] array = new double[n];
            Random random = new Random();
            // Заполнение массива случайными вещественными числами
            for (int i = 0; i < n; i++)
            {
                array[i] = random.NextDouble() * 200 - 100; // случайное число от -100 до 100
            }

            BubbleSortDes(ref array); //Сортировка массива


            /* Поиск  произведение элементов массива, расположенных между максимальным по модулю и минимальным по модулю элементами; */
            double sumPositive = 0;
            double productOfElements = 1;

            int minIndex = 0;
            double minAbsNumber = array[0];

            int maxIndex = 0;
            double maxAbsNumber = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < Math.Abs(minAbsNumber))
                {
                    minAbsNumber = array[i];
                    minIndex = i;
                }

                if (Math.Abs(array[i]) > Math.Abs(maxAbsNumber))
                {
                    maxAbsNumber = array[i];
                    maxIndex = i;
                }
            }
            int start = Math.Min(minIndex, maxIndex) + 1;
            int end = Math.Max(minIndex, maxIndex) - 1;

            if (start > end)
            {
                Console.WriteLine("Нет элементов между минимальным и максимальным по модулю.");
            }
            else
            {
                // Вычисляем произведение элементов между ними
                for (int i = start; i <= end; i++)
                {
                    productOfElements *= array[i];
                }
            }
                
                //Array.Sort(ints);
            Console.WriteLine("a) Cумму положительных элементов массива: " + sumPositive);
            Console.WriteLine("б) Произведение элементов массива, расположенных между максимальным по модулю и минимальным по модулю элементами: " + productOfElements);
            Console.WriteLine("в) Упорядоченный по убыванию массив: ");
            Console.WriteLine(String.Join(", ", array));

        }
    }
}
