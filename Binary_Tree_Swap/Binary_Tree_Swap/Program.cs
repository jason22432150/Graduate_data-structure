using System;

class Node
{
    public int Data;
    public Node Left, Right;

    public Node(int data)
    {
        Data = data;
        Left = Right = null;
    }
}

class BinaryTree
{
    private Node root;

    public BinaryTree()
    {
        root = null;
    }

    // 遞歸互換每個節點的左右子樹
    private void Mirror(Node node)
    {
        if (node != null)
        {
            // 遞歸處理左子樹
            Mirror(node.Left);
            // 遞歸處理右子樹
            Mirror(node.Right);

            // 交換左右子樹
            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }
    }

    // 公共方法以啟動遞歸過程
    public void Mirror()
    {
        Mirror(root);
    }

    // 簡單的遞歸遍歷以檢視二叉樹
    private void InOrderTraversal(Node node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.Write(node.Data + " ");
            InOrderTraversal(node.Right);
        }
    }

    // 公共方法以遍歷和顯示二叉樹
    public void InOrderTraversal()
    {
        InOrderTraversal(root);
        Console.WriteLine();
    }

    // 主方法用於測試
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        // 創建一個簡單的二叉樹
        tree.root = new Node(1);
        tree.root.Left = new Node(2);
        tree.root.Right = new Node(3);
        tree.root.Left.Left = new Node(4);
        tree.root.Left.Right = new Node(5);

        Console.WriteLine("原始二叉樹:");
        tree.InOrderTraversal();

        // 互換左右子樹
        tree.Mirror();

        Console.WriteLine("互換後的二叉樹:");
        tree.InOrderTraversal();
        Console.Read();
    }
}
