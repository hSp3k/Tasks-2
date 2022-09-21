using System;
using Task9.Source;
using Utility;


namespace Task9
{
    internal class Program
    {
        private static uint _lengthArray = 3;

        internal static void Main(string[] args)
        {
            int[] array1 = new int[_lengthArray];
            int[] array2 = new int[_lengthArray];

            UtilityTask9.FillInAnArrayFromTheKeyboard(ref array1, "Ввод массива '1' : ");
            UtilityTask9.FillInAnArrayFromTheKeyboard(ref array2, "Ввод массива '2' : ");

            ArrayUtility.WriteArray(array1, "Массив '1' : ");
            ArrayUtility.WriteArray(array2, "Массив '2' : ");
            
            if(UtilityTask9.CheckingForEqualityArrays(array1, array2) == true)
            {
                Console.WriteLine("Массивы Эквивалентны друг другу.");
                return;
            }
            Console.WriteLine("Массивы НЕ Эквивалентны друг другу.");
        }
    }
}