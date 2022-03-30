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

            Queue queue = new Queue();
            queue.Enqueue(node_1);
            queue.Enqueue(node_2);
            queue.Enqueue(node_3);
            queue.DisplayQueue();
            queue.Dequeue();
            queue.DisplayQueue();
        }

    }
}