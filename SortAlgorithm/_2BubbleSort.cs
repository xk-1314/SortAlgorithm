using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class _2BubbleSort : IMySort
    {
        //把第一个元素与第二个元素比较，如果第一个比第二个大，则交换他们的位置。接着继续比较第二个与第三个元素，如果第二个比第三个大，则交换他们的位置….

        //我们对每一对相邻元素作同样的工作，从开始第一对到结尾的最后一对，这样一趟比较交换下来之后，排在最右的元素就会是最大的数。

        //除去最右的元素，我们对剩余的元素做同样的工作，如此重复下去，直到排序完成。

        //性质：1、时间复杂度：O(n2)  2、空间复杂度：O(1)  3、稳定排序  4、原地排序
        //非优化版本
        public int[] Sort(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (arr == null || arr.Length < 2)
                return arr;
            int n = arr.Length;
            int temp;
            for (int i = 0 ; i < n - 1 ; i++)
            {
                for (int j = 0 ; j < n - i - 1 ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("冒泡排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }

        //优化版本
        public int[] OptimizeSort(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (arr == null || arr.Length < 2)
                return arr;
            int n = arr.Length;
            int temp;
            for (int i = 0 ; i < n - 1 ; i++)
            {
                bool isSwap = false;
                for (int j = 0 ; j < n - i - 1 ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        isSwap = true;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                if (!isSwap)
                    break;
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("优化冒泡排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }

        public int[] bubbleSort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                return arr;
            }
            int n = arr.Length;
            for (int i = 0 ; i < n ; i++)
            {
                for (int j = 0 ; j < n - i - 1 ; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            return arr;
        }

        public int[] optimizeBubbleSort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                return arr;
            }
            int n = arr.Length;
            for (int i = 0 ; i < n ; i++)
            {
                bool flag = true;
                for (int j = 0 ; j < n - i - 1 ; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        flag = false;
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
                //一趟下来是否发生位置交换
                if (flag)
                    break;
            }
            return arr;
        }
    }
}
