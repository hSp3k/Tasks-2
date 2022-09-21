using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Source
{
    internal static class UtilityTask8
    {
        internal static void NumberOfOccurrences(int[] array)
        {
            int[] arrayOfQuantities = new int[11];
            int[] arrayOfOccurrences = new int[11];
            for (int iIndx = 0; iIndx < arrayOfOccurrences.GetLength(0); iIndx++)
            {
                arrayOfOccurrences[iIndx] = iIndx;
            }

            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                arrayOfQuantities[array[iIndx]]++;
            }

            for (int iIndx = 0; iIndx < arrayOfQuantities.GetLength(0); iIndx++)
            {
                Console.WriteLine($"{iIndx} : {arrayOfQuantities[iIndx]}");
            }
        }
    }
}
