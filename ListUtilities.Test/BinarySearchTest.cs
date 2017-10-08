using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Searching;

namespace AlgorithmsTest.Searching
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void BinarySearchEmptyList()
        {
            var nums = new int[] { };
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 0));
            Assert.AreEqual(0, BinarySearch.FindClosestIndex(nums, 0));
        }

        [TestMethod]
        public void FindIndexOnOddList()
        {
            var nums = new int[] { 1, 3, 5 };
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 0));
            Assert.AreEqual(0, BinarySearch.FindIndex(nums, 1));
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 2));
            Assert.AreEqual(1, BinarySearch.FindIndex(nums, 3));
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 4));
            Assert.AreEqual(2, BinarySearch.FindIndex(nums, 5));
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 6));
        }

        [TestMethod]
        public void FindIndexOnEvenList()
        {
            var nums = new int[] { 2, 4, 6, 8 };
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 1));
            Assert.AreEqual(0, BinarySearch.FindIndex(nums, 2));
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 3));
            Assert.AreEqual(1, BinarySearch.FindIndex(nums, 4));
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 5));
            Assert.AreEqual(2, BinarySearch.FindIndex(nums, 6));
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 7));
            Assert.AreEqual(3, BinarySearch.FindIndex(nums, 8));
            Assert.AreEqual(-1, BinarySearch.FindIndex(nums, 9));
        }

        [TestMethod]
        public void FindClosestIndexOnOddList()
        {
            var nums = new int[] { 1, 3, 5 };
            Assert.AreEqual(0, BinarySearch.FindClosestIndex(nums, 0));
            Assert.AreEqual(0, BinarySearch.FindClosestIndex(nums, 1));
            Assert.AreEqual(1, BinarySearch.FindClosestIndex(nums, 2));
            Assert.AreEqual(1, BinarySearch.FindClosestIndex(nums, 3));
            Assert.AreEqual(2, BinarySearch.FindClosestIndex(nums, 4));
            Assert.AreEqual(2, BinarySearch.FindClosestIndex(nums, 5));
            Assert.AreEqual(3, BinarySearch.FindClosestIndex(nums, 6));
        }

        [TestMethod]
        public void FindClosestIndexOnEvenList()
        {
            var nums = new int[] { 2, 4, 6, 8 };
            Assert.AreEqual(0, BinarySearch.FindClosestIndex(nums, 1));
            Assert.AreEqual(0, BinarySearch.FindClosestIndex(nums, 2));
            Assert.AreEqual(1, BinarySearch.FindClosestIndex(nums, 3));
            Assert.AreEqual(1, BinarySearch.FindClosestIndex(nums, 4));
            Assert.AreEqual(2, BinarySearch.FindClosestIndex(nums, 5));
            Assert.AreEqual(2, BinarySearch.FindClosestIndex(nums, 6));
            Assert.AreEqual(3, BinarySearch.FindClosestIndex(nums, 7));
            Assert.AreEqual(3, BinarySearch.FindClosestIndex(nums, 8));
            Assert.AreEqual(4, BinarySearch.FindClosestIndex(nums, 9));
        }
    }
}
