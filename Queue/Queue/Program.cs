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
        Console.WriteLine();
    }
}
class Program
{

}