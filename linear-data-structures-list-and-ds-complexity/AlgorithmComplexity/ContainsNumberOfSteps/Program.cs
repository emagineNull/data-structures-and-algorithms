using System;
using System.Linq;

namespace ContainsNumberOfSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());

            Console.WriteLine(Contains(arr, element));
        }

        public static bool Contains(int[] array, int element) // n = 1000 steps: 4000 + 4
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
