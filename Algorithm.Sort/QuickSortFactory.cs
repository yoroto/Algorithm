using System;

namespace Algorithm.Sort
{
    public static class QuickSortFactory
    {
        public enum PivotType
        {
            Median,
            Random
        }

        public static QuickSort<T> Create<T>(PivotType type, T[] inital) where T : IComparable<T>
        {
            switch (type)
            {
                case PivotType.Median:
                    return new MedianPivotQuickSort<T>(inital);
                case PivotType.Random:
                    return new RandomPivotQuickSort<T>(inital);
                default:
                    return new MedianPivotQuickSort<T>(inital);
            }
        }
    }
}
