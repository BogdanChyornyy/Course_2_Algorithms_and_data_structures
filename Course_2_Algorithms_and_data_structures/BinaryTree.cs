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

        public BinaryTree Node; // экземпляр класса "элемент дерева"
        public string s;
        // Операция вставки.
        public void Insert(string value)
        {
            if (this.value == null)
            {
                this.value = value;

            }

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
            t.Insert("малина");
            t.Insert("виноград");
            t.Insert("личи");
            t.Insert("апельсин");
            t.Insert("манго");
            //Console.WriteLine(t.Display(t));
            //BinaryTree s = t.Search("мандарин");
            //Console.WriteLine(s.Display(s));
            //Console.Read();
            string somestring = "";
            bool check = true;
            Across(t, ref somestring, check, "груша");
        }
        /// <summary>
        /// обход дерева в ширину
        /// </summary>
        /// <param name="node"></текущий "элемент дерева".>
        /// <param name="s"></строка, в которой накапливается результат.>
        /// <param name="stopWord"></искомое слово.>            
        private static void Across(BinaryTree node, ref string s, bool detailed, string stopWord)
        {
            var queue = new Queue<BinaryTree>(); // создать новую очередь

            if (detailed)
            {
                s += "    заносим в очередь значение " + node.value.ToString() + Environment.NewLine; queue.Enqueue(node); // поместить в очередь первый уровень                
            }

            while (queue.Count != 0) // пока очередь не пуста
            {
                //если у текущей ветви есть листья, их тоже добавить в очередь
                if (queue.Peek().left != null)
                {
                    if (detailed)
                    {
                        s += "    заносим в очередь значение *" + queue.Peek().left.value.ToString() + "* из левого поддерева" + Environment.NewLine;
                    }
                    queue.Enqueue(queue.Peek().left);
                }
                if (queue.Peek().right != null)
                {
                    if (detailed)
                    {
                        s += "    заносим в очередь значение *" + queue.Peek().right.value.ToString() + "* из правого поддерева" + Environment.NewLine;
                    }
                    queue.Enqueue(queue.Peek().right);
                }
                // извлечь из очереди информационное поле последнего элемента
                if (detailed)
                {
                    s += "    извлекаем значение из очереди: " + queue.Peek().value.ToString() + Environment.NewLine;

                    if (queue.Peek().value.ToString() == stopWord)
                    {
                        break;
                    }
                }

                else
                {
                    s += queue.Peek().value.ToString() + " "; // убрать последний элемент очереди
                }

                queue.Dequeue();
            }
            Console.WriteLine(s);
        }
    }
}
