using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleting_the_maximum_element_from_a_max_heap
{
    class MaxHeap
    {
        private int[] heap;
        private int size;

        public MaxHeap(int capacity)
        {
            heap = new int[capacity];
            size = 0;
        }

        public void Insert(int value)
        {
            if (size == heap.Length)
            {
                Console.WriteLine("Heap is full. Cannot insert more elements.");
                return;
            }

            // Insert the new element at the end
            heap[size] = value;

            // Restore heap property (Heapify Up)
            HeapifyUp(size);

            size++;
        }

        public int DeleteMax()
        {
            if (size == 0)
            {
                Console.WriteLine("Heap is empty.");
                return -1; // or throw an exception
            }

            int maxElement = heap[0];

            // Swap root with the last element
            Swap(0, size - 1);

            // Remove the last element
            size--;

            // Restore heap property (Heapify Down)
            HeapifyDown(0);

            return maxElement;
        }

        private void HeapifyUp(int index)
        {
            int parent = (index - 1) / 2;

            while (index > 0 && heap[index] > heap[parent])
            {
                // Swap with parent if the current element is greater
                Swap(index, parent);

                // Move up to the parent
                index = parent;
                parent = (index - 1) / 2;
            }
        }

        private void HeapifyDown(int index)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            int largest = index;

            // Compare with left child
            if (leftChild < size && heap[leftChild] > heap[largest])
            {
                largest = leftChild;
            }

            // Compare with right child
            if (rightChild < size && heap[rightChild] > heap[largest])
            {
                largest = rightChild;
            }

            // If the largest element is not the current element, swap and continue heapify down
            if (largest != index)
            {
                Swap(index, largest);
                HeapifyDown(largest);
            }
        }

        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public void PrintHeap()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(heap[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            MaxHeap maxHeap = new MaxHeap(10);

            // Insert elements into the max heap
            maxHeap.Insert(90);
            maxHeap.Insert(85);
            maxHeap.Insert(80);
            maxHeap.Insert(75);
            maxHeap.Insert(70);
            maxHeap.Insert(65);
            maxHeap.Insert(60);
            maxHeap.Insert(55);
            maxHeap.Insert(50);

            // Delete the maximum element
            int deletedElement = maxHeap.DeleteMax();
            Console.WriteLine($"Deleted Element: {deletedElement}");

            Console.WriteLine("Updated Max Heap:");
            maxHeap.PrintHeap();
            Console.ReadLine();
        }
    }
}
