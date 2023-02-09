using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();
          
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }          
            int min = int.MaxValue;
            int max = int.MinValue;
            int minIndexA = 0;
            int minIndexB = 0;
            int maxIndexA = 0;
            int maxIndexB = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minIndexA = i;
                        minIndexB = j;
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxIndexA = i;
                        maxIndexB = j;
                    }
                }
            }          
           int sum = 0;

            if (minIndexA < maxIndexA)
            {
                for (int i = minIndexA + 1; i < maxIndexA; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            else if (minIndexA > maxIndexA)
            {
                for (int i = maxIndexA + 1; i < minIndexA; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            else
            {
                int startIndex = Math.Min(minIndexB, maxIndexB) + 1;
                int endIndex = Math.Max(minIndexB, maxIndexB) - 1;
                for (int j = startIndex; j <= endIndex; j++)
                {
                    sum += arr[minIndexA, j];
                }
            }

            Console.WriteLine("Сумма элементов между min и max: " + sum);
        }
    }
}
