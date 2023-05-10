class Program
{
    public static char[] permutations(char[] list, int i, int n)
    {
        int j;

        if (i == n)
        {
            Console.Write(list[0]);
            for (j = 1; j <= n; j++)
            {
                Console.Write(list[j]);
            }
            Console.WriteLine();
        }
        else
        {
            for (j = i; j <= n; j++)
            {
                Swap(ref list[i], ref list[j]);
                permutations(list, i + 1, n);
                Swap(ref list[i], ref list[j]);
            }
        }
        return list;
    }
    public static Tuple<char, char> Swap(ref char i, ref char j)
    {
        char store = i;
        i = j;
        j = store;
        return Tuple.Create(i, j);
    }
    static void Main()
    {
        char[] list = { 'a', 'b', 'c' };
        permutations(list, 0, list.Length - 1);
    }
}