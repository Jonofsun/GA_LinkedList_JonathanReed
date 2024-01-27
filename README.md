# Guided Assignment - Linked List Singly

## Introduction

**What is a Linked List:** A linked list is a linear data structure that consists of a sequence of elements called nodes. Each node contains two parts: data and a reference (or link) to the next node in the sequence. Linked lists are used to organize and store data in a way that allows for dynamic sizing and efficient insertions and removals.

**Why is it Important:** Linked lists are important because they offer several advantages over other data structures like arrays. They provide dynamic memory allocation, allowing for flexible sizing of data. Linked lists are efficient for insertions and deletions at arbitrary positions within the list, unlike arrays where elements need to be shifted. They are also the foundation for more complex data structures like stacks, queues, and hash tables.

***Two types of Linked List - Singly and Doubly*** 

1. **Singly Linked List:**
    
    - Each node contains a reference to the next node in the list.
    - Traversal is possible only in one direction, from the head to the tail.
    - Requires less memory because it stores only one reference per node.
    - Suitable for scenarios where forward traversal is predominantly needed, and memory efficiency is a concern.
2. **Doubly Linked List:**
    
    - Each node contains references to both the next and the previous nodes in the list.
    - Allows traversal in both forward and backward directions.
    - Requires more memory due to the storage of two references per node.
    - Beneficial for situations that involve frequent backward traversal or require bidirectional access, such as implementing data structures like queues and deques.

**Pros of Linked Lists:**

1. Dynamic Sizing: Linked lists can grow or shrink dynamically as elements are added or removed.
2. Efficient Insertions and Deletions: Adding or removing elements at any position is efficient.
3. No Wasted Memory: Memory is allocated for each element as needed, minimizing wasted space.
4. Versatility: Linked lists serve as the basis for other data structures and algorithms.
5. Constant-Time Insertions at Front: Adding an element at the front is a constant-time operation.

**Cons of Linked Lists:**

1. Inefficient Random Access: Accessing elements by index takes O(n) time as you must traverse the list from the beginning.
2. Increased Memory Usage: Linked lists require additional memory for the references (pointers).
3. More Complex Implementation: Implementing linked lists involves managing references and pointers, which can be error-prone.

***Real World Examples***

1. **Music Playlist:** Linked lists represent playlists of songs for easy navigation and reordering.
2. **Undo/Redo Functionality:** They store action history for undo and redo operations in software applications.
3. **Web Browsing History:** Linked lists manage visited web page history in browsers.
4. **File Systems:** Used to structure directories and files in file systems.
5. **Task Management:** Efficiently manage tasks in to-do lists or task management apps.
6. **Dynamic Memory Allocation:** Fundamental for dynamic memory management in programming languages.
7. **Symbol Tables:** Efficiently store information about variables and identifiers in compilers and interpreters.

---
## Requirements

Certainly, here are simplified instructions for the project:

**Project Setup:**
1. Create a new C# project named "GA_LinkedList_Singly_YourName."
2. Add your name and the current date as comments at the top of the main class or file.

**Linked List Implementation:**
3. Implement a generic singly linked list class named `LinkedList<T>`.
4. Include a nested class `LinkedListNode<T>` to represent individual elements (nodes) within the linked list.

**Fields and Properties:**
5. Include necessary fields: a private `head` field and a private `count` field.
6. Implement a public property named `Count` to provide access to the number of elements in the list.

**Constructor:**
7. Create a constructor for the `LinkedList` class to initialize `head` to null and `count` to zero.

**Core Methods:**
8. Implement the following core methods:
   - `Add(T value)` - Adds elements to the end of the linked list.
   - `Display()` - Displays all elements in the linked list.
   - `Remove(T value)` - Removes elements by their values.
   - Implement an indexer override to access elements by index.

**Additional Methods:**
9. Implement additional methods for inserting elements:
   - `InsertAtIndex(int index, T value)` - Inserts an element at a specified index.
   - `InsertAtFront(T value)` - Inserts an element at the beginning of the list.
   - `InsertAtEnd(T value)` - Inserts an element at the end of the list.
   
