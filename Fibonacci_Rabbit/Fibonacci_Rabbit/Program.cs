
while (true)
{
    Console.WriteLine("Enter the number of months: ");
    int inputStr = Console.ReadLine().int();
 
    Fibonacci(inputStr);
}
int Fibonacci(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
