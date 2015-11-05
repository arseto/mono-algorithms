using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riddlers
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
            if (itemIdx == 0) return 0;
            if (itemIdx == 1) return 1;
            return GetItemValue(itemIdx - 2) + GetItemValue(itemIdx - 1);
        }

    }
}
