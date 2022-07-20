using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Course_2_Algorithms_and_data_structures;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IInterface> tasks = new List<IInterface>()
            {
                new SimpNum(),                
                new Recursion(),
                new LinkedList(),
                new Distance(),
                new BinaryTree()
            };
            foreach(IInterface lesson in tasks)
            {
                Console.WriteLine($"Введите '{lesson.name}' для вызова задания, где: '{lesson.description}'");
            }
            string taskName = Console.ReadLine();
            foreach (IInterface lesson in tasks)
            {
                if (lesson.name == taskName)
                {
                    Console.Clear();
                    lesson.Run();
                }
            }                              
        }
    }
}