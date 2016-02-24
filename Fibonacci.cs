using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Fibonacci
    {
        public static int[] GetSeries(int startIndex, int endIndex)
        {
            int[] result = new int[endIndex - startIndex];
            int resultIdx = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                result[resultIdx] = GetItemValue(i);
                resultIdx++;
            }
            return result;
        }

        public static int GetItemValue(int itemIdx)
        {
            if (itemIdx == 0 || itemIdx == 1) return itemIdx;
            //return GetItemValue(itemIdx - 2) + GetItemValue(itemIdx - 1);
            int firstnumber = 0;
            int secondnumber = 1;
            int result = 0;
            for (int x = 2; x <= itemIdx; x++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }

    }
}
