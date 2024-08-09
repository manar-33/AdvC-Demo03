using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_Demo03
{
    public delegate bool CompareFuncDelegate(int x, int y);
    internal class SortingAlgorithms
    {
        public static void SWAP(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        public static void BubbleSort(int[] array, CompareFuncDelegate compareFunc)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        //if (array[j] > array[j + 1])
                        if(compareFunc.Invoke(array[j], array[j + 1]))
                            { SWAP(ref array[j], ref array[j + 1]); }
                           
                    }
                }
            }

        }
        //public static void BubbleSortDesc(int[] array)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (array[j] < array[j + 1])
        //                    SWAP(ref array[j], ref array[j + 1]);
        //            }
        //        }
        //    }
        //}
    }
}
