using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("First");
            myQueue.Enqueue("Second");
            myQueue.Enqueue("Third");
            myQueue.Enqueue("Fourth");
            myQueue.Enqueue(1);
            myQueue.Enqueue(true);

            while (myQueue.Count != 0)
            {
                object obj = myQueue.Dequeue();

                Console.WriteLine("From Queue: {0}", obj);
            }

            Stack myStack = new Stack();
            myStack.Push("First");
            myStack.Push("Second");
            myStack.Push("Third");
            myStack.Push("Fourth");
            myStack.Push(1);
            myStack.Push(true);

            while (myStack.Count > 0)
            {
                object obj = myStack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
            }


        }
    }
}
