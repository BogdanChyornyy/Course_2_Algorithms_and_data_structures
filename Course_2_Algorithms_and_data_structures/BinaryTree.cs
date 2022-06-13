using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_2_Algorithms_and_data_structures
{ 
    internal class BinaryTree
    {
        private string value;
        private int count;
        private BinaryTree left;
        private BinaryTree right;

        // Операция вставки.
        public void Insert(string value)
        {
            if (this.value == null)
                this.value = value;
            else
            {
                if (this.value.CompareTo(value) == 1)
                {
                    if (left == null)
                        this.left = new BinaryTree();
                    left.Insert(value);
                }
                else if (this.value.CompareTo(value) == -1)
                {
                    if (right == null)
                        this.right = new BinaryTree();
                    right.Insert(value);
                }
                else
                    throw new Exception("Узел уже существует");
            }

            this.count = Recount(this);
        }
        // Операция поиска.
        public BinaryTree Search(string value)
        {
            if (this.value == value)
                return this;
            else if (this.value.CompareTo(value) == 1)
            {
                if (left != null)
                    return this.left.Search(value);
                else
                    throw new Exception("Искомого узла в дереве нет");
            }
            else
            {
                if (right != null)
                    return this.right.Search(value);
                else
                    throw new Exception("Искомого узла в дереве нет");
            }
        }
        // Отображение в строку.
        public string Display(BinaryTree t)
        {
            string result = "";
            if (t.left != null)
                result += Display(t.left);

            result += t.value + " ";

            if (t.right != null)
                result += Display(t.right);

            return result;
        }
        // Подсчет.
        private int Recount(BinaryTree t)
        {
            int count = 0;

            if (t.left != null)
                count += Recount(t.left);

            count++;

            if (t.right != null)
                count += Recount(t.right);

            return count;
        }
        // Очистка.
        public void Clear()
        {
            this.value = null;
            this.left = null;
            this.right = null;
        }
        // Проверка пустоты.
        public bool IsEmpty()
        {
            if (this.value == null)
                return true;
            else
                return false;
        }

        public static void Example()
        {
            BinaryTree t = new BinaryTree();
            t.Insert("персик");
            t.Insert("черника");
            t.Insert("мандарин");
            t.Insert("груша");
            t.Insert("яблоко");
            t.Insert("клубника");

            Console.WriteLine(t.Display(t));
            BinaryTree s = t.Search("мандарин");
            Console.WriteLine(s.Display(s));
            Console.Read();
        }
    }
}
