using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListUC6
{
    internal class LinkedL6
    {
        internal Node6 head;
        internal void Add(int data)
        {
            Node6 node = new Node6(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node6 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Display()
        {
            Node6 temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node6 RemoveLast()
        {
            if (head==null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node6 newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
    }
}
