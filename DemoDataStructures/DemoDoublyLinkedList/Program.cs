using System;

namespace DemoDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinked obj = new DoublyLinked();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a record from the list");
                    Console.WriteLine("3. View all records in the order");
                    Console.WriteLine("4. View all records in the reverse order");
                    Console.WriteLine("5. Search for a record in the list");
                    Console.WriteLine("6. Add a record to the sorted list");
                    Console.WriteLine("7. Exit\n");
                    Console.Write("Enter your choice (1-6): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.AddNodeBegining();
                            }
                            break;
                        case '2':
                            {
                                obj.DelNode();
                                   
                                    Console.WriteLine("Record with roll number  deleted \n");
                            }
                            break;
                        case '3':
                            {
                                obj.DirectTraverse();
                            }
                            break;
                        case '4':
                            {
                                obj.RevTraverse();
                            }
                            break;
                        case '5':
                            //{
                            //    if (obj.listEmpty() == true)
                            //    {
                            //        Console.WriteLine("\nList is empty");
                            //        break;
                            //    }
                            //    Node prev, curr;
                            //    prev = curr = null;
                            Console.Write("\nEnter the roll number of the student whose record you want to search: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            string name = "";
                            if (obj.Search(num,out  name) == false)
                                Console.WriteLine("\nRecord not found");
                            else
                            {
                                Console.WriteLine("\nRecord found");
                                Console.WriteLine("\nRoll number: " + num);
                                Console.WriteLine("\nName: " + name);
                            }
                    
                    break;
                        case '6':obj.addNodeSoerted();break;
                        case '7':
                            return;
                        default:
                            {
                                Console.WriteLine("\nInvalid option");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}

       