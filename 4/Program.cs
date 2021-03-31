using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 174, 5, 4, 25, 147, 9, 0, 6, 54 };

            Console.WriteLine($"Index of the Greatest element is - {GreatestIndex(arr)}");
        }

        static int GreatestIndex(int[] a)
        {
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > a[index])
                    index = i;
            }
            return index;
        }
    }
}
