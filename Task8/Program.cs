using Task8.Source;
using Utility;


namespace Task8
{
    internal class Program
    {
        private static uint _lengthArray = 10;
        private static int[] _randomRange = { 0, 11 };

        internal static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива : ");
            if (uint.TryParse(Console.ReadLine(), out _lengthArray))
            {
                int[] array = new int[_lengthArray];
                ArrayUtility.FillArray(ref array, _randomRange);
                ArrayUtility.WriteArray(array, "Массив : ");

                UtilityTask8.NumberOfOccurrences(array);
                return;
            }
            Console.WriteLine("Не верный ввод данных");
        }
    }
}