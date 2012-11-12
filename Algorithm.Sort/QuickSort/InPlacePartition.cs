using System;
using System.Collections.Generic;

namespace Algorithm.Sort.QuickSort
{
    class InPlacePartition : IPartition
    {
        IPivot pv;

        public InPlacePartition(IPivot pv)
        {
            this.pv = pv;
        }

        public int Partition<T>(IList<T> items, int begin, int end) where T : IComparable<T>
        {
            int pivot = pv.Pivot<T>(items, begin, end);

            if (pivot != end)
            {
                Utils.Swap<T>(items, pivot, end);
            }

            int i = begin - 1;
            for (int j = begin; j < end; j++)
            {
                if (items[j].CompareTo(items[end]) <= 0)
                {
                    Utils.Swap<T>(items, j, ++i);
                }
            }
            Utils.Swap<T>(items, end, ++i);

            return i;
        }
    }
}
