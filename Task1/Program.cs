using Utility;
using Task1.Source;


namespace Task1
{
    internal class Program
    {
        private const int _lengthArray = 10;

        internal static void Main(string[] args)
        {
            int[] array = ArrayUtility.CreateArray(_lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");

            Console.WriteLine($"Min значение : {UtilityTask1.GetMinValue(array)}");
            Console.WriteLine($"Max значение : {UtilityTask1.GetMaxValue(array)}");

            UtilityTask1.QuickSorting(array);
            ArrayUtility.WriteArray(array, "Отсортированный Массив : ");
        }
    }
}