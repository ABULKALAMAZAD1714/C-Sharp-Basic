using System;
using System.Collections.Generic;

namespace queueexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQueue = new Queue<int>();
            aQueue.Enqueue(12);
            aQueue.Enqueue(12345);
            aQueue.Enqueue(34);
            foreach (var data in aQueue)
            {
                Console.WriteLine(data);
            }
            aQueue.Dequeue();
            aQueue.Dequeue();

            Console.WriteLine();
            Console.WriteLine();
            foreach (var data in aQueue)
            {
                Console.WriteLine(data);
            }



        }
    }
}
