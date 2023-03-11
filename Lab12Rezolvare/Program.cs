using System;
using System.Collections.Generic;

namespace Lab12Rezolvare
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>(10);
            Queue<object> objQueue = new Queue<object>(5);

            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);
            intQueue.Enqueue(4);
            intQueue.Enqueue(5);
            intQueue.Enqueue(6);

            int item = intQueue.Dequeue(); // item = 1

            Console.WriteLine();

            objQueue.Enqueue("hello");
            objQueue.Enqueue(42);
            objQueue.Enqueue(new DateTime(2023, 3, 11));
            objQueue.Enqueue(3.14);

            object obj = objQueue.Dequeue(); // obj = "hello"
        }
    }
}
