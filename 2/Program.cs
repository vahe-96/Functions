using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 4, 25, 47, 9, 0, 6, 54 };

            InversedArray(arr);

            Console.WriteLine("Inversed Array");
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
            }

        }

        static void InversedArray(int[] a)
        {
            int temp;
            for (int i = 0; i < a.Length / 2; i++)
            {
                temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }
        }
    }
}
