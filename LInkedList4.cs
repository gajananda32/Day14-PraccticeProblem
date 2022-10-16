using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListUC4
{
    internal class LInkedList4
    {
        internal Node4 head;
        internal void Add(int data)
        {
            Node4 node = new Node4(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node4 temp = head;
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
            Node4 temp = this.head;
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
       public void InsertAtPostion(int postion,int data)
        {
            if(postion < 1)
            {
                Console.WriteLine("Invalid Postion ");
            }
            if(postion == 1)
            {
                var newNode = new Node4(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (postion-- != 0)
                {
                    if(postion == 1)
                    {
                        Node4 node = new Node4(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (postion != 1)
                {
                    Console.WriteLine("postion is out of range");
                }
                Console.WriteLine("Inserted Value is : "+data);
               // return head;
            }
       }
    }
}
