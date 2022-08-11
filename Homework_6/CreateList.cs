using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using OperatingInterface;

namespace HomeworkTasks
{
    public class CreateList
    {
        static List<IOperate> homeWorkList = new List<IOperate>();

        public static List<IOperate> CrtLst()
        {
            //Загружаем dll файл.
            Assembly asm = Assembly.LoadFrom("D:\\Projects\\Course_2_Algorithms_and_data_structures\\TaskLib\\bin\\Debug\\net6.0\\TaskLib.dll");

            Console.WriteLine(asm.FullName);
            
            //Создаем массив типов.
            Type[] types = asm.GetTypes();


            foreach (Type t in types)
            {
                string nameOfType = t.FullName.ToString();
                string[] desired = nameOfType.Split('.');

                foreach (var word in desired)
                {
                    if (word == "HomeworkTasks")
                    {
                        
                        Console.WriteLine(t.Name);
                        
                        //Создаем экземпляр типа.
                        homeWorkList.Add((IOperate)Activator.CreateInstance(t));
                    }
                }                
            }
            return homeWorkList;
        }
        public static void Run(int value)
        {
            homeWorkList[value].Run();
        }
    }
}
