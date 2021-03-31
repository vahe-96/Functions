using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Here is random Array");
            foreach (double i in NewArray(n))
            {
                Console.WriteLine(i);
            }
        }

        static double[] NewArray(int n)
        {
            double[] arr = new double[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.NextDouble();
            }

            return arr;
        }
    }
}
