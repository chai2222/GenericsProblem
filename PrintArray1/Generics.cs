

namespace PrintArray1
{
    public class Generis
    {
        public static void toPrinrt(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("............................");
        }
        public static void toPrinrt(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("............................");
        }
        public static void toPrinrt(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("............................");
        }
    }
}

