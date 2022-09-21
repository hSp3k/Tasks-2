using Task5.Source;
using Utility;


namespace Task5
{
    internal class Program
    {
        private static int _lengthArray = 10;
        private static int[] _randomRange = { -100, 50 };

        internal static void Main(string[] args)
        {
            int[] array = new int[_lengthArray];
            ArrayUtility.FillArray(ref array, _randomRange);
            ArrayUtility.WriteArray(array, "Массив : ");

            UtilityTask5.DeletingArrayElements(ref array);
            ArrayUtility.WriteArray(array, "Измененный Массив : ");
        }
    }
}