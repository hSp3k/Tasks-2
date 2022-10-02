using Task4.Source;


namespace Task4
{
    internal class Program
    {
        private const int _lengthArray1 = 5;
        private const int _lengthArray2 = 5;

        internal static void Main(string[] args)
        {
            int[,] array = UtilityTask4.CreateArray(_lengthArray1, _lengthArray2);
            UtilityTask4.WriteArray(array, "Массив : ");
            Console.WriteLine($"Сумма : {UtilityTask4.SumEvenPositions(array)}");
        }
    }
}