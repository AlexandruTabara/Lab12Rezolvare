using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12Rezolvare
{

    /// <summary>
    ///    Scrieti o clasa care va implementa o structura de date generica de tipul coada. (queue)
    ///Coada va functiona pe principiul FIFO(first in first out) si va avea urmatoarele metode si proprietati:
    ///         • Enqueue – va adauga un element la capatul cozii
    ///         • Dequeue – va extrage primul element din coada si il va returna ca rezultat
    ///         Count – va returna numarul de elemente din coada
    /// </summary>
    /// <typeparam name="T"></typeparam>
    ///

    public class Queue<T>
    {
        private int front; // index of the front of the queue
        private int rear; // index of the rear of the queue
        private int count; // number of items in the queue
        private int maxCapacity; // maximum capacity of the queue
        private T[] items; // array to store the items in the queue

        // constructor that initializes the queue with a maximum capacity
        public Queue(int capacity)
        {
            maxCapacity = capacity;
            items = new T[capacity];
            front = 0;
            rear = -1;
            count = 0;
        }

        // method to add an item to the back of the queue
        public void Enqueue(T item)
        {
            if (count == maxCapacity)
            {
                throw new Exception("Queue is full");
            }
            rear = (rear + 1) % maxCapacity;
            items[rear] = item;
            count++;
            Console.WriteLine($"Enqueued item: {item}");
        }

        // method to remove and return the item at the front of the queue
        public T Dequeue()
        {
            if (count == 0)
            {
                throw new Exception("Queue is empty");
            }
            T item = items[front];
            front = (front + 1) % maxCapacity;
            count--;
            Console.WriteLine($"Dequeued item: {item}");
            return item;
        }

        // method to check if the queue is empty
        public bool IsEmpty()
        {
            return count == 0;
        }

        // method to check if the queue is full
        public bool IsFull()
        {
            return count == maxCapacity;
        }
    }

    ///La initializarea cozii va fi stabilita capacitatea maxima a cozii.
    ///In interiorul clasei, folositi o structura de tip vector pentru a stoca datele.
    ///Initializati mai multe cozi (intregi, obiecte), adaugati elemente, extrageti elemente, afisati-le

}
