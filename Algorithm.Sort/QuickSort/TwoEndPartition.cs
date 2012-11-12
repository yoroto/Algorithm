using System;
using System.Collections.Generic;

namespace Algorithm.Sort.QuickSort
{
    class TwoEndPartition : IPartition
    {
        IPivot pv;

        public TwoEndPartition(IPivot pv)
        {
            this.pv = pv;
        }

        public int Partition<T>(IList<T> items, int begin, int end) where T : IComparable<T>
        {
            if (end > begin)
            {
                int pivot = pv.Pivot<T>(items, begin, end);

                if (pivot != end)
                {
                    Utils.Swap<T>(items, pivot, end);
                }

                pivot = end;
                int front = begin;
                int back = end - 1;

                while (back >= front)
                {
                    if (items[back].CompareTo(items[pivot]) >= 0)
                    {
                        Utils.Swap<T>(items, pivot, back);
                        pivot = back;
                        back--;
                    }
                    else
                    {
                        if (items[front].CompareTo(items[pivot]) >= 0)
                        {
                            Utils.Swap<T>(items, front, back);
                        }
                        front++;
                    }
                }

                return pivot;
            }
            return begin;
        }
    }
}
