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

            //    if (choice == "Bin")
            //{
            //    CreateList.Run(4);
            //}








            //Assembly asm = Assembly.LoadFrom("D:\\Projects\\Course_2_Algorithms_and_data_structures\\TaskLib\\bin\\Debug\\net6.0\\TaskLib.dll");

            //Console.WriteLine(asm.FullName);

            //Type[] types = asm.GetTypes();
            //int counter = 0;
            //foreach (Type t in types)
            //{
            //    Console.WriteLine(t.Name);
            //}


        }
    }
}