10. Implement additional methods for removing elements:
    - `RemoveAtIndex(int index)` - Removes an element at a specified index.
    - `RemoveAtFront()` - Removes the element at the front of the list.
    - `RemoveAtEnd()` - Removes the element at the end of the list.

11. Implement the `Clear` method to remove all elements from the linked list.

**Testing:**
12. Create a test program or class (e.g., `Program.cs`) to test your `LinkedList` class.
13. Add test cases to demonstrate the functionality of your linked list, including adding, removing, and inserting elements, accessing elements by index, and clearing the list.
14. Verify that your code compiles and runs without errors.

**Readme File:**
15. In Your Readme
16. Include answers to the following questions:
    - What is a linked list, and why is it useful?
    - In what scenarios is a linked list more efficient for finding specific data, and in what scenarios is it more efficient for adding new data compared to other data structures like arrays or dynamic arrays (e.g., List in C#)?
    - What is the importance of proper referencing of nodes in a linked list, and what potential issues can arise from improper referencing?
    - Critical Thinking: What software or systems might benefit from using a Linked List, a system that is slow to search for something, but quick to add.
    - Follow Up: Which system would it be more beneficial to use a List or Array, where all the data is grouped together for easy searching, but slow to add?
    - Any thoughts for combining the two to make it really efficient?

Ensure your code is well-documented with comments, and your `README.md` file provides clear explanations.

---

## Start By Creating a Linked List class

1. Make it generic
2. Name it `LinkedList`

```csharp
using System;

class LinkedList<T>
{

}

```

---

### Create a new class INSIDE of our Linked List class

```csharp

class LinkedList<T>
{
    // This class is created INSIDE our linked list.

    // Inner class LinkedListNode<T> represents individual elements (nodes) in the linked list.
    class LinkedListNode<T>
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
}

```

***What is a Linked List Node***

A linked list node is a fundamental component of a linked list data structure, consisting of data and a reference to the next node. The node's importance lies in its ability to:

1. Enable sequential storage of data elements.
2. Facilitate dynamic sizing, allowing for the flexible growth and shrinkage of the list.
3. Efficiently handle insertions and deletions at arbitrary positions.
4. Utilize memory efficiently, especially for large collections.
5. Serve as a versatile basis for implementing various data structures.
6. Support the creation of more complex data structures like stacks, queues, and hash tables.

---

### Fields, Property, and Constructor for your Linked List

```csharp
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
```


---

### Add Method ( Adding an element to our Linked List )

The `Add` method is used to append a new element to the end of a linked list. It checks if the list is empty and makes the new element the head if it is, or it traverses the list to find the last node and connects the new element to the end. The method keeps track of the number of elements in the list by incrementing the count.

```csharp
// Method to add an element to the end of the linked list
public void Add(T value)
{
    // 1. Create a new node with the given value
    LinkedListNode<T> newNode = new LinkedListNode<T>(value);

    // 2. Check if the linked list is empty by examining whether the 'head' reference is 'null'. If the list is empty, it means that there are no nodes in the list.

    if (head == null)
    {
        // 3. If the list is empty, make the new node ('newNode') the head of the list
        head = newNode;
    }
    else
    {
        // 4. If the list is not empty, start at the head
        LinkedListNode<T> current = head;

        // 5. Traverse the list to find the last node (one with no next node)
        while (current.Next != null)
        {
            // 6. Move to the next node in the list
            current = current.Next;
        }

        // 7. Connect the last node's 'Next' to the new node, adding it to the end
        current.Next = newNode;
    }

    // 8. Increase the count to keep track of the number of elements in the list
    count++;
}
```

1. A new node is created (`newNode`) to hold the given `value`.
    
2. It checks if the linked list is empty by examining whether the `head` reference is `null`. If the list is empty, it means that there are no nodes in the list.
    
3. If the list is empty (`head == null`), the new node (`newNode`) becomes the head of the linked list.
    
4. If the list is not empty, it starts at the head of the list and uses a `while` loop to traverse the list until it finds the last node. This is done by checking if the `Next` property of the current node is not `null`.
    
5. Inside the loop, the code moves from one node to the next by updating the `current` node to be the next node in the list.
    
6. Once the loop exits, `current` is pointing to the last node in the list.
    
7. The new node (`newNode`) is then connected to the end of the list by setting the `Next` property of the last node (`current`) to point to the new node.
    
8. Finally, a counter (`count`) is incremented to keep track of the number of elements in the list.

> ***Test Your Code Out***

```csharp
public static void (strings[] arg) {
	// Creating a new instance of your linked list
	LinkedList<string> myList = new LinkedList();
	
	// Adding an item to your linked list
	myList.Add("first");
	
	Console.WriteLine($"The number of elements in your list is {myList.Count}");
}
```

When you run your code, it should display the following.

```console
The number of elements in your list is 1
```

---
### Display Elements in the Linked List

The code defines a method named `Display` within a linked list class. This method is responsible for iterating through the linked list and printing the elements to the console in a readable format.

```csharp
// 1. Method to display all elements in the linked list
public void Display()
{
    // 2. Start at the head of the linked list
    LinkedListNode<T> current = head;
    
    // 3. Traverse the linked list and print each element
    while (current != null)
    {
        // 4. Print the current node's value followed by an arrow symbol
        Console.Write($"{current.Value} -> ");
        
        // 5. Move to the next node in the list
        current = current.Next;
    }
    
    // 6. Print "null" to indicate the end of the linked list
    Console.WriteLine("null");
}
```

Explanation:

1. The code defines a method named `Display` responsible for displaying the elements of the linked list.

2. We start at the head of the linked list by initializing a `current` variable with the value of `head`.

3. A `while` loop is used to traverse the linked list. It continues as long as `current` is not `null`, indicating there are more elements to display.

4. Inside the loop, the code prints the value of the current node followed by an arrow symbol (`->`) to visually separate the elements.

5. The `current` variable is updated to point to the next node in the list, allowing us to move to the next element in the linked list.

6. After the loop exits (when `current` becomes `null`, meaning we have reached the end of the list), the code prints "null" to indicate the end of the linked list.
7. 

> ***Test Your Code Out***

`Program.cs`
```csharp
    static void Main()
    {
        // Create a linked list of strings
        LinkedList<string> myList = new LinkedList<string>();

        // Add elements to the linked list
        myList.Add("first");
        myList.Add("second");
        myList.Add("third");

        // Test the Display method to print the elements
        Console.WriteLine("Linked List Elements:");
        myList.Display();
    }

```

When you run your code, it should display the following.

```console
Linked List Elements:
first -> second -> third -> null
```


---

### Remove Elements in the Linked List

This method, called `Remove`, is used to remove an element from a linked list based on its specified value. It first checks if the list is empty and returns `false` if it is. Then, it searches for the value within the list and removes it if found, updating the list structure and decreasing the count of elements, and it returns `true` to indicate a successful removal; otherwise, it returns `false` if the element is not found in the list.

```csharp
// 1. Method to remove an element by its value
public bool Remove(T value)
{
    // 2. Check if the linked list is empty
    if (head == null)
    {
        // 3. If the list is empty, return false (Element not found)
        return false;
    }

    // 4. Check if the value to remove is at the head of the list
    if (head.Value.Equals(value))
    {
        // 5. If the value is at the head, update the head to the next node and decrease the count
        head = head.Next;
        count--;
        return true; // 6. Return true (Element found and removed)
    }

    // 7. If the value is not at the head, start at the head
    LinkedListNode<T> current = head;

    // 8. Traverse the list to find the element with the specified value
    while (current.Next != null)
    {
        // 9. Check if the value of the next node matches the specified value
        if (current.Next.Value.Equals(value))
        {
            // 10. If a match is found, skip the next node by updating the 'Next' reference and decrease the count
            current.Next = current.Next.Next;
            count--;
            return true; // 11. Return true (Element found and removed)
        }
        current = current.Next;
    }

    // 12. Return false (Element not found)
    return false;
}

```


***Explanation:***

1. The code defines a method named `Remove` for removing an element by its value.
    
2. It checks if the linked list is empty by examining whether the `head` reference is `null`.
    
3. If the list is empty, it returns `false` because there are no elements to remove (element not found).
    
4. It checks if the value to remove is at the head of the list.
    
5. If the value is at the head, it updates the `head` to the next node, effectively removing the first element, and decreases the count of elements.
    
6. It returns `true` to indicate that the element was found and removed.
    
7. If the value is not at the head, it starts at the head to begin searching.
    
8. The code uses a `while` loop to traverse the list until it finds the element with the specified value.
    
9. It checks if the value of the next node matches the specified value.
    
10. If a match is found, it removes the element by skipping the next node in the list, effectively bypassing it, and decreases the count.
    
11. It returns `true` to indicate that the element was found and removed.
    
12. If the element is not found in the list after traversing it completely, it returns `false` to indicate that the element was not found.

> ***Test Your Code Out***

`Program.cs`
```csharp
    static void Main()
    {
        // Create a linked list of strings
        LinkedList<string> myList = new LinkedList<string>();

        // Add elements to the linked list
        myList.Add("first");
        myList.Add("second");
        myList.Add("third");

		// Remove an element
		myList.Add("second");

        // Test the Display method to print the elements
        Console.WriteLine("Linked List Elements:");
        myList.Display();
    }

```

When you run your code, it should display the following.

```console
Linked List Elements:
first -> third -> null
```

---

### Access a single element in the Link List ( override the indexer )

This code defines an indexer override within a linked list class, allowing elements of the linked list to be accessed by their index positions. It performs bounds checking to ensure that the provided index is within valid range and throws an `IndexOutOfRangeException` if it's not. It then traverses the linked list to find the element at the specified index and returns its value.


```csharp
// 1. Indexer override to access elements by index
public T this[int index]
{
    get
    {
        // 2. Check if the provided index is out of range (negative or greater than or equal to the count of elements)
        if (index < 0 || index >= count)
        {
            // 3. Throw an IndexOutOfRangeException if the index is out of range
            throw new IndexOutOfRangeException();
        }

        // 4. Start at the head of the linked list
        LinkedListNode<T> current = head;

        // 5. Traverse the list to find the element at the specified index
        for (int i = 0; i < index; i++)
        {
            // 6. Move to the next node in the list
            current = current.Next;
        }

        // 7. Return the value of the element found at the specified index
        return current.Value;
    }
}
```

Explanation:

1. This code defines an indexer override, allowing elements in the linked list to be accessed using square brackets and an index.

2. It checks if the provided index is out of range, either negative or greater than or equal to the count of elements.

3. If the index is out of range, it throws an `IndexOutOfRangeException` to indicate that the index is not valid.

4. It initializes a `current` variable to the `head` of the linked list.

5. The code uses a `for` loop to traverse the list, moving from the head to the element at the specified index.

6. Inside the loop, it moves to the next node in the list by updating the `current` node accordingly.

7. Finally, it returns the value of the element found at the specified index, allowing users to access linked list elements by their position in the list.

> ***Test Your Code Out***

`Program.cs`
```csharp
    static void Main()
    {
        // Create a linked list of strings
        LinkedList<string> myList = new LinkedList<string>();

        // Add elements to the linked list
        myList.Add("first");
        myList.Add("second");
        myList.Add("third");

		// Remove an element
		myList.Add("second");

        // Test the Display method to print the elements
        Console.WriteLine("Linked List Elements:");
        myList.Display();

		int index = 1;
		Console.WriteLine($"The element at index {index} is {myList[index]}");
    }

```

When you run your code, it should display the following.

```console
Linked List Elements:
first -> third -> null
The element at index 1 is third
```

---

### Test the code

```csharp
class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        linkedList.Add(10);
        linkedList.Add(20);
        linkedList.Add(30);

        Console.WriteLine("Linked List elements:");
        linkedList.Display();

        Console.WriteLine("Count of elements: " + linkedList.Count);

        int indexToAccess = 1;
        Console.WriteLine($"Element at index {indexToAccess}: {linkedList[indexToAccess]}");

        int valueToRemove = 20;
        if (linkedList.Remove(valueToRemove))
        {
            Console.WriteLine($"Removed {valueToRemove} from the list.");
        }
        else
        {
            Console.WriteLine($"{valueToRemove} not found in the list.");
        }

        Console.WriteLine("Updated Linked List elements:");
        linkedList.Display();

        Console.ReadLine();
    }
}
```

This code defines a simple linked list class with methods for adding, removing, displaying elements, and an indexer override to access elements by index. You can modify and extend it as needed for your specific use case.

---

## Add Additional Methods

### Insert At:
1. ***Insert At Index: Inserts an element at a specified index in the linked list.***
   - Check if the specified index is within the valid range (0 to count).
   - Traverse the list to find the node at the specified index.
   - Update the references to insert the new node at the desired index.

2. ***Insert At Front: Inserts an element at the beginning (front) of the linked list.***
   - Create a new node with the given value.
   - Update the new node's "Next" reference to point to the current head.
   - Make the new node the new head of the linked list.

3. ***Insert At End: Inserts an element at the end of the linked list.***
   - Create a new node with the given value.
   - Check if the list is empty; if it is, make the new node the head.
   - If the list is not empty, traverse the list to find the last node and update its "Next" reference to point to the new node.

For all these methods, ensure you update the count of elements in the linked list accordingly after performing the insertions.
### Remove At:
1. ***Remove At Front:** Removes the element at the front of the linked list.***
   - Check if the linked list is empty (head is null). If it is, there's nothing to remove.
   - If the list is not empty, update the head to point to the second element (head.Next).
   - Decrease the count of elements to reflect the removal.

2. ***Remove At Index:** Removes the element at a specified index in the linked list.***
   - Check if the specified index is within the valid range (0 to count-1).
   - Traverse the list to find the node just before the specified index.
   - Update the references to skip the node at the specified index, effectively removing it.
   - Decrease the count of elements to reflect the removal.

3. ***Remove At End:** Removes the element at the end of the linked list.:***
   - Check if the linked list is empty (head is null) or contains only one element. If so, set the head to null or remove the single element.
   - If the list has more than one element, traverse the list to find the second-to-last node.
   - Update the second-to-last node's "Next" reference to null, effectively removing the last node.
   - Decrease the count of elements to reflect the removal.

For all these methods, it's important to handle edge cases such as an empty list or attempting to remove elements at invalid indices. Make sure to update the count of elements accordingly after performing the removals.

### Clear

**Clear:** This method removes all elements from the linked list, effectively resetting the list to an empty state.
- Iterate through the linked list and remove each element one by one, setting the head to null and resetting the count to zero to clear the list.
- Make sure to handle cases where the list is already empty gracefully to avoid unnecessary iterations or errors.
- After calling the Clear method, the linked list should be in an empty state with no elements remaining.
---

## Rubric

| Name                | Description                                                      | Points |
|---------------------|------------------------------------------------------------------|--------|
| Project Setup       | Creation of the C# project with correct name and comments.       | 5      |
| LinkedList Class    | Implementation of the generic singly linked list class.          | 10     |
| LinkedListNode      | Implementation of the nested `LinkedListNode` class.            | 5      |
| Fields and Props    | Proper implementation of `head` and `count` fields and property.  | 5      |
| Constructor         | Implementation of the constructor for `LinkedList` class.        | 5      |
| Core Methods        | Implementation of core methods (Add, Display, Remove, Indexer).  | 15     |
| Additional Methods  | Implementation of additional methods (Insert and Remove).        | 15     |
| Clear Method        | Implementation of the `Clear` method.                            | 5      |
| Testing             | Testing program to verify functionality, with diverse test cases.| 10     |
| Code Compilation    | Code compiles without errors.                                    | 5      |
| Readme              | A well-documented README file with answers to questions.         | 10     |
| Total               |                                                                  | 100    |
