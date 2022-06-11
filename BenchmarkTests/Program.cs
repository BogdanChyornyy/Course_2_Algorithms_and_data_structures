using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkTests
{
    class Course_2_Algorithms_And_data_structures
    {
        
        static void Main()
        {

            //BenchmarkRunner.Run<Distance>();

            //Distance.PointDistance();
            //int try1 = 1000;
            //Distance.ArrayRefVal(try1);

            //int try2 = 1000;
            //Distance.ArrayRefVal(try2);

            Distance.ArrayRefVal(10);
            //Console.WriteLine("********************************");

            //Distance.ArrayRefVal(100);
        }
    }
}