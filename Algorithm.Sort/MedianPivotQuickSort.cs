using System;

namespace Algorithm.Sort
{
    sealed class MedianPivotQuickSort<T> : QuickSort<T> where T : IComparable<T>
    {
        internal MedianPivotQuickSort(T[] initial) : base(initial) { }

        protected override int Pivot(int begin, int end)
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
