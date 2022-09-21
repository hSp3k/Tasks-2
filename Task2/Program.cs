using Task2.Source;


namespace Task2
{
    internal class Program
    {
        private static int[] _lengthArray = { 5, 3, 4 };
        private static int[] _randomRange = { -10, 50 };

        internal static void Main(string[] args)
        {
            int[,,] array = new int[_lengthArray[0], _lengthArray[1], _lengthArray[2]];
            UtilityTask2.FillArray(ref array, _randomRange);
            UtilityTask2.WriteArray(array, "Массив : ");

            UtilityTask2.EditArray(ref array);
            UtilityTask2.WriteArray(array, "Измененный Массив : ");
        }
    }
}