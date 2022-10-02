using Task7.Source;
using Utility;


namespace Task7
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
            int[] array = UtilityTask7.CreateArray(_lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");

            Array.Sort(array);
            Array.Reverse(array);
            ArrayUtility.WriteArray(array, "Отсортированный Массив : ");
        }
    }
}