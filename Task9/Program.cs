using System;
using Task9.Source;
using Utility;


namespace Task9
{
    internal class Program
    {
        private const int _lengthArray = 3;

        internal static void Main(string[] args)
        {
            int[] array1 = UtilityTask9.CreateArray(_lengthArray);
            int[] array2 = UtilityTask9.CreateArray(_lengthArray);

            ArrayUtility.WriteArray(array1, "Массив '1' : ");
            ArrayUtility.WriteArray(array2, "Массив '2' : ");

            Array.Sort(array1);
            Array.Sort(array2);

            if (array1 == array2)
            {
                Console.WriteLine("Массивы Эквивалентны друг другу.");
                return;
            }
            Console.WriteLine("Массивы НЕ Эквивалентны друг другу.");
        }
    }
}