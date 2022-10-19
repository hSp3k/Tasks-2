using Task4.Source;


namespace Task4
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            const int lengthArray1 = 5;
            const int lengthArray2 = 5;
            int[,] array = UtilityTask4.CreateArray(lengthArray1, lengthArray2);
            UtilityTask4.WriteArray(array, "Массив : ");
            Console.WriteLine($"Сумма : {UtilityTask4.SumEvenPositions(array)}");
        }
    }
}