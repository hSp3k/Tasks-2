using Task4.Source;


namespace Task4
{
    internal class Program
    {
        private static int[] _lengthArray = { 5, 5 };
        private static int[] _randomRange = { -10, 50 };

        internal static void Main(string[] args)
        {
            int[,] array = new int[_lengthArray[0], _lengthArray[1]];
            UtilityTask4.FillArray(ref array, _randomRange);
            UtilityTask4.WriteArray(array, "Массив : ");
            Console.WriteLine($"Сумма : {UtilityTask4.SumOfTheArrayElements(array)}");
        }
    }
}