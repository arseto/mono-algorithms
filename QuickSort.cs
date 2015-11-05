using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riddlers
{
    class QuickSort
    {
        public static int[] SortAsc(int[] unsorted)
        {
            if (unsorted.Length <= 1) return unsorted;
            int pivot = GetPivot(unsorted);
            List<int> less = new List<int>(), greater = new List<int>();
            foreach (int x in unsorted)
            {
                if (x < pivot) less.Add(x);
                else if (x > pivot) greater.Add(x);
            }
            return SortAsc(less.ToArray()).Concat(new int[1] { pivot }).Concat(SortAsc(greater.ToArray())).ToArray();
        }

        public static int[] SortDesc(int[] unsorted)
        {
            if (unsorted.Length <= 1) return unsorted;
            int pivot = GetPivot(unsorted);
            List<int> less = new List<int>(), greater = new List<int>();
            foreach (int x in unsorted)
            {
                if (x < pivot) less.Add(x);
                else if (x > pivot) greater.Add(x);
            }
            return SortDesc(greater.ToArray()).Concat(new int[1] { pivot }).Concat(SortDesc(less.ToArray())).ToArray();
        }

        static int GetPivot(int[] array)
        {
            return array[array.Length / 2];
        }
    }
}
