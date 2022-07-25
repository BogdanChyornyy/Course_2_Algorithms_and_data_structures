using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatingInterface;

namespace HomeworkTasks
{
    internal class NewHomeworkTask : IOperate
    {
        public string name => "Пробное задание";

        public string description => "необходимо создать новое дз и увидеть, будет ли оно работать";

        public void Calculator()
        {
            Console.WriteLine("Введите первое слагаемое: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ответ: " + (a + b));
        }

        public void Run()
        {
            Calculator();
        }
    }
}
