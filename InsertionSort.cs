using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 23, 1, 10, 5, 2 };
            Sort(arr);
            Console.ReadLine();
        }

        static void Sort(int[] arr)
        {
            int key = 0;
            int j = 0;
            int step = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                step++;
                ShowArray(arr, step);
            }
        }

        static void ShowArray(int[] a, int step)
        {
            Console.Write("Addım " + step + ": ");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
