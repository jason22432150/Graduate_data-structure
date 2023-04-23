class ackerman
{
    public static int recursion(int n, int m)
    {
        Console.WriteLine("ackerman(" + n + "," + m + ")");
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return recursion(m - 1, 1);
        else
            return recursion(m - 1, recursion(m, n - 1));
        //Thread.Sleep(100);
        Task.Delay(1000);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter m : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter n : ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(recursion(m,n));
            Console.ReadKey();
        }
    }
}
