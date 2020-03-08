using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 4, 0, 5, 6, 7, 0, 8, 0 };
            int[] result = SetZeroToEnd(arr);
            // int[] result = SetZeroToStart(arr);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();

        }

        public static int[] SetZeroToEnd(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - count; i++)
            {
                if(arr[i]==0)
                {
                    for (int j = i; j < arr.Length-1; j++)
                    {
                        arr[j] = arr[j + 1];
                        arr[j + 1] = 0;
                    }
                    count++;
                }
            }
            return arr;
        }
        public static int[] SetZeroToStart(int[] arr)
        {
            int len = arr.Length;
            int count = 0;
            for (int i = len-1; i >= count; i--)
            {
                if(arr[i]==0)
                {
                    for (int j = i; j > 0; j--)
                    {
                        arr[j] = arr[j - 1];
                        arr[j - 1] = 0;
                    }
                    count++;
                }
            }

            return arr;
        }
    }
}
