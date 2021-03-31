using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 74, 5, 4, 25, 47, 9, 0, 6, 54 };

            Console.WriteLine($"The Greatest element is - {GreatestElement(arr)}");
        }

        static int GreatestElement(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
    }
}
