using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Source
{
    internal static class UtilityTask5
    {
        internal static void DeletingArrayElements(ref int[] array)
        {
            int length = array.Length;
            for (int iIndx = 0; iIndx < length; iIndx++)
            {
                if (array[iIndx] < 0)
                {
                    for (int jIndx = iIndx; jIndx < length - 1; jIndx++)
                    {
                        array[jIndx] = array[jIndx + 1];
                    }
                    length--;
                    iIndx--;
                }
            }
            array = array[..length];
        }
    }
}
