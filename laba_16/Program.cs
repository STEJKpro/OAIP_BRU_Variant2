using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// 1.2	Создать файл и записать в него обратные натуральные числа. 
// 2.2 Дан текстовый файл. Найти самую длинную строку и ее длину.
namespace laba_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.2
            string path = "REVERSES.txt";
            using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.Create)))
            {
                // Задаем диапазон чисел (например, от 1 до 100)
                int n = 100;
                // Записываем числа в обратном порядке в бинарном формате
                for (int i = 1; i <= n; i++)
                {
                    writer.WriteLine(1.0/i); // Записываем каждое число как 4 байта (int)
                }
            }
            // 2.2
            path = "TEXT.txt";
            if (File.Exists(path))
            {
                int longestLength = 0;

                // Читаем файл построчно с использованием блока using для правильного освобождения ресурсов
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Проверяем длину текущей строки
                        if (line.Length > longestLength)
                        {
                            longestLength = line.Length;
                        }
                    }
                }

                Console.WriteLine("Длина самой длинной строки: " + longestLength);
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }
    }
}
