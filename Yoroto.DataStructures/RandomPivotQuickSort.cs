using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures
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
