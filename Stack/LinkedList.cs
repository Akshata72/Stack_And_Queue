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
        public void Display()
        {
            Node temp = Head;
            if(temp == null)
            {
                Console.WriteLine("Stake is Empty...");
            }
            else
            {
                Console.WriteLine("Stake is Follow: ");
                while(temp != null)
                {
                    Console.Write(temp.data);
                    temp = temp.next;
                    Console.WriteLine("->");
                }
            }
        }
    }
}
