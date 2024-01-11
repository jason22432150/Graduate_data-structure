using System;
using System.Collections.Generic;

class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int value)
    {
        val = value;
        left = right = null;
    }
}
class BSTSort
{
    private TreeNode root;
    public void Insert(int key)
    {
        root = InsertRec(root, key);
    }
    private TreeNode InsertRec(TreeNode root, int key)
    {
        if (root == null)
        {
            root = new TreeNode(key);
        }
        else if (key < root.val)
        {
            root.left = InsertRec(root.left, key);
        }
        else if (key > root.val)
        {
            root.right = InsertRec(root.right, key);
        }
        return root;
    }
    public List<int> InorderTraversal()
    {
        List<int> result = new List<int>();
        InorderTraversalRec(root, result);
        return result;
    }
    private void InorderTraversalRec(TreeNode root, List<int> result)
    {
        if (root != null)
        {
            InorderTraversalRec(root.left, result);
            result.Add(root.val);
            InorderTraversalRec(root.right, result);
        }
    }
}
class Program
{
    static void Main()
    {
        BSTSort bstSort = new BSTSort();
        int[] arr = { 5, 3, 7, 1, 9, 4, 6 };
        foreach (int element in arr)
        {
            bstSort.Insert(element);
        }

        List<int> storedAdd = bstSort.InorderTraversal();
        Console.WriteLine("Sorted Array: ");
        Console.WriteLine(storedAdd);
        foreach (int element in storedAdd)
        {
            Console.Write(element + " ");
        }
        Console.ReadLine();
    }
}