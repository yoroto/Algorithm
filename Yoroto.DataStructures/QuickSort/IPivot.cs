using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures.QuickSort
{
    interface IPivot
    {
        int Pivot<T>(IList<T> items, int begin, int end) where T : IComparable<T>;
    }
}
