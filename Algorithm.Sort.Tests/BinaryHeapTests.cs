using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using Algorithm.Sort;

namespace Algorithm.Sort.Tests
{
    [TestFixture(BinaryHeapFactory.TraverseType.Loop)]
    [TestFixture(BinaryHeapFactory.TraverseType.Recursive)]
    public class BinaryHeapTests
    {
        BinaryHeapFactory.TraverseType type;

        public BinaryHeapTests(BinaryHeapFactory.TraverseType type)
        {
            this.type = type;
        }

        [Test]        
        public void CreationTest()
        {
            BinaryHeap<int> heap = BinaryHeapFactory.Create<int>(type);
            Assert.That(heap.Count, Is.EqualTo(0));

            CheckHeapProperty<int>(heap);
        }

        [Test]
        public void CreationWithArrayTest()
        {
            int[] test = { 9, 12, 6, 28, 11 };
            BinaryHeap<int> heap = BinaryHeapFactory.Create<int>(type, test);
            Assert.That(heap.Count, Is.EqualTo(5));
            Assert.That(heap[0], Is.EqualTo(28));

            CheckHeapProperty<int>(heap);
        }
        
        [Test]
        public void AddTest()
        {
            int[] test = { 12, 13 };
            BinaryHeap<int> heap = BinaryHeapFactory.Create<int>(type, test);
            Assert.That(heap.Count, Is.EqualTo(2));
            Assert.That(heap[0], Is.EqualTo(13));

            heap.Add(14);
            Assert.That(heap.Count, Is.EqualTo(3));
            Assert.That(heap[0], Is.EqualTo(14));
            Assert.That(heap[2], Is.EqualTo(13));
        }

        [Test]
        [TestCase(new int[] { 9, 12, 6, 28, 11 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 108 })]
        [TestCase(new int[] { 108, 112 })]
        [TestCase(new int[] { 3, 2, 5, 2, 3 })]
        public void SortTest(int[] test)
        {
            BinaryHeap<int> heap = BinaryHeapFactory.Create<int>(type, test);

            CheckHeapProperty<int>(heap);
            bool sortedAlready = CheckSorted<int>(heap);

            BinaryHeap<int> sorted = heap.Sort();

            Assert.IsTrue(CheckSorted<int>(heap) == sortedAlready);
            Assert.IsTrue(CheckSorted<int>(sorted));
        }

        private void CheckHeapProperty<T>(BinaryHeap<T> heap) where T : IComparable<T>
        {
            for (int i = 0; i < (heap.Count - 1) / 2; i++)
            {
                Assert.That(heap[i].CompareTo(heap[2 * i + 1]) >= 0);
                Assert.That(heap[i].CompareTo(heap[2 * (i + 1)]) >= 0);
            }
        }

        private bool CheckSorted<T>(BinaryHeap<T> heap) where T : IComparable<T>
        {
            bool result = true;

            for (int i = 0; i < heap.Count - 1; i++)
            {
                if (heap[i].CompareTo(heap[i + 1]) < 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
