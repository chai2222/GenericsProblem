

namespace PrintArray2
{
    public class Generics
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(".................................");
        }
    }
}
