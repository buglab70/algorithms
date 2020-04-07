using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[13] { 9, 10, 6, 1, 3, 2, 7, 0, 11, 8, 4, 33,-9 };
            MergeSort(arr, 0, arr.Length - 1);
            Console.ReadLine();
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int i = 0, j = 0, k = l;
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int t = 0; t < n1; t++)
            {
                L[t] = arr[l + t];
            }
            for (int t = 0; t < n2; t++)
            {
                R[t] = arr[m + 1 + t];
            }

            while(i < n1 && j < n2)
            {
                if(L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while(i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private static void MergeSort(int[] arr, int l, int r)
        {
            if(l < r)
            {
                int m = l + (r - l) / 2;

                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }

                PrintArray(arr);
        }

        private static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
