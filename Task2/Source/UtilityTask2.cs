using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Source
{
    internal static class UtilityTask2
    {
        private const int _randomRangeStart = -10;
        private const int _randomRangeEnd = 50;

        internal static int[,,] CreateArray(int _lengthArray1, int _lengthArray2, int _lengthArray3)
        {
            int[,,] array = new int[_lengthArray1, _lengthArray2, _lengthArray3];
            Random randomGenerator = new Random();
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                for (int jIndx = 0; jIndx < array.GetLength(1); jIndx++)
                {
                    for (int kIndx = 0; kIndx < array.GetLength(2); kIndx++)
                    {
                        array[iIndx, jIndx, kIndx] = randomGenerator.Next(_randomRangeStart, _randomRangeEnd);
                    }
                }
            }
            return array;
        }

        internal static void WriteArray(int[,,] array, string text = "")
        {
            Console.WriteLine(text + "\n{ ");
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                Console.Write(" { ");
                for (int jIndx = 0; jIndx < array.GetLength(1); jIndx++)
                {
                    Console.Write(" { ");
                    for (int kIndx = 0; kIndx < array.GetLength(2); kIndx++)
                    {
                        Console.Write(array[iIndx, jIndx, kIndx] + ", ");
                    }
                    Console.Write(" }");
                }
                Console.WriteLine(" } ");
            }
            Console.WriteLine("} ");
        }

        internal static void ReplacePositive(int[,,] array)
        {
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                for (int jIndx = 0; jIndx < array.GetLength(1); jIndx++)
                {
                    for (int kIndx = 0; kIndx < array.GetLength(2); kIndx++)
                    {
                        if (array[iIndx, jIndx, kIndx] > 0)
                        {
                            array[iIndx, jIndx, kIndx] = 0;
                        }
                    }
                }
            }
        }
    }
}
