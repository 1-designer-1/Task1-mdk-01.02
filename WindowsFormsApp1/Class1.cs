using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class Class1
    {
        public double Task1(double numderTask1)
        {
            return Math.Atan(numderTask1 + 1) + Math.Exp(numderTask1 + 1) + Math.Log(numderTask1 * numderTask1 + 2);
        }

        public double Task2(double numberTask2)
        {
            double y = 10;
            return Math.Pow(Math.Log((y - Math.Sqrt(numberTask2)) * (numberTask2 - (y / (y + Math.Pow(numberTask2, 2))))), 0.5);

        }

        public int Task3(int numberTask3)
        {
            int n = 0;
            int s = 0;
            int sum;

            for (int i = 1; i < numberTask3; i++)
            {
                n += 2 + i;
                for (int j = 1; j < numberTask3; j += 2)
                {
                    s += (3 + j) / n;
                }

            }
            sum = 1 + s;

            return sum;
        }

        public List<int> Task4(int numeral)
        {
            List<int> arrayList = new List<int>();
            int[] array = new int[numeral];
            Random random = new Random();
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = random.Next(1, numeral);
                arrayList.Add((array[i] + Math.Abs(array[array.Length - 1 - i + 1])) / 4);
            }
            return arrayList;

        }

        /// <summary>
        /// Задания 5 Сформировать одномерный массив из суммы положительных элементов строк матрицы
        /// </summary>
        /// <param name="numberOneArray">Размер матрицы (i) </param>
        /// <param name="numberTwoArray">Размер матрицы (j)</param>
        /// <param name="sizeRandom">Размер диапазона заполнения матрицы случайными числами </param>
        /// <returns></returns>
        public List<int> Task5(int numberOneArray, int numberTwoArray, int sizeRandom)
        {
            List<int> arrayList = new List<int>();
            int[,] array = new int[numberOneArray, numberTwoArray];
            Random random = new Random();
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, sizeRandom);
                    if (array[i, j] > 0) sum += array[i, j];
                }
                arrayList.Add(sum);
            }
            return arrayList;



        }




    }
}
