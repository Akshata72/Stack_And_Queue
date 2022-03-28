using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        LinkedList linkedlist;
        public Stack()
        {
            linkedlist = new LinkedList();
        }
        public void Push(Node node)
        {
            linkedlist.AddNode(node);
        }
        public void Pop()
        {
            linkedlist.RemoveNode();
        }
        public void Peak()
        {
            linkedlist.Display();
        }
        public void Top()
        {
            var val = linkedlist.Head;
            Console.WriteLine(val.data);
        }
    }
}
