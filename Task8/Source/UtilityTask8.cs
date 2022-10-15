using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Source
{
    internal static class UtilityTask8
    {
        internal static void WriteNumberOfOccurrences(int[] array, int value)
        {
            foreach (var item in SearchNumberOfOccurrences(array, value))
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

        private static int[] SearchNumberOfOccurrences(int[] array, int value)
        {
            int pos = 0;
            int[] tempArray = new int[CountElements(array, value)];
            for (int iIndx = 0; iIndx < array.Length; iIndx++)
            {
                if (array[iIndx] == value)
                {
                    tempArray[pos] = iIndx;
                    pos++;
                }
            }
            return tempArray;
        }
        
        private static int CountElements(int[] array, int value)
        {
            int count = 0;
            foreach (var item in array)
            {
                if(item == value)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
