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
            Sort(Convert.ToInt32(Console.ReadLine()));
        }

        public static void Sort(int quantity)
        {
            // Заполняет массив случайными значениями.
            Random rand = new Random();
            int[] numbers = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                numbers[i] = rand.Next(0, quantity); ;
            }

            int[] numbersCount = new int[quantity]; // Массив с подсчетом количества значений.

            for (int counter = 0; counter < numbers.Length; counter++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (counter == numbers[j])
                    {
                        numbersCount[counter]++;
                    }
                }
                for (int f = 1; f <= numbersCount[counter]; f++)
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
