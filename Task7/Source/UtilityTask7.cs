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
        internal static void BubbleSorting(ref int[] array)
        {
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                for (int jIndx = iIndx + 1; jIndx < array.GetLength(0); jIndx++)
                {
                    if (array[iIndx] < array[jIndx])
                    {
                        int tempVariable = array[iIndx];
                        array[iIndx] = array[jIndx];
                        array[jIndx] = tempVariable;
                    }
                }
            }
        }

        internal static void FillInAnArrayFromTheKeyboard(ref int[] array, string text = "")
        {
            Console.WriteLine(text);
            Random randomGenerator = new Random();
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
        }
    }
}
