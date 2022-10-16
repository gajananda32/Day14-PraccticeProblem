using System;
using System.Collections.Generic;
using LinkedListUC8;
class Program
{
    static void Main(string[] args)
    {
        LinkedL8 a = new LinkedL8();
        a.Add(56);
        a.Add(30);
        a.Add(70);
        //a.Display();
        int b = a.search(30);
        a.InsertAtPostion(b+1, 40);
        a.Display();
    }
}
