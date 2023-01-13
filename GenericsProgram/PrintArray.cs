

namespace GenericsProgram
{
    public class PrintArray<T>
    {
        private T[] inputArray;
        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toPrint()
        {
            //Console.WriteLine(this.inputArray);
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(".....................................");
        }
    }

}
