class Program
{
    public static int GCD(int a, int b)
    {
        if (a % b == 0)
            return (b);
        else
        {
            return (GCD(b, a % b));
        }
        //return -1;
    }

    static void Main()
    {
        Console.WriteLine("GCD(A, B)");
        Console.Write("A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("GCD({0}, {1}) = {2}", a, b, GCD(a, b));
    }
}
