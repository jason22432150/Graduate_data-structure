using System;

class Factorial
{
    public static int Recursive(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Recursive(n - 1);
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a number for factorial: ");
            int input = int.Parse(Console.ReadLine());
            // Console.WriteLine(input);
            Console.WriteLine("{0}! = " + Recursive(input), input);
        }
    }
}
