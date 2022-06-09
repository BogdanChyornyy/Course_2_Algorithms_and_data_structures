using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkTests
{
    public class DistanceClass
    {
        public double X = 0;
        public double Y = 0;        
    }
    public struct DistanceStruct
    {
        public double X = 0;
        public double Y = 0;
    }
    [MemoryDiagnoser]
    public class Distance
    {
        [Benchmark]
        public void ArrayRefVal1000()
        {
            Distance.ArrayRefVal(100);
        }
        [Benchmark]
        public void ArrayRefVal1000000()
        {
            Distance.ArrayRefVal(500);
        }


        // Создаем метод, возвращающий расстояние между парой точек каждого типа.
        public static void PointDistance()
        {
            var pointOne = new DistanceClass { X = 12.4321, Y = 16.6546 };
            var pointTwo = new DistanceClass { X = 9.4321, Y = 11.6546 };
            var pointThree = new DistanceStruct { X = 22.2345, Y = 17.6839 };
            var pointFour = new DistanceStruct { X = 2.5332, Y = 198.242 };

            Console.WriteLine(PointDistanceRef(pointOne, pointTwo));
            Console.WriteLine(PointDistanceVal(pointThree, pointFour));
        }

        // Создаем метод, возвращающий расстояние между парой точек ссылочного типа.
        public static double PointDistanceRef(DistanceClass pointOne, DistanceClass pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        // Создаем метод, возвращающий расстояние между парой точек значимого типа.
        public static double PointDistanceVal(DistanceStruct pointThree, DistanceStruct pointFour)
        {
            double x = pointThree.X - pointFour.X;
            double y = pointThree.Y - pointFour.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        // Реализуем метод, создающий массив точек каждого типа и заполняющий его случайными значениями. 
        public static void ArrayRefVal(int quantity)
        {
            DistanceClass distanceClass = new DistanceClass();
            DistanceStruct distanceStruct = new DistanceStruct();

            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;

            double[,] arrayOfPoint = new double[quantity, 5];
            for (int i = 0; i < quantity; i++)
            {
                Random rndType1 = new Random();
                for (int j = 0; j < 5; j++)
                {
                    
                    int choice = rndType1.Next(1, 2);

                    // Заполнение ссылочным типом.
                    if (choice == 1)
                    {
                        Random rnd = new Random();
                        switch (j)
                        {
                            // Заполнение Х.
                            case 0:
                                x1 = distanceClass.X = rnd.Next(10, 99);
                                arrayOfPoint[i, j] = distanceClass.X;                                
                                break;

                            // Заполнение Y.
                            case 1:
                                y1 = distanceClass.Y = rnd.Next(10, 99);
                                arrayOfPoint[i, j] = distanceClass.Y;

                                break;

                            case 2:         
                                x2 = distanceClass.X = rnd.Next(10, 99);
                                arrayOfPoint[i, j] = distanceClass.X;
                                break;

                            case 3:
                                y2 = distanceClass.Y = rnd.Next(10, 99);
                                arrayOfPoint[i, j] = distanceClass.Y;
                                break;
                            // Заполнение данных о расстоянии.
                            case 4:
                                var pointTwo = new DistanceClass { X = x1, Y = y1 };
                                var pointOne = new DistanceClass { X = x2, Y = y2 };
                                arrayOfPoint[i, j] = PointDistanceRef(pointOne, pointTwo);
                                break;
                        }
                    }
                    // Заполнение значимым типом.
                    if (choice == 2)
                    {
                        Random rnd = new Random();
                        switch (j)
                        {
                            // Заполнение Х.
                            case 0:
                                x1 = distanceStruct.X = rnd.Next(10, 99);
                                arrayOfPoint[i, j] = distanceStruct.X;
                                break;

                            // Заполнение Y.
                            case 1:
                                y1 = distanceStruct.Y = rnd.Next(10, 99);
                                arrayOfPoint[i, j] = distanceStruct.Y;

                                break;

                            case 2:
                                x2 = distanceStruct.X = rnd.Next(10, 99);
                                arrayOfPoint[i, j] = distanceStruct.X;
                                break;

                            case 3:
                                y2 = distanceStruct.Y = rnd.Next(10, 99);
                                arrayOfPoint[i, j] = distanceStruct.Y;
                                break;
                            // Заполнение данных о расстоянии.
                            case 4:
                                var pointTwo = new DistanceStruct { X = x1, Y = y1 };
                                var pointOne = new DistanceStruct { X = x2, Y = y2 };
                                arrayOfPoint[i, j] = PointDistanceVal(pointOne, pointTwo);
                                break;
                        }                        
                    }
                    Console.Write(arrayOfPoint[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
