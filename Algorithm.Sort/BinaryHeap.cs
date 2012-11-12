using System;
using System.Collections.Generic;

namespace Algorithm.Sort
{
    public abstract class BinaryHeap<T> where T : IComparable<T>
    {
        protected IList<T> heap = new List<T>();

        public int Count
        {
            get
            {
                return heap.Count;
            }
        }

        public T this[int index] 
        { 
            get
            {
                return heap[index];   
            } 
        }

        internal BinaryHeap() { }

        internal BinaryHeap(T[] initial)
        {
            BuildMaxHeap(initial);
        }

        public void Add(T item)
        {
            heap.Add(item);
            HeapIncreaseKey(heap.Count - 1);
        }

        public BinaryHeap<T> Sort()
        {
            BinaryHeap<T> sorted = this.NewInstance();
            sorted.heap = new List<T>(this.heap);
            sorted.HeapSort();

            return sorted;
        }

        private void HeapSort()
        {
            IList<T> temp = new List<T>();

            while (this.heap.Count > 0)
            {
                temp.Add(this.heap[0]);
                this.heap.RemoveAt(0);
                MaxHeapify(0);
            }

            this.heap = new List<T>(temp);
        }

        protected abstract BinaryHeap<T> NewInstance();

        protected abstract void MaxHeapify(int i);

        protected abstract void HeapIncreaseKey(int i);

        internal void BuildMaxHeap(T[] input)
        {
            heap = new List<T>(input);

            for (int i = heap.Count / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(i);
            }
        }

        protected static int Left(int i)
        {
            return 2 * i + 1;
        }

        protected static int Right(int i)
        {
            return 2 * (i + 1);
        }

        protected static int Parent(int i)
        {
            return (i - 1) / 2;
        }

        protected void Swap(int i, int j)
        {
            lock(heap)
            {
                if (i < heap.Count && j < heap.Count)
                {
                    T temp = heap[i];
                    heap[i] = heap[j];
                    heap[j] = temp;
                }
            }
        }

    }
}
