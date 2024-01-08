using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_list
{   //使用unsafe上下文來使用指標。注意，為了允許這個程式碼使用指標，你需要在項目的屬性中啟用 "Allow unsafe code" 選項。
    unsafe class ProgramLink
    {

        //unsafe 做法，教科書做法


        public struct Node
        {
            public int data;
            public Node* next;
        }
        static Node unSafe_AddLinkedList(Node node, int data)
        {
            Node lastNode = node;
            while (lastNode.next != null)
            {
                //lastNode.data = (int)lastNode.next;
                lastNode = *lastNode.next;
            } 
            Node nodeNext = new Node { data = data, next = null };
            lastNode.next = &nodeNext;
            Console.WriteLine("Add Node {nodeNext.data}");
            return nodeNext;
        }
        static void unSafe_ShowLinkedList(Node lastNode)
        {
            while(lastNode.next != null)
            {
                Console.WriteLine(lastNode.data);
                lastNode = *lastNode.next;
            }
        }



        static void Main(string[] args)
        {
            Node node = new Node { data = 0, next = null };
            node = unSafe_AddLinkedList(node, 1);
            //node = unSafeAddLinkedList(1);
            unSafe_ShowLinkedList(node);
            //LinkedList<int> linkedList = new LinkedList<int>();
            //AddFirst(linkedList, 1);
            //ShowLinkedList(linkedList);
            Console.ReadLine();
        }


        //正常safe做法，非教科書做法

        static void AddFirst(LinkedList<int> linkedList, int data)
        {
            Console.WriteLine("LinkedLest add " + data + " to first");
            linkedList.AddFirst(data);
        }
        static void ShowLinkedList(LinkedList<int> linkedList)
        {
            Console.WriteLine("\nShow linked list:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        LinkedList<int> linkedList = new LinkedList<int>();
    //        AddFirst(linkedList, 1);
    //        ShowLinkedList(linkedList);
    //        Console.ReadLine();
    //    }
    //    static void AddFirst(LinkedList<int> linkedList, int data)
    //    {
    //        Console.WriteLine("LinkedLest add " + data + " to first");
    //        linkedList.AddFirst(data);
    //    }
    //    static void ShowLinkedList(LinkedList<int> linkedList)
    //    {
    //        Console.WriteLine("\nShow linked list:");
    //        foreach (var item in linkedList)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        Console.WriteLine();
    //    }
    //}
}
