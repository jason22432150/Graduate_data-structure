class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input modes: ");
        int modes = int.Parse(Console.ReadLine());
        Console.Write("Input modes is: ");
        Console.WriteLine(modes);
        switch (modes)
        {
            case 1:
                ArrayQueueOne ArrayQueueOne = new ArrayQueueOne(7);
                ArrayQueueOne.EnQueue("1");
                ArrayQueueOne.EnQueue("2");
                ArrayQueueOne.EnQueue("3");
                ArrayQueueOne.EnQueue("4");
                ArrayQueueOne.EnQueue("5");
                ArrayQueueOne.EnQueue("6");
                //ArrayQueueOne.Display();
                ArrayQueueOne.DeQueue();
                ArrayQueueOne.DeQueue();
                //ArrayQueueOne.Display();
                // ArrayQueueOne.Display();
                // Console.WriteLine("Geted item is {0}", queue.get());
                // ArrayQueueOne.Display();
                // Console.ReadLine();
                break;
            case 2:
                ArrayQueueTwo ArrayQueueTwo = new ArrayQueueTwo(6);
                ArrayQueueTwo.EnQueue("1");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("2");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("3");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("4");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("5");
                ArrayQueueTwo.Display();
                //ArrayQueueTwo.EnQueue("6");
                ArrayQueueTwo.DeQueue();
                ArrayQueueTwo.Display();
                ArrayQueueTwo.DeQueue();
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("7");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("8");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("9");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("10");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("11");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.EnQueue("12");
                ArrayQueueTwo.Display();
                ArrayQueueTwo.Display();
                break;
            case 3:
                ArrayQueueThree ArrayQueueThree = new ArrayQueueThree(6);
                ArrayQueueThree.EnQueue("1");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("2");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("3");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("4");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("5");
                ArrayQueueThree.Display();
                //ArrayQueueTwo.EnQueue("6");
                ArrayQueueThree.DeQueue();
                ArrayQueueThree.Display();
                ArrayQueueThree.DeQueue();
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("7");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("8");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("9");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("10");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("11");
                ArrayQueueThree.Display();
                ArrayQueueThree.EnQueue("12");
                ArrayQueueThree.Display();
                ArrayQueueThree.Display();
                break;
        }
    }
}
//linear Array Queue One 1 ~ n
class ArrayQueueOne
{
    private string[] q;
    int front = 0;
    int rear;
    int n;
    public ArrayQueueOne(int size)
    {
        q = new string[size];
        int rear = front;
        n = q.Length;
    }
    public void EnQueue(string item)
    {
        //string item = item;
        if (rear == n)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {
            rear++;
            q[rear] = item;
            Console.WriteLine("Enqueue: " + item);
        }
        Console.WriteLine("rear= " + rear + " front= " + front);
    }
    public void DeQueue()
    {
        if (front == n)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            front++;
            Console.WriteLine("Dequeue: " + q[front]);
        }
        Console.WriteLine("rear= " + rear + " front= " + front);
    }
    public void Display()
    {
        for (int i = 0; i < q.Length; i++)
        {
            Console.WriteLine(q[i]);
        }
    }
}
//linear Array Queue Two 0 ~ n-1
class ArrayQueueTwo
{
    private string[] q;
    private int front = -1;
    private int rear = 0;
    private int n;
    public ArrayQueueTwo(int size)
    {
        q = new string[size];
        rear = front;
        n = q.Length;
    }
    public void EnQueue(string item)
    {

        Console.WriteLine("rear= " + rear);
        Console.WriteLine("front= " + front);
        Console.WriteLine();
        if (rear == front)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {
            rear = (rear + 1) % n;
            q[rear] = item;
            Console.WriteLine("Eequeue: " + item);
        }
    }
    public void DeQueue()
    {
        Console.WriteLine("rear= " + rear);
        Console.WriteLine("front= " + front);
        Console.WriteLine();
        if (front == rear)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            front = (front + 1) % n;
            string item = q[front];
            Console.WriteLine("Dequeue: " + item);
        }
    }
    public void Display()
    {
        for (int i = 0; i < q.Length; i++)
        {
            Console.Write(i + ": ");
            Console.WriteLine(q[i]);
        }
    }
}
//linear Array Queue Three 0 ~ n-1
class ArrayQueueThree
{
    private string[] q;
    private int front = 0, rear = 0;
    private bool tag = false;
    public ArrayQueueThree(int size)
    {
        q = new string[size];
    }
    public void EnQueue(string item)
    {
        Console.WriteLine();
        if (tag && front == rear)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {
            q[rear] = item;
            rear = (rear + 1) % q.Length;
            tag = true;
            Console.WriteLine("Enqueue: " + item);
            if (rear == front)
            {
                tag = true;
            }
        }
        Console.WriteLine("rear= " + rear + " front= " + front + " tag= " + tag);

    }
    public void DeQueue()
    {
        Console.WriteLine();
        if (tag && front == rear)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            string item = q[front];
            front = (front + 1) % q.Length;
            tag = false;
            Console.WriteLine("Dequeue: " + item);
            if (front == rear)
            {
                tag = false;
            }
        }
        Console.WriteLine("rear= " + rear + " front= " + front + " tag= " + tag);

    }
    public void Display()
    {
        for (int i = 0; i < q.Length; i++)
        {
            Console.Write(i + ": ");
            Console.WriteLine(q[i]);
        }
    }
}
class LinkedQueueOne
{
    private class Node
    {
        public string Data;
        public Node? next;
        public int? rear = null;
        public Node(string data)
        {
            Data = data;
            next = null;
        }
    }
    public void EnQueue(string item)
    {
        Node node = new Node(item);
        node.Data = item;
        node.link = null;
    }
}