using System;
using System.Collections.Generic;
using System.IO;

namespace Median_handson
{
    class Program
    {

        //static void Main(string[] args)
        //{

        //    int count = int.Parse(Console.ReadLine());
        //    List<int> data = new List<int>();
        //    List<double> median = new List<double>();
        //    for (int i=0; i<count;i++)
        //    {
        //        int input = int.Parse(Console.ReadLine());
        //        data.Add(input);
        //       // 
        //    }
        //    median = RunningMedian(data);
        //    foreach (double x in median)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}
        //public static List<double> RunningMedian(List<int> dlist)
        //{
        //    List<double> dmed = new List<double>();
        //    double med;
        //    List<int> datas = new List<int>();
        //   // 

        //    foreach (var x in dlist)
        //    {
        //        datas.Add(x);
        //        datas.Sort();
        //        int i = datas.Count / 2;
        //        if (datas.Count % 2 == 0)
        //        {
        //            int j = i - 1;
        //            med = (double)(datas[j] + datas[i]) / 2.0;
        //        }
        //        else
        //        {
        //            med = datas[i];
        //        }
        //        dmed.Add(med);

        //    }
        //    return dmed;
        //}
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int aCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> data = new List<int>();
            // List<double> median = new List<double>();
            for (int i = 0; i < aCount; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine().Trim());
                data.Add(input);
            }

            List<double> result = Solution.runningMedian(data);
            foreach (double x in result)
            {
                Console.WriteLine(x);
            }
            //    textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }


    }

    class Solution
    {
        public static List<double> runningMedian(List<int> a)
        {
            List<double> dmed = new List<double>();
            double med;
            List<int> datas = new List<int>();
            // 

            foreach (var x in a)
            {
                datas.Add(x);
                datas.Sort();
                int i = datas.Count / 2;
                if (datas.Count % 2 == 0)
                {
                    int j = i - 1;
                    med = (double)(datas[j] + datas[i]) / 2.0;
                }
                else
                {
                    med = datas[i];
                }
                dmed.Add(med);

            }
            return dmed;
        }
    }
}
