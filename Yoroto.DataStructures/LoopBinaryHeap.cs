using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures
{
    sealed class LoopBinaryHeap<T> : BinaryHeap<T> where T : IComparable<T>
    {
        internal LoopBinaryHeap() : base() { }

        internal LoopBinaryHeap(T[] initial) : base(initial) { }

        protected override BinaryHeap<T> NewInstance()
        {
            return new LoopBinaryHeap<T>();
        }

        protected override void MaxHeapify(int i)
        {
            while (i < heap.Count / 2)
            {
                int biggerChild = Right(i) >= heap.Count || heap[Left(i)].CompareTo(heap[Right(i)]) > 0 ? Left(i) : Right(i);

                if (heap[i].CompareTo(heap[biggerChild]) >= 0)
                {
                    break;
                }

                Swap(i, biggerChild);

                i = biggerChild;
            }
        }

        protected override void HeapIncreaseKey(int i)
        {
            while (i > 0 && heap[i].CompareTo(heap[Parent(i)]) > 0)
            {
                Swap(i, Parent(i));

                i = Parent(i);
            }
        }
    }
}
