using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQueue
{

    /* Class to represent a node in the queue */
    class Node
    {
        public int data;
        public Node next;
        public Node(int d, Node n) /* Creates node */
        {
            data = d;
            n = next;
        }
    }



    /* Class to represent a queue */
    class Queues
    {

        Node FRONT, REAR; /* Pointers to the first and last nodes of the queue */

        public Queues()
        {
            /* Set FRONT and REAR to null as the queue is initially empty. */
            FRONT = null;
            REAR = null;
        }
        public void insert(int element) /* Inserts a node in the queue */
        {
            Node newnode;
            newnode = new Node(element, null);
            if (FRONT == null)
            {
                /* If the queue is empty, then both FRONT and REAR should point to the new node. */
                FRONT = newnode;
                REAR = newnode;
            }
            else
            {
                /* If the queue is NOT empty, then REAR points to the last node. REAR should now point to the new node. */
                REAR.next = newnode;
                REAR = newnode;
            }
            Console.WriteLine("\nNumber " + element + " is inserted into the queue\n");
        }

        public void remove() /* Deletes node from the queue */
        {
            if (FRONT == null) /* Check if the queue is empty */
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                Console.WriteLine("\nThe element deleted from the queue is: " + FRONT.data);
                FRONT = FRONT.next; /* FRONT will now point to the next node in the queue. */
            }
        }

        public void display() /* displays the elements of the queue */
        {
            Node tmp;
            if (FRONT == null) /* Checks if the queue is empty */
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                Console.WriteLine("\nElements in the queue are\n");
                for (tmp = FRONT; tmp != null; tmp = tmp.next) /* traverse the queue through tmp node */
                {
                    Console.Write(tmp.data + "   ");
                }
                Console.WriteLine();
            }
        }



    }
}