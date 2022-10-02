using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Source
{
    internal static class UtilityTask1
    {
        internal static int? GetMinValue(int[] array, int min = int.MaxValue)
        {
            for (int indx = 0; indx < array.Length; indx++)
            {
                if (array[indx] < min)
                {
                    min = array[indx];
                }
            }
            return (min == int.MaxValue) ? null : min;
        }

        internal static int? GetMaxValue(int[] array, int max = int.MinValue)
        {
            for (int indx = 0; indx < array.Length; indx++)
            {
                if (array[indx] > max)
                {
                    max = array[indx];
                }
            }
            return (max == int.MinValue) ? null : max;
        }

        internal static void QuickSorting(int[] array)
        {
            QuickSortinRecursion(array, 0, array.Length - 1);
        }
        private static void QuickSortinRecursion(int[] array, int leftIndx, int rightIndx)
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
            {
                QuickSortinRecursion(array, leftIndx, jIndx);
            }
            if (iIndx < rightIndx)
            {
                QuickSortinRecursion(array, iIndx, rightIndx);
            }
        }
    }
}
