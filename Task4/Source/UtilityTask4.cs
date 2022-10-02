using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Source
{
    internal static class UtilityTask4
    {
        private const int _randomRangeStart = -10;
        private const int _randomRangeEnd = 50;

        internal static int[,] CreateArray(int _lengthArray1, int _lengthArray2)
        {
            int[,] array = new int[_lengthArray1, _lengthArray2];
            Random randomGenerator = new Random();
            for (int iIndx = 0; iIndx < _lengthArray1; iIndx++)
            {
                for (int jIndx = 0; jIndx < _lengthArray2; jIndx++)
                {
                    array[iIndx, jIndx] = randomGenerator.Next(_randomRangeStart, _randomRangeEnd);
                }
            }
            return array;
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

        internal static int SumEvenPositions(int[,] array)
        {
            int sum = 0;
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
