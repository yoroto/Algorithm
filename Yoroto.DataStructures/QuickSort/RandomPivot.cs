using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures.QuickSort
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
