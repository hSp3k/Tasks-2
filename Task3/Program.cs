using Task3.Source;
using Utility;


namespace Task3
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            const int lengthArray = 10;
            int[] array = ArrayUtility.CreateArray(lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");
            Console.WriteLine($"Сумма : {UtilityTask3.SumPositive(array)}");
        }
    }
}