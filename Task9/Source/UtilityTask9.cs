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
        public static int[] CreateArray(int lengthArray)
        {
            int[] array = new int[lengthArray];
            int element;
            Random randomGenerator = new Random();
            for (int indx = 0; indx < lengthArray; indx++)
            {
                Console.Write($"indx = {indx}, element = ");
                if(int.TryParse(Console.ReadLine(), out element) == false)
                {
                    Console.WriteLine("\nВходные данные имели не подходящий символ.");
                    Console.WriteLine("Попробуйте еще раз...\n");
                    indx--;
                    continue;
                }
            }
            return array;
        }
    }
}
