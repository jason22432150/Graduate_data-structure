class Queue
{
    private int[] q; // this array holds the queue
    private int putloc, getloc; // the put and get indices
    public Queue(int size)
    {
        q = new int[size]; // allocate memory for queue
        putloc = getloc = 0;
    }
    public void put(int ch)
    {
        if (putloc == q.Length)
        {
            Console.WriteLine(" -- Queue is full.");
            return;
        }
        q[putloc++] = ch;
    }
    public int get()
    {
        if (getloc == putloc)
        {
            Console.WriteLine(" -- Queue is empty.");
            return (int)0;
        }
        return q[getloc++];
    }
    public void Display()
    {
        for (int i = 0; i < q.Length; i++)
        {
            Console.WriteLine(q[i]);
        }
    }
}
//Queue Link List
//class LinkQueue
//{
//    private int data;
//    private int next;
//    private int front;
//    private int rear;
//    private void enqueue(int data)
//    {
//        if (front == 0)
//        {
//            front = data;
//            rear = front;
//        }
//        else
//        {
//this.rear.next
//        }
//    }
//}
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
            case (1):
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
        }
        //Queue queue = new Queue(5);
        //queue.put(1);
        //queue.put(2);
        //queue.put(3);
        //queue.put(4);
        //queue.put(5);
        //queue.put(6);
        //queue.Display();
        //Console.WriteLine("Geted item is {0}", queue.get());
        //queue.Display();
        //Console.ReadLine();
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
    }
    public void Display()
    {
        for (int i = 0; i < q.Length; i++)
        {
            Console.WriteLine(q[i]);
        }
    }
}
//linear Array Queue One 0 ~ n-1
class ArrayQueueTwo
{
    private string[] q;
    private int front = 0;
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
        rear = (rear + 1) % n;
        Console.WriteLine("rear= " + rear);
        Console.WriteLine("front= " + front);
        Console.WriteLine();
        if (rear == front)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {

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