namespace _algorithm;
using MyNameSpace;
using MyNameSpace.Abc;
using SanPham;
using static System.Console;
using System.Linq;
using MyLib;
using MyException;
using System.Collections.Generic;

class Program
{
    // An optimized version of Bubble Sort
    static void bubbleSort(int[] arr, int n)
    {
        int i, j, temp;
        bool swapped;

        for (i = 0; i < n - 1; i++)
        {

            swapped = false;

            for (j = 0; j < n - i - 1; j++)
            {

                if (arr[j] > arr[j + 1])
                {
                    //swap arr[i] and arr[j+1]
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    // Console.WriteLine(arr[i]+ arr[j + 1]);

                    swapped = true;
                }
            }
            // IF no two elements were
            // swapped by inner loop, then break
            if (swapped == false)
            {
                break;
            }
        }
    }

    static void printArray(int[] arr, int size)
    {
        int i;
        for (i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i] + " ");

        }
    }
    static void Main(string[] args)
    {

        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        int n = arr.Length;
        bubbleSort(arr, n);
        Console.WriteLine("Sorted array");
        printArray(arr, n);
    }


}

