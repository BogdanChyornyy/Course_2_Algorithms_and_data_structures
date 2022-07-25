using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatingInterface;
using UtilsNS;


namespace HomeworkTasks
{
    public class LinkedList : ILinkedList
    {
        public string name => "Связный список";

        public string description => "Необходимо реализовать связный список";
        public void Run()
        {
            Example();
        }

        public void Example()
        {
            DoublyLinkedList<string> DLL = new DoublyLinkedList<string>();
            // добавление элементов
            DLL.Add("Bob");
            DLL.Add("John");
            DLL.Add("Bill");
            DLL.Add("Kavin");
            DLL.Add("Nick");
            DLL.Add("Sam");
            DLL.Add("Tom");
            DLL.Add("Rick");
            DLL.AddFirst("Kate");

            Console.WriteLine("Список имен: ");
            foreach (var item in DLL)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Количество элементов текущего списка: " + DLL.Count);
            Console.WriteLine();

            // удаление элемента
            Console.WriteLine("Билл был удален");
            DLL.Remove("Bill");
            Console.WriteLine();

            // перебор с последнего элемента
            Console.WriteLine("Перебор с последнего элемента: ");
            foreach (var t in DLL.BackEnumerator())
            {
                Console.WriteLine(t);
            }

            Console.WriteLine();
            Console.WriteLine("Количество элементов текущего списка: " + DLL.Count);
        }
        // Метод возвращает количество элементов списка
        public int GetCount()
        {
            DoublyLinkedList<int> DLL = new DoublyLinkedList<int>();

            Example();
            return DLL.Count;
        }

        // Добавляет элемент в конец списка
        public void AddNode(string val)
        {
            DoublyLinkedList<string> DLL = new DoublyLinkedList<string>();

            Example();
            DLL.Add(val);

            Console.WriteLine("Перебор с последнего элемента: ");
            foreach (var t in DLL.BackEnumerator())
            {
                Console.WriteLine(t);
            }
        }
        // Добавляет элемент в начало списка
        public void AddNodeFirst(string val)
        {
            DoublyLinkedList<string> DLL = new DoublyLinkedList<string>();

            Example();
            DLL.AddFirst(val);

            Console.WriteLine("Перебор с последнего элемента: ");
            foreach (var t in DLL.BackEnumerator())
            {
                Console.WriteLine(t);
            }
        }       
    }
}