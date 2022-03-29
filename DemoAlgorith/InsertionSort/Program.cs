using System;

namespace InsertionSort
{
    class List
    {
        // Array of integers to hold values
        private int[] a = new int[20];

        // Number of elements in array
        private int n;

        // Function to accept array elements
        public void read()
        {
            // Get the number of elements to store in the array
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n > 0 && n <= 20)
                    break;
                else if (n > 20)
                    Console.WriteLine("\nArray can have maximum 20 elements.\n");
                else if (n < 0)
                    Console.WriteLine("\nEnter positive number.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Enter array elements  ");
            Console.WriteLine("-----------------------");


            // User inputs for the array 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Display the sorted array
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("-----------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
        }

        // Function to sort using Insertion sort
        public void InsertionSort()
        {
            for (int i = 1; i <= n - 1; i++)   ////3 2 4 1
            {
                int temp = a[i];//temp=1
                int j = i - 1;//j=2  1 2 3 4

                while ((j >= 0) && (a[j] > temp))
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = temp;
            }


        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            // Creating the object of the InsertionSort class
            List myList = new List();

            // Function call to accept array elements
            myList.read();


            // Function call to sort array
            myList.InsertionSort();

            // Function call to display the sorted array
            myList.display();

            // To exit from the console
            Console.WriteLine("\n\nPress the Enter key to exit.");
            Console.Read();
        }
    }
}
