
while (true)
{
    Console.WriteLine("Enter the number of months: ");
    int inputStr = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("inputStr: " + inputStr);
    Console.WriteLine(Fibonacci(inputStr));
}
int Recoursive(int input)
{
    return Fibonacci(input);
}
int Forloop(int input)
{
    long[] fib = new long[75];
    int i, n;
    fib[1] = 1;
    fib[2] = 1;
    if (input >= 3)
    {
        fib[3] = 1;
    }
    for (i = 3; i <= input; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return 0;
}
int Fibonacci(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
