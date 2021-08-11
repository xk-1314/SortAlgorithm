using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十大排序算法
{
    /// <summary>
    /// 基数排序
    /// </summary>
    public class _9RadixSort : IMySort
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
            Console.WriteLine("基数排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }
    }
}
