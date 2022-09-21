using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Task9.Source
{
    internal static class UtilityTask9
    {
        internal static bool CheckingForEqualityArrays(int[] array1, int[] array2)
        {
            int count = 0;
            for (int iIndx = 0; iIndx < array1.GetLength(0); iIndx++)
            {
                for (int jIndx = 0; jIndx < array2.GetLength(0); jIndx++)
                {
                    if (array1[iIndx] == array2[jIndx])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count == array1.GetLength(0);
        }

        public static void FillInAnArrayFromTheKeyboard(ref int[] array, string text = "")
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
                else if(ArrayUtility.FindElementInArray(array[indx], array[..indx]) == true)
                {
                    Console.WriteLine("\nТакое число уже существует в данном наборе\nПопробуйте еще раз.\n");
                    indx--;
                }
            }
        }
    }
}
