using System;
internal class Program
{
    private static void Main(string[] args)
    {
        static int FibonacciRecursive(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        static int FibonacciNoRecursive(int i)
        {
            if (i == 0) return 0;
            else if (i == 1) return 1;
            else
            {
                int a = 0, b = 1, c = 0;
                for (int j = 2; j <= i; j++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }

        }
        static int FibonacciArray(int i)
        {
            int[] arr = new int[i + 1];
            arr[0] = 0;
            arr[1] = 1;
            for (int j = 2; j <= i; j++)
            {
                arr[j] = arr[j - 1] + arr[j - 2];
            }
            return arr[i];
        }
        Console.WriteLine(FibonacciRecursive(2));
        Console.WriteLine(FibonacciNoRecursive(2));
        Console.WriteLine(FibonacciArray(2));
    }
}