using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using Algorithm.Sort;
using Algorithm.Sort.QuickSort;

namespace Algorithm.Sort.Tests
{
    [TestFixture(QuickSortFactory.PivotType.Median)]
    [TestFixture(QuickSortFactory.PivotType.Random)]
    public class QuickSortTests
    {
        QuickSortFactory.PivotType type;

        public QuickSortTests(QuickSortFactory.PivotType type)
        {
            this.type = type;
        }

        [Test]
        [TestCase(new int[] { 9, 12, 6, 28, 11 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(new int[] {})]
        [TestCase(new int[] { 108 })]
        [TestCase(new int[] { 108, 112 })]
        [TestCase(new int[] { 3, 2, 5, 2, 3})]
        public void SortTest(int[] test)
        {
            QuickSort<int> list = QuickSortFactory.Create<int>(type, test);

            list.Sort();

            for (int i = 0; i < list.Count - 1; i++)
            {
                Assert.That(list[i].CompareTo(list[i+1]) <= 0);
            }
        }

        [Test]
        [TestCase(new int[] { 9, 12, 6, 28, 11 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 108 })]
        [TestCase(new int[] { 108, 112 })]
        [TestCase(new int[] { 3, 2, 5, 2, 3 })]
        public void TwoEndPartitionTest(int[] test)
        {
            IList<int> list = new List<int>(test);

            TwoEndPartition partition = new TwoEndPartition(new MedianPivot());

            int pivot = partition.Partition<int>(list, 0, list.Count - 1);

            for (int i = 0; i < pivot; i++) 
            {
                Assert.That(list[i] <= list[pivot]);
            }

            for (int i = pivot + 1; i < list.Count; i++)
            {
                Assert.That(list[i] >= list[pivot]);
            }
        }

        [Test]
        [TestCase(new int[] { 9, 12, 6, 28, 11, 3, 119, 7, 10, 2, 23, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 108 })]
        [TestCase(new int[] { 108, 112 })]
        [TestCase(new int[] { 3, 2, 5, 2, 3 })]
        public void LoopQuickSortTest(int[] test)
        {
            LoopQuickSort<int> sort = new LoopQuickSort<int>(test, new TwoEndPartition(new MedianPivot()));

            sort.Sort();

            for (int i = 0; i < sort.Count - 1; i++)
            {
                Assert.That(sort[i].CompareTo(sort[i + 1]) <= 0);
            }
        }
    }
}
