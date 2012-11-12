using System;
using System.Collections.Generic;

namespace Algorithm.Sort.QuickSort
{
    class LoopQuickSort<T> : QuickSortBase<T> where T : IComparable<T>
    {
        internal LoopQuickSort(T[] initial, IPartition partition)
            : base(initial, partition) { }
            
        public void Sort()
        {
            Stack<int> pivots = new Stack<int>();
            
            int finished = items.Count;
            int pivot = -1;

            while (finished > 0)
            {
                if (finished - pivot > 2)
                {
                    if (pivot > 0)
                    {
                        pivots.Push(pivot);
                    }

                    pivot = partition.Partition<T>(items, pivot + 1, finished - 1);
                }
                else
                {
                    finished = pivot;
                    if (pivots.Count > 0)
                    {
                        pivot = pivots.Pop();
                    }
                    else
                    {
                        pivot = -1;
                    }
                }
            }
        }
    }
}