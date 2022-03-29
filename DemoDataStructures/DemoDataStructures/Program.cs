using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack names = new Stack();
            names.Push("Jai");
            names.Push(1);
            Stack<int> marks = new Stack<int>();
            marks.Push(23);
            marks.Push(2);
        }
    }
}
