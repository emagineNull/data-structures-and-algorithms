using System;
using System.Linq;

namespace GetSumNumberOfSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(GetSumEven(arr));
        }

        public static int GetSumEven(int[] array) // Solution T(n) = 9n + 3
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            } // Counting maximum steps is called worst-case analysis

            return sum;
        }
    }
}
