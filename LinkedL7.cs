using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListUC7
{
    internal class LinkedL7
    {

        internal Node7 head;
        internal void Add(int data)
        {
            Node7 node = new Node7(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node7 temp = head;
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
            Node7 temp = this.head;
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
        internal Node7 Search(int value)
        {
            while(this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
                Console.WriteLine("searched value is : " + value);
            }
            return null;
        }
    }
}
