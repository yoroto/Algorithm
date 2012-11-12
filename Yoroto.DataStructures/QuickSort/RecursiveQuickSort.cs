using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures.QuickSort
{
	class RecursiveQuickSort<T> : QuickSortBase<T> where T : IComparable<T>
	{
		internal RecursiveQuickSort(T[] initial, IPartition partition)
			: base(initial, partition) { }
		
		public void Sort()
		{
			Sort(0, items.Count - 1);
		}
		
		void Sort(int begin, int end)
		{
			if (end > begin)
            {
                int pivot = partition.Partition(items, begin, end);
                Sort(begin, pivot - 1);
                Sort(pivot + 1, end);
            }
		}
	}
}
