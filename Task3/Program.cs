using Task3.Source;
using Utility;


namespace Task3
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
            Console.WriteLine($"Сумма : {UtilityTask3.SumOfTheArrayElements(array)}");
        }
    }
}