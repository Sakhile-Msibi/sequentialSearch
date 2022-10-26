using System;

namespace sequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 31, 41, 59, 26, 41, 58 };
            Console.WriteLine(sequentialSearch(A, 59));
        }

        public static int sequentialSearch(int[] numbers, int K)
        {
            int i = 0;
            int n = numbers.Length;
            while (i < n && numbers[i] != K)
            {
                i++;
            }
            if (i < n)
                return i;
            else
                return -1;
        }
    }
}
