using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Source
{
    internal static class UtilityTask4
    {
        internal static void FillArray(ref int[,] array, int[] randomRange)
        {
            Random randomGenerator = new Random();
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                for (int jIndx = 0; jIndx < array.GetLength(1); jIndx++)
                {
                    array[iIndx, jIndx] = randomGenerator.Next(randomRange[0], randomRange[1]);
                }
            }
        }

        internal static void WriteArray(int[,] array, string text = "")
        {
            Console.WriteLine(text + "{ ");
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                Console.Write(" { ");
                for (int jIndx = 0; jIndx < array.GetLength(1); jIndx++)
                {
                    Console.Write(array[iIndx, jIndx] + ", ");
                }
                Console.WriteLine(" } ");
            }
            Console.WriteLine("} ");
        }

        internal static int SumOfTheArrayElements(int[,] array, int sum = 0)
        {
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                for (int jIndx = 0; jIndx < array.GetLength(1); jIndx++)
                {
                    if((iIndx + jIndx) % 2 == 0)
                    {
                        sum += array[iIndx, jIndx];
                    }
                }
            }
            return sum;
        }
    }
}
