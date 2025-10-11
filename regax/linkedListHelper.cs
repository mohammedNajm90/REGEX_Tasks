using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regax
{
    public static class linkedListHelper
    {

        public static void PrintList(LinkedList<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("The linked list is empty.");
                return;
            }
            else
            {
                Console.WriteLine("Linked List Contents:");
                // Print each element in the linked list in order
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                // Print each element in the linked list in reverse order
                foreach (var item in list.Reverse())
                {
                    Console.Write(item + " ");
                }
                //counts the number of elements in the linked list
                Console.WriteLine($"\nNumber of elements in the linked list: {list.Count}");
            }

        }
        public static int SearchNode(LinkedList<int> list, int value)
        {

            int index = 0;
            foreach (var item in list)
            {
                if (item == value)
                {
                    return index; // Return the index if the value is found
                }
                index++;
            }
            return -1; // Return -1 if the value is not found
        }
        public static LinkedList<int> insestAtBeging(LinkedList<int> list, int value)
        {
            list.AddFirst(value);
            return list;
        }
        public static LinkedList<int> insestAtEnd(LinkedList<int> list, int value)
        {
            list.AddLast(value);
            return list;
        }

        public static LinkedList<int> deleteFirstNode(LinkedList<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The linked list is empty. No nodes to delete.");
                return list;
            }
            else
            {
                list.RemoveFirst();
                return list;
            }
        }
        public static LinkedList<int> insertAtindex(LinkedList<int> list, int value, int index)
        {
            //check if index is valid
            if (index < 0 || index > list.Count)
            {
                Console.WriteLine("Out of Range ");
            }
            //pushing at the beginning
            else if (index == 0)
            {
                list.AddFirst(value);
                return list;
            }
            //pushing at the end
            else if (index == list.Count)
            {
                list.AddLast(value);
                return list;
            }
            //pushing at the middle
            var middleNode = list.First;
            for (int i = 0; i < index - 1; i++)
            {
                middleNode = middleNode.Next;
            }
            list.AddAfter(middleNode, value);
            return list;
        }
        public static LinkedList<int> deleteLastNode(LinkedList<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The linked list is empty. No nodes to delete.");
                return list;
            }
            else
            {
                list.RemoveLast();
                return list;
            }
        }
        public static LinkedList<int> deleteByValue(LinkedList<int> list, int value)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The linked list is empty. No nodes to delete.");
                return list;
            }
            else
            {
                var node = list.Find(value);
                if (node != null)
                {
                    list.Remove(node);
                }
                else
                {
                    Console.WriteLine("Value not found in the linked list.");
                }
                return list;
            }
        }
        public static void FindMaxAndMin(LinkedList<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The linked list is empty.");
                return;
            }
            else
            {
                int max = list.Max();
                int min = list.Min();
                Console.WriteLine($"Maximum value in the linked list: {max}");
                Console.WriteLine($"Minimum value in the linked list: {min}");
            }
        }
        public static List<int> selectionSort(List<int> list)
        {
            List<int> sortedList = list.ToList();
            int n = sortedList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                // Find the index of the minimum element in the unsorted portion of the list
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (sortedList[j] < sortedList[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the found minimum element with the first element of the unsorted portion
                if (minIndex != i)
                {
                    int temp = sortedList[i];
                    sortedList[i] = sortedList[minIndex];
                    sortedList[minIndex] = temp;
                }
            }
            return sortedList;
        }

    }
}
