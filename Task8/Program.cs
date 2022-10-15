using Task8.Source;
using Utility;


namespace Task8
{
    internal class Program
    {
        private static int _lengthArray;

        internal static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива : ");
            if (int.TryParse(Console.ReadLine(), out _lengthArray) == false)
            {
                Console.WriteLine("Входные данные имели не подходящий символ.");
                return;
            }
            if (_lengthArray < 0)
            {
                Console.WriteLine("Длина не может быть меньше нуля.");
                return;
            }
            int[] array = ArrayUtility.CreateArray(_lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");

            Console.Write("Ввежите элемент, который хотите найти: ");
            if(int.TryParse(Console.ReadLine(), out int value))
            {
                UtilityTask8.WriteNumberOfOccurrences(array, value);
            }
        }
    }
}