using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Node node_1 = new Node(56);
            Node node_2 = new Node(30);
            Node node_3 = new Node(70);

            Stack stack = new Stack();
            stack.Push(node_1);
            stack.Push(node_2);
            stack.Push(node_3);
            stack.DisplayStack();

            stack.Pop();
            stack.DisplayStack();
        }

    }
}