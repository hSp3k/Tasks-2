using Task3.Source;
using Utility;


namespace Task3
{
    internal class Program
    {
        private const int _lengthArray = 10;

        internal static void Main(string[] args)
        {
            int[] array = ArrayUtility.CreateArray(_lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");
            Console.WriteLine($"Сумма : {UtilityTask3.SumPositive(array)}");
        }
    }
}