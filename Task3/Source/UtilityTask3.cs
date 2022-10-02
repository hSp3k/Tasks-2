using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Source
{
    internal static class UtilityTask3
    {
        internal static uint SumPositive(int[] array)
        {
            uint sum = 0;
            for (int indx = 0; indx < array.Length; indx++)
            {
                if (array[indx] > 0)
                {
                    sum += (uint)array[indx];
                }
            }
            return sum;
        }
    }
}
