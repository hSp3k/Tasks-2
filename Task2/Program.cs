using Task2.Source;


namespace Task2
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            const int lengthArray1 = 5;
            const int lengthArray2 = 4;
            const int lengthArray3 = 3;

            int[,,] array = UtilityTask2.CreateArray(lengthArray1, lengthArray2, lengthArray3);
            UtilityTask2.WriteArray(array, "Массив : ");

            UtilityTask2.ReplacePositive(array);
            UtilityTask2.WriteArray(array, "Измененный Массив : ");
        }
    }
}