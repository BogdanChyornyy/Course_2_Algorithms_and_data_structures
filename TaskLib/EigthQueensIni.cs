using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatingInterface;
using UtilsNS;

namespace HomeworkTasks
{
    internal class EigthQueensIni : IOperate
    {
        public string name => "8 ферзей";

        public string description => "необходимо расположить 8 ферзей на шахматной доске 8х8 так, чтобы ни один из них не атаковал друг друга и найти все возможные варианты расстановок.";

        static void Example()
        {
            ChordCorrecting.CreateArrayFirst(0, 0);
        }

        public void Run()
        {
            Example();
        }
    }
}
