using Utility;
using Task1.Source;


namespace Task1
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            const int lengthArray = 10;
            int[] array = ArrayUtility.CreateArray(lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");

            Console.WriteLine($"Min значение : {UtilityTask1.GetMinValue(array)}");
            Console.WriteLine($"Max значение : {UtilityTask1.GetMaxValue(array)}");

            UtilityTask1.QuickSorting(array);
            ArrayUtility.WriteArray(array, "Отсортированный Массив : ");
        }
    }
}