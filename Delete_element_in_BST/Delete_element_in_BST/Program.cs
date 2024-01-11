using System;

class Node
{
    public int Data;
    public Node Left, Right;

    public Node(int item)
    {
        Data = item;
        Left = Right = null;
    }
}

class BST
{
    private Node root;

    public BST()
    {
        root = null;
    }

    // Function to insert a new node with the given key
    private Node Insert(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
            root.Left = Insert(root.Left, data);
        else if (data > root.Data)
            root.Right = Insert(root.Right, data);

        return root;
    }

    // Function to delete a node with the given key
    private Node Delete(Node root, int key)
    {
        if (root == null)
            return root;

        if (key < root.Data)
            root.Left = Delete(root.Left, key);
        else if (key > root.Data)
            root.Right = Delete(root.Right, key);
        else
        {
            // Node with only one child or no child
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            // Node with two children: Get the inorder successor (smallest in the right subtree)
            root.Data = MinValue(root.Right);

            // Delete the inorder successor
            root.Right = Delete(root.Right, root.Data);
        }

        return root;
    }

    // Helper function to find the smallest value in a BST
    private int MinValue(Node root)
    {
        int minValue = root.Data;
        while (root.Left != null)
        {
            minValue = root.Left.Data;
            root = root.Left;
        }
        return minValue;
    }

    // Public method to delete a node with the given key
    public void DeleteNode(int key)
    {
        root = Delete(root, key);
    }

    // Public method to insert a new node with the given key
    public void InsertNode(int key)
    {
        root = Insert(root, key);
    }

    // Function to do inorder traversal of the tree
    private void InorderTraversal(Node root)
    {
        if (root != null)
        {
            InorderTraversal(root.Left);
            Console.Write(root.Data + " ");
            InorderTraversal(root.Right);
        }
    }

    // Public method to perform inorder traversal
    public void InorderTraversal()
    {
        InorderTraversal(root);
    }

    // Main method for testing

}
class Program
{
    static void Main()
    {
        BST bst = new BST();

        // Inserting nodes
        bst.InsertNode(50);
        bst.InsertNode(30);
        bst.InsertNode(20);
        bst.InsertNode(40);
        bst.InsertNode(70);
        bst.InsertNode(60);
        bst.InsertNode(80);

        Console.WriteLine("Inorder traversal before deletion:");
        bst.InorderTraversal();
        Console.WriteLine();

        // Deleting a node
        int keyToDelete = 30;
        bst.DeleteNode(keyToDelete);
        Console.WriteLine($"Node with key {keyToDelete} deleted.");

        Console.WriteLine("Inorder traversal after deletion:");
        bst.InorderTraversal();
        Console.Read();
    }
}