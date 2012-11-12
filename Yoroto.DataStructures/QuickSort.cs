using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures
{
    public abstract class QuickSort<T> where T : IComparable<T>
    {
        protected IList<T> items;

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
        }

        internal QuickSort(T[] initial)
        {
            items = new List<T>(initial);
        }

        public void Sort()
        {
            Sort(0, items.Count - 1);
        }

        protected abstract int Pivot(int begin, int end);

        private int Partition(int begin, int end)
        {
            int pivot = Pivot(begin, end);

            if (pivot != end)
            {
                Swap(pivot, end);
            }
            
            int i = begin - 1;
            for (int j = begin; j < end; j++)
            {
                if (items[j].CompareTo(items[end]) <= 0)
                {
                    Swap(j, ++i);
                }
            }
            Swap(end, ++i);

            return i;
        }

        private void Sort(int begin, int end)
        {
            if (end > begin)
            {
                int pivot = Partition(begin, end);
                Sort(begin, pivot - 1);
                Sort(pivot + 1, end);
            }
        }

        private void Swap(int i, int j)
        {
            lock (items)
            {
                if (i < items.Count() && j < items.Count())
                {
                    T temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
}
