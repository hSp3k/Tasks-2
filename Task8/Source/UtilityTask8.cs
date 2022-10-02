using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Source
{
    internal static class UtilityTask8
    {
        internal static void NumberOfOccurrences(int[] array)
        {
            int iIndx = -1;
            for (int value = 0; value < 11; value++)
            {
                Console.Write(value + " : ");
                do
                {
                    iIndx = Array.IndexOf(array, value, iIndx + 1);
                    if(iIndx != -1)
                    {
                        Console.Write(iIndx + " ");
                    }
                } while (iIndx != -1);
                Console.WriteLine();
            }
        }
    }
}
