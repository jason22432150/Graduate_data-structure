using System;

namespace x_to_the_Y_power
{
    class Program
    {
        static int x_to_the_Y_power(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else
            {
                return x * x_to_the_Y_power(x, y - 1);
            }
        }

        static void Main()
        {
            while (true)
            {
                Console.Write("底數: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("次方: ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(x_to_the_Y_power(x, y));
            }
        }
    }
}
