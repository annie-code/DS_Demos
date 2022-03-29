using System;

namespace DemoLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList q = new LinkedList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Implement insert ");
                    Console.WriteLine("2. Implement a delete");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Insert sorted");
                    Console.WriteLine("5. Exit");
                    Console.Write("\nEnter your choice (1-5): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
            {
                case '1':
                    {
                        
                        q.addNode();
                    }
                    break;
                case '2':
                    {
                        q.delNode();
                    }
                    break;
                case '3':
                    {
                        q.traverse();
                    }
                    break;
                        case '4':q.addSortedNode();
                            break;
                        case '5':
                    return;
                default:
                    {
                        Console.WriteLine("Invalid option!!");
                        break;
                    }
            }
        }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered." + e.ToString());
                }
}
        }
           
        }
    }
