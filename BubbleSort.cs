using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class BubbleSort
    {
        public static void SortAsc(int[] unsortedInt)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < unsortedInt.Length; i++)
                {
                    if (unsortedInt[i] < unsortedInt[i - 1])
                    {
                        Swap(unsortedInt, i, i - 1);
                        swapped = true;
                    }
                }
            }
        }

        
        public static void SortDesc(int[] unsortedInt)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < unsortedInt.Length; i++)
                {
                    if (unsortedInt[i] > unsortedInt[i - 1])
                    {
                        Swap(unsortedInt, i, i-1);
                        swapped = true;
                    }
                }
            }
        }

        private static void Swap(int[] unsortedInt, int i, int j)
        {
            int temp = unsortedInt[i];
            unsortedInt[i] = unsortedInt[j];
            unsortedInt[j] = temp;
        }
    }
}
