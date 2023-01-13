namespace PrintArray2
{
    public class Priogarm
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, };
            double[] doubleArray = { 1.2, 2.1, 3.2, 4.4, 5.5, 6.3 };
            char[] charArray = { 'S', 'A', 'N', 'G', 'M', 'E', 'S', 'H' };

            Generics.toPrint<int>(intArray);
            Generics.toPrint<double>(doubleArray);
            Generics.toPrint<char>(charArray);
        }
    }
}