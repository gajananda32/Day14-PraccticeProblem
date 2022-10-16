using System;
using LinkedListUC4;
class Program
{
    static void Main(string[] args)
    {
        LInkedList4 a = new LInkedList4();
        a.Add(56);
        //a.Add(30);
        a.Add(70);
        //int b = a.Search(56);
        a.InsertAtPostion(2, 30);
        a.Display();


    }
}