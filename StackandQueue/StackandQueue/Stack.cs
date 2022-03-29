using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    class Stack
    {
        Linkedlist linkedList;
        public Stack()
        {
            linkedList = new Linkedlist();
        }
        public void Push(Node node)
        {
            linkedList.AddNode(node);
        }
        public void DisplayStack()
        {
            Console.WriteLine("Stack");
            linkedList.Display();
        }
        public void Top()
        {
            var val = linkedList.Head;
            Console.WriteLine(val.data);
        }
    }
}
