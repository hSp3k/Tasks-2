using Task2.Source;


namespace Task2
{
    internal class Program
    {
        private const int _lengthArray1 = 5;
        private const int _lengthArray2 = 4;
        private const int _lengthArray3 = 3;

        internal static void Main(string[] args)
        {
            int[,,] array = UtilityTask2.CreateArray(_lengthArray1, _lengthArray2, _lengthArray3);
            UtilityTask2.WriteArray(array, "Массив : ");

            UtilityTask2.ReplacePositive(array);
            UtilityTask2.WriteArray(array, "Измененный Массив : ");
        }
    }
}