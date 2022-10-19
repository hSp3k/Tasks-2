using Task7.Source;
using Utility;


namespace Task7
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
            int[] array = UtilityTask7.CreateArray(lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");

            Array.Sort(array);
            Array.Reverse(array);
            ArrayUtility.WriteArray(array, "Отсортированный Массив : ");
        }
    }
}