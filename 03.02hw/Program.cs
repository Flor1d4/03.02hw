using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            Random rand = new Random();

            Console.WriteLine("Введите 5 элементов массива A через Enter:");
            for (int i = 0; i < 5; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Создание чисел массива B ->");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.Next(1, 10);
                }
            }

            Console.WriteLine("Массив A: " + string.Join(", ", A));

            Console.WriteLine("Массив В в матричнйо форме:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            int totVol = 3 * 4;
            int minimum = int.MaxValue;
            int totSum = 0;
            int totProd = 1;
            int evenCount = 0;
            int oddSum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] < minimum)
                    {
                        minimum = B[i, j];
                    }
                    totSum += B[i, j];
                    totProd *= B[i, j];
                }
            }

            foreach (int num in A)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        oddSum += B[i, j];
                    }
                }
            }

            Console.WriteLine("Общий объем массива B: " + totVol);
            Console.WriteLine("Минимальный элемент массива B: " + minimum);
            Console.WriteLine("Общая сумма всех элементов массива B: " + totSum);
            Console.WriteLine("Суммарный продукт всех элементов массива B: " + totProd);
            Console.WriteLine("Количество четных элементов в массиве A: " + evenCount);
            Console.WriteLine("Сумма нечетных столбцов массива B: " + oddSum);
            #endregion

        }
    }
}
