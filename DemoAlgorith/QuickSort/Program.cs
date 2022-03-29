using System;

namespace QuickSort
{
    class List
    {
        // Array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count; // Number of comparisons
        private int mov_count; // Number of data movements
        // Number of elements in array
        private int n;
        public List()
        {
            cmp_count = 0;
            mov_count = 0;
        }
        public void read()
        {
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
            Console.WriteLine("\n-----------------------");
            Console.WriteLine(" Enter array elements  ");
            Console.WriteLine("-----------------------");

            // Get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
       
        public void q_sort(int low, int high)
        {
            int pivot, i, j;

            if (low > high)
                return;

            /* Partition the list into two parts:
             One containing elements less than or equal to pivot
             Other containing elements greater than pivot */

            i = low + 1;  //index 1
            j = high;    //index 9

            pivot = arr[low];// pivot=8

            while (i <= j)//8,4,1,3,7,6,2,5,9,10   i=8  j=8
            {
                // Search for an element greater than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;
                //i=5
                // Search for an element less than or equal to pivot
                //j=9
                while ((arr[j] > pivot) && (j >= low))// j=7
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j)  /* If the greater element is on the 
                		      left of the smaller element */
                {
                    /* Swap the element at index i with the element 
   at index j */
                    swap(i, j);//8,4,1,3,7,6,2,5,9,10 
                    mov_count++;
                }
            }

            /* j now contains the index of the last element in the 
   sorted list. */

            if (low < j)////8,4,1,3,7,6,2,5,9,10   i=8  j=7
            {
                swap(low, j);    /* Move the pivot to its correct 
    position in the list */
                mov_count++;
            }
            //5,4,1,3,7,6,2,8,9,10   i=8  j=7
            //Sort the list on the left of pivot using quick sort
            q_sort(low, j - 1);

            //Sort the list on the right of pivot using quick sort
            q_sort(j + 1, high);
        }
        void swap(int x, int y) /* Swaps the element at index x with 
 the element at index y */
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public int getSize()
        {
            return (n);
        }
       public void display()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("-----------------------");


            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }

            Console.WriteLine("\nNumber of comparisons: " +
cmp_count);
            Console.WriteLine("\nNumber of data movements: " +
mov_count);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring the object of the class
            List myList = new List();

            // Accept array elements
            myList.read();

            // Calling the sorting function
            myList.q_sort(0, myList.getSize() - 1); /* First call to 
  Quick Sort 
  Algorithm */

            // Display sorted array
            myList.display();

            // To exit from the console
            Console.WriteLine("\n\nPress Enter to exit.");
            Console.Read();

        }
    }
}
