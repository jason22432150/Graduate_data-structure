class Stack
{
    private int[] stack;
    private int top;
    private int size;
    public Stack(int size)
    {
        this.size = size;
        stack = new int[size];
        top = -1;
    }
    public void Push(int item)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {
            top++;
            stack[top] = item;
        }
    }
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            int item = stack[top];
            top--;
            return item;
        }
    }
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack(5);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        stack.Push(60);
        stack.Display();
        Console.WriteLine("Poped item is {0}", stack.Pop());
        stack.Display();
        Console.ReadLine();
    }
}