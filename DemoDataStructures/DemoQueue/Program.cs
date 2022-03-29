using System;
using System.Collections;
namespace DemoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queues q = new Queues();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Implement insert operation in the queue");
                    Console.WriteLine("2. Implement a delete operation on the queue");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                q.insert(num);
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
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
                Queue qu = new Queue();
                qu.Enqueue(67);
                qu.Enqueue(61);
                qu.Enqueue(27);

            }
        }

    }
}

