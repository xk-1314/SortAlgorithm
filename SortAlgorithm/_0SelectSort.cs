using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortAlgorithm
{
    /// <summary>
    /// 选择排序
    /// </summary>
    public class _0SelectSort : IMySort
    {
        //首先，找到数组中最小的那个元素，其次，将它和数组的第一个元素交换位置(如果第一个元素就是最小元素那么它就和自己交换)。
        //其次，在剩下的元素中找到最小的元素，将它与数组的第二个元素交换位置。
        //如此往复，直到将整个数组排序。这种方法我们称之为选择排序。
        //性质：1、时间复杂度：O(n2)  2、空间复杂度：O(1)  3、非稳定排序  4、原地排序
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return arr;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int minIndex;
            int temp;
            int n = arr.Length;
            for (int i = 0 ; i < n - 1 ; i++)
            {
                minIndex = i;
                for (int j = i + 1 ; j < n ; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("选择排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }

        public int[] selectSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0 ; i < n - 1 ; i++)
            {
                int min = i;
                for (int j = i + 1 ; j < n ; j++)
                {
                    if (a[min] > a[j]) min = j;
                }
                //交换
                int temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
            return a;
        }
    }
}
