﻿using System.Collections;
using System.Collections.Generic;
using HomeworkTasks;
using OperatingInterface;

namespace UtilsNS
{
    public interface ILinkedList : IOperate
    {
        void Example(); // Приводит пример, описывая инициализацию списка и работу с ним на консоли
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(string val); // добавляет новый элемент списка (добавит Джейка)
        void AddNodeFirst(string val);// добавляет новый элемент списка в начало (добавит Джейка)
    }

    public class LinkedList<T>
    {
        public LinkedList(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public LinkedList<T> Previous { get; set; }
        public LinkedList<T> Next { get; set; }
    }

    public class DoublyLinkedList<T> : IEnumerable<T>  // двусвязный список
    {
        LinkedList<T> head; // головной/первый элемент
        LinkedList<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(T data)
        {
            LinkedList<T> node = new LinkedList<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        public void AddFirst(T data)
        {
            LinkedList<T> node = new LinkedList<T>(data);
            LinkedList<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        // удаление
        public bool Remove(T data)
        {
            LinkedList<T> current = head;

            // поиск удаляемого узла
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                // если узел не последний
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    tail = current.Previous;
                }

                // если узел не первый
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    // если первый, переустанавливаем head
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            LinkedList<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            LinkedList<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            LinkedList<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}