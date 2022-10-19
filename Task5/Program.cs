using Task5.Source;
using Utility;


namespace Task5
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            const int lengthArray = 10;
            int[] array = ArrayUtility.CreateArray(lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");
            ArrayUtility.WriteArray(UtilityTask5.DeletingElements(array), "Измененный Массив : ");
        }
    }
}