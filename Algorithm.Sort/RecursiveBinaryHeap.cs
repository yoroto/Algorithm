using System;

namespace Algorithm.Sort
{
    sealed class RecursiveBinaryHeap<T> : BinaryHeap<T> where T : IComparable<T>
    {
        internal RecursiveBinaryHeap() : base() { }

        internal RecursiveBinaryHeap(T[] initial) : base(initial) { }

        protected override BinaryHeap<T> NewInstance()
        {
             return new RecursiveBinaryHeap<T>();
        }

        protected override void MaxHeapify(int i)
        {
            if (Left(i) < heap.Count)
            {
                int biggerChild = Right(i) >= heap.Count || heap[Left(i)].CompareTo(heap[Right(i)]) > 0 ? Left(i) : Right(i);

                if (heap[i].CompareTo(heap[biggerChild]) < 0)
                {
                    Swap(i, biggerChild);

                    MaxHeapify(biggerChild);
                }
            }
        }

        protected override void HeapIncreaseKey(int i)
        {
            if (i > 0 && heap[i].CompareTo(heap[Parent(i)]) > 0)
            {
                Swap(i, Parent(i));

                HeapIncreaseKey(Parent(i));
            }
        }
    }
}
