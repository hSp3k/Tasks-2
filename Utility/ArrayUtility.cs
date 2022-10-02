

namespace Utility
{
    public static class ArrayUtility
    {
        private const int _randomRangeStart = 0;
        private const int _randomRangeEnd = 11;

        public static int[] CreateArray(int lengthArray)
        {
            int[] array = new int[lengthArray];
            Random randomGenerator = new Random();
            for (int indx = 0; indx < lengthArray; indx++)
            {
                array[indx] = randomGenerator.Next(_randomRangeStart, _randomRangeEnd);
            }
            return array;
        }

        public static int CountNegativeElements(int[] array)
        {
            int count = 0;
            for (int iIndx = 0; iIndx < array.GetLength(0); iIndx++)
            {
                if (array[iIndx] < 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void WriteArray(int[] array, string text = "")
        {
            Console.Write(text + "{ ");
            for (int indx = 0; indx < array.Length; indx++)
            {
                Console.Write(array[indx] + ", ");
            }
            Console.WriteLine('}');
        }
    }
}