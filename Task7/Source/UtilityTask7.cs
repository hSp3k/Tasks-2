using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Task7.Source
{
    internal static class UtilityTask7
    {
        internal static int[] CreateArray(int lengthArray)
        {
            int[] array = new int[lengthArray];
            for (int indx = 0; indx < array.Length; indx++)
            {
                Console.Write($"indx = {indx} >> element = ");
                if (int.TryParse(Console.ReadLine(), out array[indx]) == false)
                {
                    Console.WriteLine("\nНе верно введено число\nПопробуйте еще раз.\n");
                    indx--;
                }
            }
            Console.WriteLine();
            return array;
        }
    }
}
