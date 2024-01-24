using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_heap_bottom_up
{
    internal class Program
    {
        public static void BuildMaxHeap(int[] arr)
        {
            int n = arr.Length;
            for (int i = (n / 2) - 1; i >= 0; i--)
            {
                Heapify(arr, i, n);
            }
        }
        private static void Heapify(int[] arr, int i, int n)
        {
            int largest = i;
            int left = i * 2 + 1;
            int right = i * 2 + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                //比較左右子元素
                Heapify(arr, largest, n);
            }
        }
        static void PrintArrary(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" ");
        }
        static void Main(string[] args)
        {
            int[] arr = { 8, 10, 7, 9, 5, 4, 3 };

            Console.WriteLine("Original arrary:");
            PrintArrary(arr);
            BuildMaxHeap(arr);

            Console.WriteLine("Max Heap:");
            PrintArrary(arr);
            Console.Read();
        }
    }
    class MaxHeap
    {
        public static void BuildMaxHeap(int[] arr)
        {
            int n = arr.Length;

            // Start from the last non-leaf node and heapify all nodes in reverse order
            for (int i = (n / 2) - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
        }

        // Heapify a subtree rooted with node i which is an index in arr[]
        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int left = 2 * i + 1; // left child
            int right = 2 * i + 2; // right child

            // If left child is larger than root
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            // If right child is larger than largest so far
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // If largest is not root
            if (largest != i)
            {
                // Swap arr[i] and arr[largest]
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                // Recursively heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }

        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        //public static void Main()
        //{
        //    int[] arr = { 4, 10, 3, 5, 1 };
        //    Console.WriteLine("Original array:");
        //    PrintArray(arr);

        //    BuildMaxHeap(arr);

        //    Console.WriteLine("Max Heap:");
        //    PrintArray(arr);
        //    Console.Read();
        //}
    }
}
