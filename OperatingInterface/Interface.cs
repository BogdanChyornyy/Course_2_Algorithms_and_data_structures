using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingInterface
{
    public interface IOperate
    {
        /// <summary>
        /// 
        /// </summary>
        string name { get; }

        /// <summary>
        /// 
        /// </summary>
        string description { get; }

        /// <summary>
        /// 
        /// </summary>
        void Run();
    }
}