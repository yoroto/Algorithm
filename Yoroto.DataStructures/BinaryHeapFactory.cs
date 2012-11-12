using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures
{
    public static class BinaryHeapFactory
    {
        public enum TraverseType
        {
            Loop,
            Recursive
        }

        public static BinaryHeap<T> Create<T>(TraverseType type) where T : IComparable<T>
        {
            switch (type)
            {
                case TraverseType.Loop:
                    return new LoopBinaryHeap<T>();
                case TraverseType.Recursive:
                    return new RecursiveBinaryHeap<T>();
                default:
                    return new LoopBinaryHeap<T>();
            }
        }

        public static BinaryHeap<T> Create<T>(TraverseType type, T[] initial) where T : IComparable<T>
        {
            switch (type)
            {
                case TraverseType.Loop:
                    return new LoopBinaryHeap<T>(initial);
                case TraverseType.Recursive:
                    return new RecursiveBinaryHeap<T>(initial);
                default:
                    return new LoopBinaryHeap<T>(initial);
            }
        }
    }
}
