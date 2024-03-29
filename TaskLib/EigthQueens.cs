﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsNS
{
    class EigthQueens
    {
        public static int queenCounter; // Счетчик вертикалей.
        public static int saveCounter; // Инициализатор корректной вертикали.
        public static int fillingChordX; // Координата заполнения Х.
        public static int fillingChordY; // Координата заполнения Y.
        public static int checkChordX; // Текущая координата Х.
        public static int checkChordY;// Текущая координата Y.
        public static int[,] array = new int[8, 8]; // Массив шахматной доски.
        public static int[] xChord = new int[8]; // Массив значений Х.
        public static int[] yChord = new int[8]; // Массив значений Y.

        public static void CreateArray(int firstItem, int secondItem)
        {
            checkChordX = firstItem;

            checkChordY = secondItem;

            if (array[checkChordX, checkChordY] == 0) //Проверка свободную "клетку".
            {
                array[checkChordX, checkChordY] = 1; // Установка ферзя (1).

                if (array[checkChordX, fillingChordY] == 1) // Проверка крайнего значения.
                {
                    fillingChordY++;
                }

                while (fillingChordY < 8 && fillingChordY >= 0) // Заполнение оси Х (9).
                {
                    array[checkChordX, fillingChordY] = 9;
                    fillingChordY++;

                    if (fillingChordY > 7)
                    {
                        fillingChordY = 0; // Обнуление оси после заполнения.
                        break;
                    }

                    if (array[checkChordX, fillingChordY] == 1)
                    {
                        fillingChordY++;

                        if (fillingChordY > 7)
                        {
                            fillingChordY = 0; // Обнуление оси после заполнения.
                            break;
                        }
                    }
                }

                if (array[fillingChordX, checkChordY] == 1)  // Проверка крайнего значения.
                {
                    fillingChordX++;
                }

                while (fillingChordX < 8 && fillingChordX >= 0) // Заполнение оси Y (9).
                {
                    array[fillingChordX, checkChordY] = 9;
                    fillingChordX++;

                    if (fillingChordX > 7)
                    {
                        fillingChordX = 0; // Обнуление оси после заполнения.
                        break;
                    }

                    if (array[fillingChordX, checkChordY] == 1)
                    {
                        fillingChordX++;

                        if (fillingChordX > 7)
                        {
                            fillingChordX = 0; // Обнуление оси после заполнения.
                            break;
                        }
                    }
                }

                if (array[fillingChordX, checkChordY] == 1 || array[checkChordX, fillingChordY] == 1) // Проверка крайнего значения.
                {
                    fillingChordX = checkChordX + 1;
                    fillingChordY = checkChordY + 1;

                    while (fillingChordX < 8 && fillingChordY < 8) // Заполнение диагонали вправо (9) при крайнем положении ферзя.
                    {
                        array[fillingChordX, fillingChordY] = 9;
                        fillingChordX++;
                        fillingChordY++;

                        if (fillingChordX > 7 || fillingChordY > 7)
                        {
                            break;
                        }
                    }

                    if (checkChordX == 0)
                    {
                        fillingChordX = checkChordX + 1;
                        fillingChordY = checkChordY - 1;

                        while (fillingChordY > 0) // Заполнение диагонали влево (9) при крайнем положении ферзя.
                        {
                            array[fillingChordX, fillingChordY] = 9;
                            fillingChordX++;
                            fillingChordY--;

                            if (fillingChordY == 0)
                            {
                                array[fillingChordX, fillingChordY] = 9;
                                fillingChordX = 0;
                                fillingChordY = 0;
                                break;
                            }
                        }
                    }

                    if (checkChordY == 0)
                    {
                        fillingChordY = checkChordY + 1;
                        fillingChordX = checkChordX - 1;

                        while (fillingChordX > 0) // Заполнение диагонали вверх (9) при крайнем положении ферзя.
                        {
                            array[fillingChordX, fillingChordY] = 9;
                            fillingChordX--;
                            fillingChordY++;

                            if (fillingChordX == 0)
                            {
                                array[fillingChordX, fillingChordY] = 9;
                                fillingChordX = 0;
                                fillingChordY = 0;
                                break;
                            }
                        }
                    }
                }

                if (checkChordX > 0 && checkChordY > 0) // Не крайнее положение.
                {
                    fillingChordX = checkChordX;
                    fillingChordY = checkChordY;

                    while (fillingChordX > 0 && fillingChordY > 0)
                    {
                        fillingChordX--;
                        fillingChordY--;
                    }

                    array[fillingChordX, fillingChordY] = 9;

                    while (fillingChordX < 8 && fillingChordY < 8) // Заполнение диагонали (9) при крайнем положении ферзя.
                    {
                        fillingChordX++;
                        fillingChordY++;

                        if (fillingChordX > 7 || fillingChordY > 7)
                        {
                            fillingChordX = 0;
                            fillingChordY = 0;
                            break;
                        }

                        if (array[fillingChordX, fillingChordY] == 1)
                        {
                            fillingChordX++;
                            fillingChordY++;

                            if (fillingChordX > 7 || fillingChordY > 7)
                            {
                                fillingChordX = 0;
                                fillingChordY = 0;
                                break;
                            }
                        }

                        array[fillingChordX, fillingChordY] = 9;
                    }

                    fillingChordX = checkChordX;
                    fillingChordY = checkChordY;

                    while (fillingChordY > 0 && fillingChordX != 7)
                    {
                        fillingChordX++;
                        fillingChordY--;
                    }

                    array[fillingChordX, fillingChordY] = 9;

                    while (fillingChordX < 8 && fillingChordY < 8) // Заполнение диагонали (9) при крайнем положении ферзя.
                    {
                        fillingChordX--;
                        fillingChordY++;

                        if (fillingChordX < 0 || fillingChordY > 7)
                        {
                            fillingChordX = 0;
                            fillingChordY = 0;
                            break;
                        }

                        if (array[fillingChordX, fillingChordY] == 1)
                        {
                            fillingChordX++;
                            fillingChordY++;

                            if (fillingChordX < 0 || fillingChordY > 7)
                            {
                                fillingChordX = 0;
                                fillingChordY = 0;
                                break;
                            }
                        }
                        array[fillingChordX, fillingChordY] = 9;
                    }
                }
                fillingChordX = fillingChordY = 0;

                saveArrayData(checkChordX, checkChordY, queenCounter);
                queenCounter++;
            }
        }
        /// <summary>
        /// Метод сохранения прошедших проверку координат.
        /// </summary>
        /// <param name="x"></param> Координата Х.
        /// <param name="y"></param> Координата Y.
        /// <param name="arrayCount"></param> Вертикаль координаты.
        public static void saveArrayData(int x, int y, int arrayCount)
        {
            xChord[arrayCount] = x;
            yChord[arrayCount] = y;
        }
    }
}
