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
class LinkQueue
{
    private int data;
    private int next;
    private int front;
    private int rear;
    private void enqueue(int data)
    {
        if (front == 0)
        {
            front = data;
            rear = front;
        }
        else
        {
            this.rear.next
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue(5);
        queue.put(1);
        queue.put(2);
        queue.put(3);
        queue.put(4);
        queue.put(5);
        queue.put(6);
        queue.Display();
        Console.WriteLine("Geted item is {0}", queue.get());
        queue.Display();
        Console.ReadLine();
    }
}