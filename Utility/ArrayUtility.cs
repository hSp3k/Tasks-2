

namespace Utility
{
    public static class ArrayUtility
    {
        public static void FillArray(ref int[] array, int[] randomRange)
        {
            Random randomGenerator = new Random();
            for (int indx = 0; indx < array.Length; indx++)
            {
                array[indx] = randomGenerator.Next(randomRange[0], randomRange[1]);
            }
        }

        public static void WriteArray(int[] array, string text = "")
        {
            Console.Write(text + "{ ");
            for (int indx = 0; indx < array.Length; indx++)
            {
                Console.Write(array[indx] + ", ");
            }
            Console.WriteLine("}");
        }

        public static bool FindElementInArray(int value, int[] array)
        {
            for (int indx = 0; indx < array.Length; indx++)
            {
                if (array[indx] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}