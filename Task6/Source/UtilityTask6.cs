using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Task6.Source
{
    internal static class UtilityTask6
    {
        internal static int[] AddedingElements(int[] array)
        {
            int c = 0;
            int[] tempArray = new int[array.GetLength(0) + ArrayUtility.CountNegativeElements(array)];
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                if (array[iIndx] < 0)
                {
                    tempArray[iIndx + c++] = array[iIndx];
                    tempArray[iIndx + c] = array[iIndx];
                    continue;
                }
                tempArray[iIndx + c] = array[iIndx];
            }
            return tempArray;
        }

    }
}
