using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_2_Algorithms_and_data_structures
{
    internal class Utils
    {
        public static void TaskChoiser()
        {
            Console.WriteLine("Выберите задание...");
            string[] somearr = { "1 - Простое число.", "2 - Число Фибоначчи." };

            for (int i = 0; i < somearr.Length; i++)
            {
                Console.WriteLine(somearr[i]);
            }
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                SimpNum.TestCode();
            }
            if (choice == 2)
            {
                recursion.Launcher();
            }
        }
    }
}
