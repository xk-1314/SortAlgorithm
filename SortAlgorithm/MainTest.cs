using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    //1、稳定排序：如果 a 原本在 b 的前面，且 a == b，排序之后 a 仍然在 b 的前面，则为稳定排序。

    //2、非稳定排序：如果 a 原本在 b 的前面，且 a == b，排序之后 a 可能不在 b 的前面，则为非稳定排序。

    //3、原地排序：原地排序就是指在排序过程中不申请多余的存储空间，只利用原来存储待排数据的存储空间进行比较和交换的数据排序。

    //4、非原地排序：需要利用额外的数组来辅助排序。

    //5、时间复杂度：一个算法执行所消耗的时间。

    //6、空间复杂度：运行完一个算法所需的内存大小。
    public class MainTest
    {
        public static void Main(string[] args)
        {
            int capacity = 30;
            int[] arr = new int[capacity];
            for (int i = 0 ; i < capacity ; i++)
            {
                arr[i] = i + 1;
            }
            //_0SelectSort s0 = new _0SelectSort();
            //arr = Shuffle_1(arr);
            //arr = s0.Sort(arr);
            //_1InsertSort s1 = new _1InsertSort();
            //arr = Shuffle_1(arr);
            //arr = s1.Sort(arr);
            _2BubbleSort s2 = new _2BubbleSort();
            arr = Shuffle_1(arr);
            arr = s2.Sort(arr);
            arr = Shuffle_1(arr);
            arr = s2.OptimizeSort(arr);
            //Test();
            Console.ReadKey();
        }

        public static void Test()
        {

        }
        #region 打乱数组

        private static int[] Shuffle_1(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Random random = new Random();
            int index = 0;
            int capacity = arr.Length;
            List<int> shuffle = new List<int>();
            shuffle.AddRange(arr);
            arr = new int[capacity];
            for (int i = 0 ; i < capacity ; i++)
            {
                index = random.Next(0, shuffle.Count);
                arr[i] = shuffle[index];
                shuffle.RemoveAt(index);
            }
            for (int i = 0 ; i < capacity ; i++)
            {
                Console.Write(arr[i] + " ");
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("洗牌耗时: {0}ms", ts.TotalMilliseconds);
            return arr;
        }

        public static void Shuffle_2(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<int> list = new List<int>();
            list.AddRange(arr);
            List<int> newList = new List<int>();
            int index;
            foreach (int item in list)
            {
                Random r = new Random();
                index = r.Next(0, newList.Count);
                newList.Insert(index, item);
            }
            arr = newList.ToArray();
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("洗牌耗时: {0}ms", ts.TotalMilliseconds);
        }
        #endregion
    }
}
