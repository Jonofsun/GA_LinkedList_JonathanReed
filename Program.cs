namespace GA_LinkedList
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
            myList.Add("second");

            // Test the Display method to print the elements
            Console.WriteLine("Linked List Elements:");
            myList.Display();

            int index = 1;
            Console.WriteLine($"The element at index {index} is {myList[index]}");

        }
    }
}
