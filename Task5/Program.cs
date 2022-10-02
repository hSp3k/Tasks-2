using Task5.Source;
using Utility;


namespace Task5
{
    internal class Program
    {
        private const int _lengthArray = 10;

        internal static void Main(string[] args)
        {
            int[] array = ArrayUtility.CreateArray(_lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");
            ArrayUtility.WriteArray(UtilityTask5.DeletingElements(array), "Измененный Массив : ");
        }
    }
}