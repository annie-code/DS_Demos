using System;

namespace DemoHeap
{
    public class MaxHeap
    {
        public int[] Array { get; private set; }

        public int Length { get; private set; }

        public MaxHeap(int[] input, int length)
        {
            this.Length = length;
            this.Array = input;
            BuildMaxHeap();
        }
        private void BuildMaxHeap()
        {
            for (int i = this.Length / 2; i > 0; i--)
            {
                MaxHeapify(i);
            }

            return;
        }
        public void MaxHeapify(int index)
        {
            var left = 2 * index;///2
            var right = 2 * index + 1;//3

            int max = index;//1
            if (left <= this.Length && this.Array[left - 1] > this.Array[index - 1])
            {
                max = left;
            }

            if (right <= this.Length && this.Array[right - 1] > this.Array[max - 1])
            {
                max = right;
            }

            if (max != index)
            {
                int temp = this.Array[max - 1];
                this.Array[max - 1] = this.Array[index - 1];
                this.Array[index - 1] = temp;
                MaxHeapify(max);
            }

            return;
        }

       

            public int RemoveMaximum()
        {
            int maximum = this.Array[0];

            this.Array[0] = this.Array[this.Length - 1];
            this.Length--;
            MaxHeapify(1);
            return maximum;
        }
    

}
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 40, 60, 10, 20, 50, 30 };
            MaxHeap heap = new MaxHeap(ar, 6);
            //
            Console.WriteLine("Printing maxified");
            foreach (int i in ar) Console.WriteLine(i);
            Console.WriteLine("Remove highest");
            Console.WriteLine(heap.RemoveMaximum());
            //Console.WriteLine("Printing after remove");
            ar[ar.Length - 1] = 0;
            foreach (int i in ar) Console.WriteLine(i);
            Console.Read();
        }
    }
}
