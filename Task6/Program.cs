using Task6.Source;
using Utility;


namespace Task6
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            const int lengthArray = 10;
            int[] array = ArrayUtility.CreateArray(lengthArray);
            ArrayUtility.WriteArray(array, "Массив : ");
            ArrayUtility.WriteArray(UtilityTask6.AddedingElements(array), "Измененный Массив : ");
        }
    }
}