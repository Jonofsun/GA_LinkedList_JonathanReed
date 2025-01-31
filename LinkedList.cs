﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinkedList_JonathanReed
{

    public class LinkedList<T> // The use of generics makes the linked list flexible, capable of storing any type of data.
    {
        // Inner class LinkedListNode<T> represents individual elements (nodes) in the linked list.
        class LinkedListNode<T> // The constructor initializes the node with a value and sets Next to null
        {
            public T Value { get; set; }        // Represents the data stored in the node.
            public LinkedListNode<T> Next { get; set; } // Represents the reference to the next node in the linked list.

            // Constructor to initialize a LinkedListNode with a given value.
            public LinkedListNode(T value)
            {
                Value = value;  // Set the data value of the node.
                Next = null;    // Initialize the reference to the next node as null.
            }
        }

        // Fields
        private LinkedListNode<T> head;
        private int count;

        // Property
        public int Count
        {
            get { return count; }
        }

        // Constructor
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        // Method to add an element to the end of the linked list
        public void Add(T value) // Appends elements to the end of the list, handling both empty and non-empty list cases.
        {
            // Create a new node with the given value
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            // Check if the linked list is empty by examining whether the 'head' reference is 'null'.
            if (head == null)
            {
                // If the list is empty, make the new node ('newNode') the head of the list
                head = newNode;
            }
            else
            {
                // If the list is not empty, start at the head
                LinkedListNode<T> current = head;

                // Traverse the list to find the last node (one with no next node)
                while (current.Next != null)
                {
                    // Move to the next node in the list
                    current = current.Next;
                }

                // Connect the last node's 'Next' to the new node, adding it to the end
                current.Next = newNode;
            }

            // Increase the count to keep track of the number of elements in the list
            count++;
        }

        // Method to display all elements in the linked list
        public void Display() // Provides a simple way to visualize the list's contents from the head to the end.
        {
            // Start at the head of the linked list
            LinkedListNode<T> current = head;

            // Traverse the linked list and print each element
            while (current != null)
            {
                // Print the current node's value followed by an arrow symbol
                Console.Write($"{current.Value} -> ");

                // Move to the next node in the list
                current = current.Next;
            }

            // Print "null" to indicate the end of the linked list
            Console.WriteLine("null");
        }

        // Method to remove an element by its value
        public bool Remove(T value) //  Implements element removal by value.
        {
            // Check if the linked list is empty
            if (head == null)
            {
                // If the list is empty, return false (Element not found)
                return false;
            }

            // Check if the value to remove is at the head of the list
            if (head.Value.Equals(value))
            {
                // If the value is at the head, update the head to the next node and decrease the count
                head = head.Next;
                count--;
                return true; // Return true (Element found and removed)
            }

            // If the value is not at the head, start at the head
            LinkedListNode<T> current = head;

            // Traverse the list to find the element with the specified value
            while (current.Next != null)
            {
                // Check if the value of the next node matches the specified value
                if (current.Next.Value.Equals(value))
                {
                    // If a match is found, skip the next node by updating the 'Next' reference and decrease the count
                    current.Next = current.Next.Next;
                    count--;
                    return true; // Return true (Element found and removed)
                }
                current = current.Next;
            }

            // Return false (Element not found)
            return false;
        }

        // Indexer override to access elements by index
        public T this[int index] // Allows access to elements by their index in a user-friendly manner. 
        {
            get
            {
                // Check if the provided index is out of range (negative or greater than or equal to the count of elements)
                if (index < 0 || index >= count)
                {
                    // Throw an IndexOutOfRangeException if the index is out of range
                    throw new IndexOutOfRangeException();
                }

                // Start at the head of the linked list
                LinkedListNode<T> current = head;

                // Traverse the list to find the element at the specified index
                for (int i = 0; i < index; i++)
                {
                    // Move to the next node in the list
                    current = current.Next;
                }

                // Return the value of the element found at the specified index
                return current.Value;
            }
        }

        // Additional methods can be added here, such as InsertAtIndex, RemoveAtIndex, Clear, etc.
        public void InsertAtIndex(int index, T value)
        {
            if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                LinkedListNode<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            count++;
        }
        public void InsertAtFront(T value)
        {
            InsertAtIndex(0, value);
        }

        public void InsertAtEnd(T value)
        {
            InsertAtIndex(count, value);
        }
        // reverse
        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                LinkedListNode<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next?.Next;
            }
            count--;
        }

        public void RemoveAtFront()
        {
            RemoveAtIndex(0);
        }

        public void RemoveAtEnd()
        {
            RemoveAtIndex(count - 1);
        }
        // Clear
        public void Clear()
        {
            head = null;
            count = 0;
        }
    }

}
