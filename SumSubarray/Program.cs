using System;

namespace SumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input is N spaced-separated integers
            string[] numbers_temp = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(numbers_temp, Int32.Parse);

            SplitArray sa = new SplitArray();
            Console.WriteLine(sa.isSumEqual(numbers));
            Console.ReadKey();
        }
    }
}
