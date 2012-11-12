using System;
using System.Collections.Generic;

namespace Algorithm.Sort.QuickSort
{
    class RandomPivot : IPivot
    {
        public int Pivot<T>(IList<T> items, int begin, int end) where T : IComparable<T>
        {
            Random rand = new Random();

            return rand.Next(begin, end);
        }
    }
}
