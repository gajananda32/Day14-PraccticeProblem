using LinkjedListQueueUC4;
using System;
class program
{
    public static void Main(string[] args)
    {
        LinkeListD a = new LinkeListD();
        a.Enqueue(56);
        a.Enqueue(30);
        a.Enqueue(70);
        a.Display();
        a.Dequeue();
    }
}

