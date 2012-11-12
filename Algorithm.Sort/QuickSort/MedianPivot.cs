using System;
using System.Collections.Generic;

namespace Algorithm.Sort.QuickSort
{
    class MedianPivot : IPivot
    {
        public int Pivot<T>(IList<T> items, int begin, int end) where T : IComparable<T>
        {
            int pivot = begin + (end - begin) / 2;
            if (items[pivot].CompareTo(items[begin]) >= 0 && items[begin].CompareTo(items[end]) >= 0
                || items[end].CompareTo(items[begin]) >= 0 && items[begin].CompareTo(items[pivot]) >= 0
               )
            {
                pivot = begin;
            }
            else if (items[pivot].CompareTo(items[end]) >= 0 && items[end].CompareTo(items[begin]) >= 0
                || items[begin].CompareTo(items[end]) >= 0 && items[end].CompareTo(items[pivot]) >= 0
                )
            {
                pivot = end;
            }

            return pivot;
        }
    }
}
