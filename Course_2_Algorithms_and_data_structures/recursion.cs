using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_2_Algorithms_and_data_structures
{
    internal class recursion
    {
        /// <summary>
        /// Вычислить число Фиббоначи для заданного числа
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns>Результат вычисления</returns>
        public static int FibV1(int n)
        {
            int a0 = 0;
            int a1 = 1;
            int a = a1;
            for (int i = 2; i <= n; i++)
            {
                a = a0 + a1;
                a0 = a1;
                a1 = a;
            }
            return a1;
        }

        /// <summary>
        /// Вычислить число Фиббоначи для заданного числа (через рекурсию)
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns>Результат вычисления</returns>
        public static int FibV2(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibV2(n - 1) + FibV2(n - 2);
        }

        /// <summary>
        /// (*) Написать программу, вычисляющую число Фибоначчи для заданного значения
        /// рекурсивным способом.
        /// </summary>
        public static void Launcher()
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число Фиббоначи: {FibV1(n)}");
            Console.WriteLine($"Число Фиббоначи через рекурсию: {FibV2(n)}");
            Console.ReadKey(true);
        }
    }
}
