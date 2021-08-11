using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /// <summary>
    /// 插入排序
    /// </summary>
    public class _1InsertSort : IMySort
    {
        //1、从数组第2个元素开始抽取元素。

        //2、把它与左边第一个元素比较，如果左边第一个元素比它大，则继续与左边第二个元素比较下去，直到遇到不比它大的元素，然后插到这个元素的右边。

        //3、继续选取第3，4，….n个元素,重复步骤 2 ，选择适当的位置插入。

        //性质：1、时间复杂度：O(n2)  2、空间复杂度：O(1)  3、稳定排序  4、原地排序
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return arr;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int temp;
            for (int i = 1 ; i < arr.Length ; i++)
            {
                temp = arr[i];
                for (int j = i - 1 ; j >= 0 ; j--)
                {
                    if (temp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        if (j == 0)
                        {
                            arr[0] = temp;
                            break;
                        }
                    }
                    else
                    {
                        arr[j + 1] = temp;
                        break;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("插入排序耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }

        public int[] insertSort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return arr;

            int n = arr.Length;
            for (int i = 1 ; i < n ; i++)
            {
                int temp = arr[i];
                int k = i - 1;
                while (k >= 0 && arr[k] > temp)
                    k--;
                //腾出位置插进去,要插的位置是 k + 1;
                for (int j = i ; j > k + 1 ; j--)
                    arr[j] = arr[j - 1];
                //插进去
                arr[k + 1] = temp;
            }
            return arr;
        }
    }
}
