using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkjedListQueueUC4
{
    internal class LinkeListD
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted in Queue", node.data);

        }
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("Dequeued  value is {0}", this.head.data);
                    this.head = this.head.next;
                }
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
