using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Задание 1: Дана целочисленная прямоугольная матрица. Определить количество столб¬цов, не содержащих ни одного нулевого элемента.
 * Задание 2: Дана целочисленная прямоугольная матрица. Определить количество столб¬цов, не содержащих ни одного нулевого элемента. 
 * Характеристикой строки целочисленной матрицы назовем сумму ее положительных четных элементов. Переставляя строки заданной матрицы, 
 * расположить их в соответствии с ростом характеристик. 
 */
namespace laba_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры матрицы:");
            Console.Write("rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] dM = new int[rows, columns];
            Console.WriteLine("Исходный массив: ");
            Random rnd = new Random();

            // init and stdout array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) // line cyclie
                {
                    dM[i, j] = rnd.Next(0, 6);
                    Console.Write(dM[i, j]);
                    Console.Write("\t");

                }
                Console.WriteLine();
            }

            //Определить количество столб¬цов, не содержащих ни одного нулевого элемента
            int countOfNonZeroColumns = columns;
            for (int i = 0; i < columns; i++)
            {
                bool haveZero = false;
                for (int j = 0; j < rows; j++)
                {
                    if (dM[j,i ] == 0) { haveZero = true; }
                }
                if (haveZero) { countOfNonZeroColumns--; }
            }
            Console.WriteLine("Кол-во столбцов не содержащих ни одного нулевого элемента: " + countOfNonZeroColumns + "\n");



            // Массив для хранения характеристик строк
            int[] rowCharacteristics = new int[rows];

            // Подсчет характеристик для каждой строки
            for (int i = 0; i < rows; i++)
            {
                rowCharacteristics[i] = 0;  // Инициализация характеристики строки
                for (int j = 0; j < columns; j++)
                {
                    if (dM[i, j] > 0 && dM[i, j] % 2 == 0)
                    {
                        rowCharacteristics[i] += dM[i, j];  // Суммирование положительных четных элементов
                    }
                }
            }

            // Создание массива индексов для сортировки строк
            int[] rowIndices = Enumerable.Range(0, rows).ToArray();

            // Реализация сортировки пузырьком
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (rowCharacteristics[rowIndices[j]] > rowCharacteristics[rowIndices[j + 1]])
                    {
                        // Обмен индексов
                        int temp = rowIndices[j];
                        rowIndices[j] = rowIndices[j + 1];
                        rowIndices[j + 1] = temp;
                    }
                }
            }

            // Вывод отсортированной матрицы
            Console.WriteLine("Отсортированная матрица:");
            foreach (int rowIndex in rowIndices)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(dM[rowIndex, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
