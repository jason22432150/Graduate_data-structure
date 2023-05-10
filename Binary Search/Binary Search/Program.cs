class Program
{
    public static int BinarySearchRecursive(int[] list, int searchnum, int left, int right)
    {
        int middle;
        if (left <= right)
        {
            middle = (left + right) / 2;
            if (list[middle] == searchnum)
            {
                return middle;
            }
            else if (list[middle] >= searchnum)
            {
                right = middle - 1;
                return BinarySearchRecursive(list, searchnum, left, right);
            }
            else if (list[middle] <= searchnum)
            {
                left = middle + 1;
                return BinarySearchRecursive(list, searchnum, left, right);
            }
        }
        else
        {
            return -1;
        }
    }

    static void Main()
    {
        Console.WriteLine("Arrary: [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ]");
        int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.Write("Enter target num : ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(BinarySearchRecursive(list, input, 0, list.Length - 1));
    }
}
