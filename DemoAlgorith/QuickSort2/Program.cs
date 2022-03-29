using System;

namespace QuickSort2
{
    public class QSort
    {
       public static void exchange( int[]arr,int x, int y) /* Swaps the element at index x with 
 the element at index y */
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)//i=>place where we found a value higher than pivot
                { i++; }
                while (x < data[j])//j==>where the value is smller than pivot
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        public static void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;

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
            int[] arr = new int[n];
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
            QuickSort2.QSort.IntArrayQuickSort(arr);
            Console.WriteLine("\n-----------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("-----------------------");


            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
