using Utility;
using Task1.Source;


namespace Task1
{
    internal class Program
    {
        private static int _lengthArray = 10;
        private static int[] _randomRange = { -10, 50 };

        internal static void Main(string[] args)
        {
            int[] array = new int[_lengthArray];
            ArrayUtility.FillArray(ref array, _randomRange);
            ArrayUtility.WriteArray(array, "Массив : ");

            Console.WriteLine($"Min значение : {UtilityTask1.GetMinValue(array)}");
            Console.WriteLine($"Max значение : {UtilityTask1.GetMaxValue(array)}");

            UtilityTask1.QuickSorting(ref array, 0, _lengthArray - 1);
            ArrayUtility.WriteArray(array, "Отсортированный Массив : ");
        }
    }
}