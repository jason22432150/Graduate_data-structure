class Program
{
    public static int BinarySearchRecursive(int[] list, int searchnum, int left, int right)
    {
        Console.WriteLine("searchnum: {0}, left: {1}, right: {2}", searchnum, left, right);
        if (left > right)
        {
            return -1;
        }
        int middle = (left + right) / 2;
        if (list[middle] == searchnum)
        {
            return middle;
        }
        else if (list[middle] > searchnum)
        {
            return BinarySearchRecursive(list, searchnum, left, middle - 1);
        }
        else if (list[middle] <= searchnum)
        {
            return BinarySearchRecursive(list, searchnum, middle + 1, right);
        }
        return -1;
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Arrary Inde: [ 0, 1, 2, 3, 4, 5, 6, 7, 8 ]");
            Console.WriteLine("Arrary Data: [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ]");
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Enter target num : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearchRecursive(list, input, 0, list.Length - 1));
        }
    }
}
