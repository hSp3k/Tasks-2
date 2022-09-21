using Task7.Source;
using Utility;


namespace Task7
{
    internal class Program
    {
        private static uint _lengthArray;

        internal static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива : ");
            if (uint.TryParse(Console.ReadLine(), out _lengthArray))
            {
                int[] array = new int[_lengthArray];
                UtilityTask7.FillInAnArrayFromTheKeyboard(ref array, "Ввод массива : ");
                ArrayUtility.WriteArray(array, "Массив : ");

                UtilityTask7.BubbleSorting(ref array);
                ArrayUtility.WriteArray(array, "Отсортированный Массив : ");
                return;
            }
            Console.WriteLine("Не верный ввод данных");
        }
    }
}