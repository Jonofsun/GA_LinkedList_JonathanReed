namespace GA_LinkedList_JonathanReed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a linked list of strings
            LinkedList<string> myList = new LinkedList<string>();

            // Add elements to the linked list
            myList.Add("first");
            myList.Add("second");
            myList.Add("third");

            // Remove an element
            //bool removed = myList.Remove("second");
            //if (removed)
            //{
            //    Console.WriteLine("\"second\" was successfully removed.");
            //}
            //else
            //{
            //    Console.WriteLine("\"second\" was not found.");
            //}

            // Test the Display method to print the elements
            Console.WriteLine("Linked List Elements:");
            myList.Display();

            Console.WriteLine("\nInserting elements at specific positions:"); // Demonstrates the insertion methods by adding new elements at the beginning, a specific index, and the end of the list.
            myList.InsertAtIndex(1, "New secound");
            myList.InsertAtFront("Zero");
            myList.InsertAtEnd("Fourth");
            myList.Display();

            Console.WriteLine($"\nElement at index 2: {myList[2]}"); // Shows how to use the indexer to access an element at a particular position.

            Console.WriteLine("\nRemoving elements by value and index:"); //  This part of the demonstration shows how to remove elements by value, from the front, from the end, and at a specific index, showcasing the flexibility of the list manipulation methods.
            myList.Remove("Fourth");
            myList.RemoveAtFront();
            myList.RemoveAtEnd();
            myList.RemoveAtIndex(1);
            myList.Display();

            int index = 1;
            try
            {
                Console.WriteLine($"The element at index {index} is {myList[index]}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            Console.WriteLine("\nClearing the list:");
            myList.Clear(); // clear the list of all elements and display it
            myList.Display();

        }
    }
}
