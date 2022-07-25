using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatingInterface;

namespace HomeworkTasks
{
    public class SimpNum : IOperate
    {
        public string name => "Простое число";

        public string description => "Необходимо реализовать функцию, согласно блок-схеме, целью которой является - выяснить, простое число или нет";

        public void Run()
        {
            TestCode();
        }


        public static void TestCode()
        {
            Console.WriteLine("Реализация проверочного кода...");
            Console.WriteLine("Выберите сценарий: ");
            string[] way = { "1 - Интерактив", "2 - Положительный", "3 - отрицательный", "4 - Компьютер выберет число наугад" };
            for (int i = 0; i < way.Length; i++)
            {
                Console.WriteLine(way[i]);
            }
            int wayChoice = Convert.ToInt32(Console.ReadLine());
            switch (wayChoice)
            {
                case 1:
                    Algorythm(Convert.ToInt32(Console.ReadLine()), 0, 2);
                    break;

                case 2:
                    Algorythm(11, 0, 2);
                    break;

                case 3:
                    Algorythm(6, 0, 2);
                    break;

                case 4:
                    Random rnd = new Random();

                    Algorythm(rnd.Next(1, 100), 0, 2);
                    break;
            }
        }

        public static void Algorythm(int number, int d, int i)
        {                    
            d = 0;
            i = 2;

            Console.WriteLine("Было выбрано число: " + number + ".");

            if (i < number)
            {                
                while (i < number)
                {
                    if (number % i == 0)
                    {
                        d++;
                        i++;
                    }
                    else if (number % i != 0)
                    {
                        i++;
                    }
                }

                if (d == 0)
                {
                    Console.WriteLine("Число " + number + " - простое.");
                    RestOrEndApp();
                }
                else
                {
                    Console.WriteLine("Число " + number + " - не простое.");
                    RestOrEndApp();
                }
            }
            else
            {
                if (d == 0)
                {
                    Console.WriteLine("Число " + number + " - простое.");
                    RestOrEndApp();
                }
                else
                {
                    Console.WriteLine("Число " + number + " - не простое.");
                    RestOrEndApp();
                }
            }            
        }

        public static void RestOrEndApp()
        {
            Console.WriteLine("Желаете продолжить? Да/Нет");
            string choice_2 = Console.ReadLine();

            if (choice_2 == "Да" || choice_2 == "да")
            {
                TestCode();
            }
            else
            {
                Console.WriteLine("Завершение работы приложения...");
                Environment.Exit(0);
            }
        }
    }
}
