using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Source
{
    internal static class UtilityTask1
    {
        internal static int GetMinValue(int[] array, int min = int.MaxValue)
        {
            for (int indx = 0; indx < array.Length; indx++)
            {
                if (array[indx] < min)
                {
                    min = array[indx];
                }
            }
            return (min == int.MaxValue) ? min * -1 : min;
        }

        internal static int GetMaxValue(int[] array, int max = int.MinValue)
        {
            for (int indx = 0; indx < array.Length; indx++)
            {
                if (array[indx] > max)
                {
                    max = array[indx];
                }
            }
            return (max == int.MaxValue) ? max * -1 : max;
        }

        internal static void QuickSorting(ref int[] array, int leftIndx, int rightIndx)
        {
            var iIndx = leftIndx;
            var jIndx = rightIndx;
            var pivot = array[leftIndx];
            while (iIndx <= jIndx)
            {
                while (array[iIndx] < pivot)
                {
                    iIndx++;
                }

                while (array[jIndx] > pivot)
                {
                    jIndx--;
                }
                if (iIndx <= jIndx)
                {
                    int temp = array[iIndx];
                    array[iIndx] = array[jIndx];
                    array[jIndx] = temp;
                    iIndx++;
                    jIndx--;
                }
            }

            if (leftIndx < jIndx)
                QuickSorting(ref array, leftIndx, jIndx);
            if (iIndx < rightIndx)
                QuickSorting(ref array, iIndx, rightIndx);
        }
    }
}
