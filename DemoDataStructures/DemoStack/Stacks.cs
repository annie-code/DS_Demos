using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStack
{
    /* Class to represent a node of the stack */
    class Node
    {
        public int info; //  Variable to store data
        public Node next; /* Variable to store address of next node in the stack */
        public Node(int i, Node n)/* Constructor to initialize node contents */
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {

        Node top; // Refers to the top of the stack

        public Stacks()// Initializes stack
        {
            top = null;
        }
       public  bool empty()// Checks whether the stack is empty
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void Push(int element) // Inserting an element in the stack
        {
            Node fresh; // refers to new node
            fresh = new Node(element, null); /* allocating memory to the new node*/

            fresh.next = top; /* Make next field of the new node point to the top of the stack*/
            top = fresh; /* Make top points to the new node */
            Console.WriteLine("\n" + element + " pushed.");
        }

        public void Pop() // Pops an element from the stack
        {
            Console.WriteLine("\nThe popped element is: " +
            top.info);
            top = top.next; /* Make top point to the next node in
            sequence */
        }
        public void display()
        {
            Node tmp;
            if (empty())    // If stack is empty
                Console.WriteLine("\nStack Empty");
            else
            {
                Console.WriteLine("\nStack Elements:");
                // Traverse the list from beginning till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }

    }
}
