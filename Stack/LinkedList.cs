using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            this.Head = Head;
            this.Tail = Tail;
        }
        public void AddNode(Node node)
        {
            if(Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        public void RemoveNode()
        {
            while(Head != null)
            {
                Console.WriteLine("pop = {0}", Head.data);
                Head = Head.next;
            }
        }
        public void Display()
        {
            Node temp = Head;
            if(temp == null)
            {
                Console.WriteLine("Queue is Empty...");
            }
            else
            {
                Console.WriteLine("Stack is Follow: ");
            }
            while (temp != null)
            {
                Console.Write(temp.data);
                temp = temp.next;
                Console.WriteLine("->");
            }
        }
    }
}
