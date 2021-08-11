using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class _5QuickSort : IMySort
    {
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return arr;
            Stopwatch sw = new Stopwatch();
            sw.Start();


            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("快速排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }
    }
}
