using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkeddListUC5
{
    internal class LinkedL5
    {
        internal Node5 head;
        internal void Add(int data)
        {
            Node5 node = new Node5(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node5 temp = head;
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
            Node5 temp = this.head;
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
        internal Node5 Remove()
        {
            if(this.head==null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
    }
}
