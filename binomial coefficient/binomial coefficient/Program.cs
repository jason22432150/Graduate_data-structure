class Porgram
{
    public static int BinomialCofficiionrtRecursive(int n, int m)
    {
        Console.WriteLine(n + " " + m);
        if (m == 0 || n == m)
        {
            return 1;
        }
        else
        {
            return (BinomialCofficiionrtRecursive(n - 1, m) + BinomialCofficiionrtRecursive(n - 1, m - 1));
        }
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m : ");
            int m = int.Parse(Console.ReadLine());
            //Console.Write("Ans: ");
            Console.WriteLine(BinomialCofficiionrtRecursive(n, m));
            //System.Console.WriteLine("Hello World");
        }
    }
}