using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 174, 5, 4, 25, 147, 9, 20, 6, 54, 15, 45 };
            int[] arr2 = new int[] { 12, -5, 10, 54, 12, 56, 45, 1, 25, 5, 0, 5, 4 };


            Console.WriteLine($"Sum of two arrays is");

            foreach (int i in SumArray(arr1, arr2))
            {
                Console.Write($"{i}\t");
            }
        }

        static int[] SumArray(int[] a, int[] b)
        {
            int[] c = new int[(a.Length <= b.Length) ? a.Length : b.Length];   // hashvi arats, ete tarber chaperi zangvacner en
                                                                               // ete pahanjum enq nuyn chapi, apa uxxaki [a.Length]
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = a[i] + b[i];
            }

            return c;
        }
    }
}
