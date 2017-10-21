using NUnit.Framework;
using System;
using Sort;

namespace Sort.Tests
{
    [TestFixture()]
    public class QuickAndMergeSortTests
    {
        [TestCase(1, 3, 4, 2, 0, -5)]
        [TestCase(1, 2, 0, 2, 2, -123)]
        [TestCase(5, 4, 3, 2, 1, 0, -1)]
        public static void QSort_PositiveTests(params int[] array)
        {
            int[] expectedArray = new int[array.Length];
            Array.Copy(array, expectedArray, array.Length);
            Array.Sort(expectedArray);
            QuickAndMergeSort.QSort(array);
            Assert.AreEqual(array, expectedArray);
        }

        [TestCase(null)]
        public static void QSort_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => QuickAndMergeSort.QSort(array));
        }

        [TestCase(1, 3, 4, 2, 0, -5)]
        [TestCase(1, 2, 0, 2, 2, -123)]
        [TestCase(5, 4, 3, 2, 1, 0, -1)]
        public static void MSort_PositiveTests(params int[] array)
        {
            int[] expectedArray = new int[array.Length];
            Array.Copy(array, expectedArray, array.Length);
            Array.Sort(expectedArray);
            QuickAndMergeSort.MSort(array);
            Assert.AreEqual(array, expectedArray);
        }

        [TestCase(null)]
        public static void MSort_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => QuickAndMergeSort.MSort(array));
        }
    }
}