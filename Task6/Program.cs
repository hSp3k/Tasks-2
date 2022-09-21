using Task6.Source;
using Utility;


namespace Task6
{
    internal class Program
    {
        private static int _lengthArray = 10;
        private static int[] _randomRange = { -75, 50 };

        internal static void Main(string[] args)
        {
            int[] array = new int[_lengthArray];
            ArrayUtility.FillArray(ref array, _randomRange);
            ArrayUtility.WriteArray(array, "Массив : ");

            UtilityTask6.AddedingArrayElements(ref array);
            ArrayUtility.WriteArray(array, "Измененный Массив : ");
        }
    }
}