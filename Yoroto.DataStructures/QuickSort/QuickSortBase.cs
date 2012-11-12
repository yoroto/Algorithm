using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures.QuickSort
{
	abstract class QuickSortBase<T> where T : IComparable<T>
	{
		protected IList<T> items;
		protected IPartition partition;
		
		internal QuickSortBase(T[] initial, IPartition partition)
		{
			this.items = new List<T>(initial);
			this.partition  = partition;
		}
		
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
	}
}
