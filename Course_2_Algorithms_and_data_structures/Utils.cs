using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_2_Algorithms_and_data_structures
{
    public interface ILinkedList
    {
        void Example();
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(string val); // добавляет новый элемент списка (добавит Джейка)
        void AddNodeFirst(string val);// добавляет новый элемент списка в начало (добавит Джейка)
        //        void AddNodeAfter(Node node, int value); // добавляет новый элемент
        //        списка после определённого элемента
        //void RemoveNode(int index); // удаляет элемент по порядковому номеру
        //        void RemoveNode(Node node); // удаляет указанный элемент
        //        Node F


    }
    internal class Utils
    {        
        public static void TaskChoiser()
        {
            Console.WriteLine("Выберите задание...");
            string[] somearr = { "1 - Простое число.", "2 - Число Фибоначчи.", "3 - Реализация списка." };

            for (int i = 0; i < somearr.Length; i++)
            {
                Console.WriteLine(somearr[i]);
            }
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                SimpNum.TestCode();
            }
            if (choice == 2)
            {
                Console.Clear();
                recursion.Launcher();
            }
            if (choice == 3)
            {
                Console.Clear();

                ILinkedList linkedListInt = new LinkedList();

                linkedListInt.Example();                
            }
        }
    }
}
