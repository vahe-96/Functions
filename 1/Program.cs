using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number");
            int n = int.Parse(Console.ReadLine());

            if (IsEven(n))
            {
                Console.WriteLine($"{n} is even number");
            }
            else
            {
                Console.WriteLine($"{n} is odd number");
            }
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0 ? true : false;
        }
    }
}
