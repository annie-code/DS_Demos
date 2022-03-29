using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDoublyLinkedList
{
   public  class Node
    {
        /*Node class represents the node of doubly linked list. It consists of the 
        information part and links to its succeeding and preceeding nodes
        in terms of next and previous nodes.*/
        public int rollNumber;
        public string name;
        public Node next;/*points to the succeeding node*/
        public Node prev;/*points to the preceeding node*/
    }

    class DoublyLinked
    {
        Node START;
        public DoublyLinked()
        {
            START = null;
        }
        public void AddNodeBegining()
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            if(START==null)
            {
                newnode.next = null;
                newnode.prev = null;
                START = newnode;
                return;
            }
            newnode.next = START;
            newnode.prev = null;
            START.prev = newnode;
            START = newnode;

        }
        public void addNodeSoerted()/*Adds a new node*/
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            if (START == null || rollNo <= START.rollNumber)/*Checks if the list is empty*/
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
                newnode.next = START;
                if (START != null)
                    START.prev = newnode;
                newnode.prev = null;
                START = newnode;
                return;
            }
            Node previous, current;
            for (current = previous = START; current != null && rollNo >= current.rollNumber; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
            }
            /*On the execution of the above for loop, prev and current will point to those nodes
            between which the new node is to be inserted.*/
            newnode.next = current;
            newnode.prev = previous;

            if (current != null) /* If the node to be inserted is not the last node of the list */
            {
                current.prev = newnode;
            }
            previous.next = newnode;
        }

        public bool Search(int rollNo,out string name)/*Checks wheteher the specified node is present*/
        {
            name = "";
            
            if (START == null)
            { Console.WriteLine("Empty"); return false; }
            else
            {
                Node previous, current;
                previous = current = null;
                for (previous = current = START; current != null && rollNo != current.rollNumber; previous = current, current = current.next)
                { }
                name = current.name;
                /*The above for loop traverses the list. If the specified node is found then
                the function returns true, otherwise false.*/
                return (current != null);
            }
        }
        public void DelNode()
        {
            if (START == null) { Console.WriteLine("List empty"); return; }
            START = START.next;
            START.prev = null;
        }

        public void DirectTraverse()
        {
            if (START==null)
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list:\n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.rollNumber + "   " + currentNode.name + "\n");
            }

        }
        public void RevTraverse()/*traverses the list in the reverse direction*/
        {
            if (START==null)
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the reverse order:\n");
                Node currentNode;
                for (currentNode = START; currentNode.next != null; currentNode = currentNode.next)
                { }
                while (currentNode != null)
                {
                    Console.Write(currentNode.rollNumber + "   " + currentNode.name + "\n");
                    currentNode = currentNode.prev;
                }
            }
        }


    }
}
