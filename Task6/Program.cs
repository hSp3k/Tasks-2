using Task6.Source;
using Utility;


namespace Task6
{
    internal class Program
    {
        private const int _lengthArray = 10;

        internal static void Main(string[] args)
        {
            int[] array = ArrayUtility.CreateArray(_lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");
            ArrayUtility.WriteArray(UtilityTask6.AddedingElements(array), "Измененный Массив : ");
        }
    }
}