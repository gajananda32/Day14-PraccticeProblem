// See https://aka.ms/new-console-template for more information
//onsole.WriteLine("Hello, World!");
using LinkedListStackUC2;

class Program
{
    public static void Main(string[] args)
    {
        LinkedListStack linkedListStack = new LinkedListStack();
        linkedListStack.Push(70);
        linkedListStack.Push(30);
        linkedListStack.Push(56);
        linkedListStack.Display();
        linkedListStack.Peek();
        linkedListStack.Pop();
        linkedListStack.IsEmpty();
        

    }
}
