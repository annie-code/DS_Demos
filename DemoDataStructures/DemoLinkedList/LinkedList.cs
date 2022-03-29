using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinkedList
{
    /* Create a class to represent a node in the linked list. Each node consists of the information part and a link to the next node.*/
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    /* Create a class to represent the linked list. To represent a linked list,
     * you only need a reference to the first node of the list. */
    public class LinkedList
    {
        Node START; //Reference to the first node of the list.
        public LinkedList()
        {
            START = null;
        }

        public void addNode()/* Adds a Node in the list */
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

            if (START == null ) //If the node to be inserted is the first node
            {

                newnode.next = START;
                START = newnode;
                return;
            }
            //Insert at the end
            Node previous, current;
            //Trverse till the end to find the last inserted
            for (previous = current = START; current != null; previous = current, current = current.next)
            { }
            newnode.next = current;
            //last inserted next part update with newnode reference
            previous.next = newnode;

            //inserting to the begining
            //newnode.next = START;
            //START = newnode;

        }
        public void addSortedNode()/* Adds a Node in the list */
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

            if (START == null || rollNo <= START.rollNumber) /* If the list is empty or the new node has a value less than or equal to that of the first node in the list. */
            {
                /* If the roll number of the node to be inserted already exists in the list */
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                /* Otherwise, if the list is empty or the new node needs to be inserted before the first node of the list */
                newnode.next = START;
                START = newnode;
                return;
            }

            /* Locate the position of the new node in the list */

            Node previous, current;
            previous = START;
            current = START;

            // Scan through the linked list until you find a node whose roll number is greater than the roll number of the new node.	
               while ((current != null) && (rollNo >= 
               current.rollNumber))
               {
                   if (rollNo == current.rollNumber)
                   {
                       Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                       return;
                   }
                   previous = current;
                   current = current.next;
               }
   /* Once the above for loop is executed, prev and current 
   are positioned in such a manner that the position for the new node is in between them. */
            newnode.next = current;
            previous.next = newnode;
        }




        public void delNode()/* Deletes the node
        from the list */
        {
            if (START.next != null)

                START = START.next;
            else
                START = null;
            
           
        }
        public void traverse() /* Displays the contents of the list */
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty.\n");
            else
            {

                Console.WriteLine("\nThe records in the list are :\n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.rollNumber + "  " +
                    currentNode.name + "\n");
                Console.WriteLine();
            }
        }

        public bool listEmpty() /* Checks whether the list is empty */
        {
            if (START == null)
                return true;
            else
                return false;
        }



        //public bool delNode(int rollNo)/* Deletes the specified node 
        //from the list */
        //{
        //    Node previous, current;
        //    previous = current = null;
        //    if (Search(rollNo, ref previous, ref current) ==
        //    false) /* Checks if the specified node is present in the 
        //    list or not */
        //        return false;
        //    /* If the node is present in the list, the following statements will be executed */
        //    previous.next = current.next;
        //    if (current == START)
        //        START = START.next;
        //    return true;
        //}


    }
}