using System;
namespace Stack
{
    class program
    {
        static void Main(string[]args)
        {
            Node node_1 = new Node(70);
            Node node_2 = new Node(30);
            Node node_3 = new Node(56);

            Stack stack = new Stack();
            stack.Push(node_1);
            stack.Push(node_2);
            stack.Push(node_3);
         
            stack.Peak();
            stack.Pop();
            stack.Peak();
        }
    }
}