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

            Stack stake = new Stack();
            stake.Push(node_1);
            stake.Push(node_2);
            stake.Push(node_3);
            stake.DisplayStack();
        }
    }
}