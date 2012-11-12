using System;
using System.Collections.Generic;

namespace Algorithm.Sort.QuickSort
{
    interface IPartition
    {
        int Partition<T>(IList<T> items, int begin, int end) where T : IComparable<T>;
    }
}
