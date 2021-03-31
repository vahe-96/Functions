using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[] { 174, 5, 4, 25, 147, 9, 20, 6, };
                int n = 10;

                Console.WriteLine($"New arrays is");

                Product_x(arr, n);

                foreach (int i in arr)
                {
                    Console.Write($"{i}\t");
                }
            }

            static void Product_x(int[] a, int x)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] *= x;
                }
            }
        }
    }
}
