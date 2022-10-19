using Task8.Source;
using Utility;


namespace Task8
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int lengthArray;
            Console.Write("Введите количество элементов массива : ");
            if (int.TryParse(Console.ReadLine(), out lengthArray) == false)
            {
                Console.WriteLine("Входные данные имели не подходящий символ.");
                return;
            }
            if (lengthArray < 0)
            {
                Console.WriteLine("Длина не может быть меньше нуля.");
                return;
            }
            int[] array = ArrayUtility.CreateArray(lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");

            Console.Write("Ввежите элемент, который хотите найти: ");
            if(int.TryParse(Console.ReadLine(), out int value))
            {
                UtilityTask8.WriteNumberOfOccurrences(array, value);
            }
            else
            {
                Console.WriteLine("Не верный формат данных.");
            }
        }
    }
}