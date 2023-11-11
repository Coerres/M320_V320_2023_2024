namespace StackSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringStack myStack = new StringStack(5);

            myStack.Push("First");
            myStack.Push("Second");
            myStack.Push("Third");

            string poppedItem = myStack.Pop();

            myStack.Push("New Item");

            Console.ReadLine();
        }
    }
}