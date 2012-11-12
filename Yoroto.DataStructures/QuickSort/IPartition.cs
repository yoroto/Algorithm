using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures.QuickSort
{
    interface IPartition
    {
        int Partition<T>(IList<T> items, int begin, int end) where T : IComparable<T>;
    }
}
