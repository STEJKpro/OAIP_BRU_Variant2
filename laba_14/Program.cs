using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Дана последовательность целых чисел. 
 * Задачи из данного пункта решить двумя способами, 
 * используя одномерный массив, 
 * а затем двумерный. Размер¬ность массива вводится с клавиатуры
 * 1.2 Заменить все элементы, меньшие заданного числа, этим числом.
 * 
 * 
 * Дана последовательность из n действительных чисел. Задачи из данного пункта решить, 
 * используя одномерный массив.
 * 2.2 Вывести на экран номера всех минимальных элементов.
 * 
 * 
 * Дан массив размером  n×n, элементы которого целые числа. 
 * При решении задач из данного пункта использовать двумерный массив
 * 3.2 Подсчитать сумму элементов, расположенных на побочной диагонали.
 * 
 * Дан массив размером  n×n, элементы которого целые числа. Для хранения массив n×n использовать ступенчатый массив
 * 4.2	Четные столбцы таблицы заменить на вектор Х.
 * 
 */
namespace laba_14
{
    internal class Program
    {
        //1.2 массив
        static void ReplaceIfLess(ref int[] arr, int number)
        {
            //1.2
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < number) arr[i] = number;

            }
        }
        //1.2 матрица
        static void ReplaceIfLess(ref int[,] arr, int number)
        {
            //1.2
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < number) arr[i, j] = number;
                }
            }
        }

        //2.2
        static void PrintMinIndexes(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Индексы всех минимальных элементов:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                {
                    Console.Write(i + "; ");
                }
            }
        }

        //3.2
        static int SecondDiagonalSum(int[,] arr)
        {
            int sum = 0;
            int n = arr.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                sum += arr[i, n - i - 1];
            }
            return sum;
        }

        //4.2
        static void ChangeToVector(ref int[][] arr, int[] X)
        {
            for (int j = 1; j < arr.GetLength(0); j += 2) // проходим по четным столбцам
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    arr[i][j] = X[i]; // заменяем столбец на вектор X
                }
            }
        }

        static void Print(int[] arr)
        {
            foreach (int x in arr) Console.Write(x + "; ");
            Console.WriteLine();
        }
        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        static void Print(int[][] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[i][j] + "\t"); 
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            // 1.2 с массивом
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = random.Next(-10, 10);
            }
            Console.WriteLine("Исходный массив: ");
            Print(array1);
            ReplaceIfLess(ref array1, 4);
            Console.WriteLine("Преобразованный массив: ");
            Print(array1);


            // 1.2 c матрицей
            int[,] array2 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2[i, j] = random.Next(-10, 10);
                }
            }
            Console.WriteLine("Исходный массив: ");
            Print(array2);
            ReplaceIfLess(ref array2, 4);
            Print(array2);


            //2.2
            PrintMinIndexes(array1);
            Console.WriteLine();


            //3.2
            Console.WriteLine($"Сумма элементов побочной диагонал: {SecondDiagonalSum(array2)}");


            //4.2
            int[] vectorX = new int[n];
            for (int i = 0; i < n; i++)
            {
                vectorX[i] = random.Next(-10, 20); 
            }
            Console.WriteLine();

            Console.WriteLine("Вектор X: ");
            Print(vectorX);

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = random.Next(-10, 10); 
                }
            }
            Console.WriteLine();
            Console.WriteLine("Исходный ступенчатый массив");
            Print(matrix);
            ChangeToVector(ref matrix, vectorX);
            Console.WriteLine();
            Console.WriteLine("С замемннеными столбцами на вектор");
            Print(matrix);
        }

    }
}
