using System;
using System.Linq;
using System.Reflection;
using HomeworkTasks;
using System.IO;
using OperatingInterface;


namespace Homework_6
{
    class Program
    {        
        static void Main(string[] args)
        {            
            var homeWorkList = CreateList.CrtLst();            

            foreach (IOperate lesson in homeWorkList)
            {
                Console.WriteLine($"Введите: {lesson.name}, для вызова задания, где {lesson.description}");              
            }

            Console.WriteLine("Введите название задания:");

            string choice = Console.ReadLine();

            foreach (IOperate lesson in homeWorkList)
            {
                if (lesson.name == choice)
                {
                    Console.Clear();
                    lesson.Run();
                }
            }
        }
    }
}
