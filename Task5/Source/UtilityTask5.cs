using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Task5.Source
{
    internal static class UtilityTask5
    {
        internal static int[] DeletingElements(int[] array)
        {
            int c = 0;
            int[] tempArray = new int[array.GetLength(0) - ArrayUtility.CountNegativeElements(array)];
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                if (array[iIndx] >= 0)
                {
                    tempArray[iIndx - c] = array[iIndx];
                    continue;
                }
                c++;
            }
            return tempArray;
        }
    }
}
