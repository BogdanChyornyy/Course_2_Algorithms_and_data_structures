using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatingInterface;

namespace HomeworkTasks
{
    public class CountingSort : IOperate
    {
        public string name => "Сортировка подсчетом";

        public string description => "необходимо реализовать алгоритм сортировки подсчетом.";

        public void Run()
        {
            Console.WriteLine("Введите желаемую длину массива");
            int quantity = Convert.ToInt32(Console.ReadLine()); // Обозначение длины массива для генерации.
            Random rand = new Random();
            int[] numbers = new int[quantity];
            for (int i = 0; i < quantity; i++) // Генерация массива.
            {
                numbers[i] = rand.Next(0, quantity);
            }
            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Sort(numbers, quantity);
        }
        public static void Sort(int[] numbers, int quantity)
        {
            var range = new SortedDictionary<int, int>(); // Создание сортированной библиотеки.

            for (int i = 0; i < quantity; i++) // Заполнение библиотекию
            {
                if (range.ContainsKey(numbers[i]))
                {
                    range[numbers[i]]++;
                }
                else
                {
                    range.Add(numbers[i], 1);
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            foreach (var key in range.Keys) // Вывод на экран.
            {
                for (int j = 1; j <= range[key]; j++)
                {
                    Console.WriteLine(key);
                }
            }
        }
    }
}
