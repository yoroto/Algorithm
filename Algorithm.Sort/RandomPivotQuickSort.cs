using System;

namespace Algorithm.Sort
{
    sealed class RandomPivotQuickSort<T> : QuickSort<T> where T : IComparable<T>
    {
        internal RandomPivotQuickSort(T[] initial) : base(initial) { }

        protected override int Pivot(int begin, int end)
        {
            Random rand = new Random();

            return rand.Next(begin, end);
        }
    }
}
