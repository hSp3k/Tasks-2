using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Source
{
    internal static class UtilityTask6
    {
        internal static void AddedingArrayElements(ref int[] array)
        {
            int length = array.Length;
            for (int iIndx = 0; iIndx < length; iIndx++)
            {
                if (array[iIndx] < 0)
                {
                    int[] tempArray = new int[++length];
                    for (int jIndx = 0; jIndx < iIndx + 1; jIndx++)
                    {
                        tempArray[jIndx] = array[jIndx];
                    }
                    tempArray[iIndx + 1] = tempArray[iIndx];
                    for (int jIndx = iIndx; jIndx < length - 1; jIndx++)
                    {
                        tempArray[jIndx + 1] = array[jIndx];
                    }
                    array = tempArray;
                    iIndx++;
                }
            }
        }

    }
}
