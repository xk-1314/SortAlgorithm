using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /// <summary>
    /// 桶排序
    /// </summary>
    public class _8BucketSort : IMySort
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
            Console.WriteLine("桶排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }
    }
}
