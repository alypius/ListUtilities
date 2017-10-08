using System;
using System.Collections.Generic;

namespace Algorithms.Searching
{
    public class BinarySearch
    {
        private static Tuple<int, bool> Search<T>(IList<T> list, T item, int startIndex, int endIndex) where T : IComparable<T>
        {
            if (startIndex > endIndex)
                throw new InvalidOperationException("Start index should never exceed end index");
            else if (startIndex == endIndex)
                return Tuple.Create(startIndex, item.CompareTo(list[startIndex]) == 0);
            else
            {
                var midpoint = (startIndex + endIndex) / 2;
                var comparisonAtMidpoint = item.CompareTo(list[midpoint]);
                if (comparisonAtMidpoint == 0)
                    return Tuple.Create(midpoint, true);
                else if (comparisonAtMidpoint < 0)
                    return Search(list, item, startIndex, Math.Max(midpoint - 1, startIndex));
                else
                    return Search(list, item, Math.Min(midpoint + 1, endIndex), endIndex);
            }
        }

        /**Finds index of item in sorted list if present, -1 otherwise*/
        public static int FindIndex<T>(IList<T> list, T item) where T : IComparable<T>
        {
            if (list.Count == 0)
                return -1;

            var searchResult = Search(list, item, 0, list.Count - 1);
            return searchResult.Item2 ? searchResult.Item1 : -1;
        }

        /**Returns an index at which inserting the item would preserve sort order*/
        public static int FindClosestIndex<T>(IList<T> list, T item) where T : IComparable<T>
        {
            if (list.Count == 0)
                return 0;

            var searchResult = Search(list, item, 0, list.Count - 1);
            if (searchResult.Item2)
                return searchResult.Item1;

            var stopIndex = searchResult.Item1;
            return item.CompareTo(list[stopIndex]) > 0
                ? stopIndex + 1
                : stopIndex;
        }
    }
}
