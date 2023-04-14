
while (true)
{
    Console.WriteLine("Enter the number of Mode (1.Rescoursive  2.For): ");
    int inputMode = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input Mode is : " + inputMode);
    Console.WriteLine("Please input the input data: ");
    int inputStr = Convert.ToInt32(Console.ReadLine());
    if (inputMode == 1)
    {
        Console.WriteLine(Recoursive(inputStr));
    }
    else if (inputMode == 2)
    {
        Console.WriteLine(Forloop(inputStr));
    }
    else
    {
        Console.WriteLine("Please input the correct mode");
    }
    //Console.WriteLine(Fibonacci(inputStr));
}
int Recoursive(int input)
{
    return Fibonacci(input);
}
int Forloop(int input)
{
    int[] fib = new int[input + 1];
    int i, n;
    fib[1] = 1;
    fib[2] = 1;
    for (i = 3; i <= input; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib[input];
}
int Fibonacci(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
