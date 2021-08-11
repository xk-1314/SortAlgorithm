using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /// <summary>
    /// 计数排序
    /// </summary>
    public class _7CountSort : IMySort
    {
        //非优化版本
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
            Console.WriteLine("计数排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }

        //优化版本
        public int[] OptimizeSort(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();


            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("优化计数排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }
    }
}
