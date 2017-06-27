using NUnit.Framework;
using System.Collections.Generic;
namespace Sort
{
	public class ISorterTests
	{
        public static IEnumerable<ISorter> sorters {
            get {
                yield return new SelectionSort();
                yield return new InsertionSort();
            }
        }

        public static IEnumerable<SortTestData> testData {
            get {
				yield return new SortTestData(
					new int[0],
					new int[0]
				);
                yield return new SortTestData(
                    new [] { 0 },
                    new [] { 0 }
                );
                yield return new SortTestData(
                    new int[] {5, 4, 3, 2, 1 },
                    new int[] {1, 2, 3, 4, 5 }
                );
                yield return new SortTestData(
                    new int[] { 1, 2, 3, 4, 5, 6 },
                    new int[] { 1, 2, 3, 4, 5, 6 }
                );
                yield return new SortTestData(
                    new int[] { 1, 2, -3, 4, 5 },
                    new int[] { -3, 1, 2, 4, 5 }
                );
                yield return new SortTestData(
                    new int[] { 1, 2, 3, 5, 4 },
                    new int[] { 1, 2, 3, 4, 5 }
                );
                yield return new SortTestData(
                    new int[] { 5000000, 100, 2000, 30000, 400000 },
                    new int[] { 100, 2000, 30000, 400000, 5000000 }
                );
                yield return new SortTestData(
                    new int[] { 4, 1, 1, 1, 1 },
                    new int[] { 1, 1, 1, 1, 4 }
                );
                yield return new SortTestData(
                    new int[] { 1, 1, 1, 1, 1 },
                    new int[] { 1, 1, 1, 1, 1 }
                );
            }
        }

		[Test]
        [Combinatorial]
        public void TestCase(
            [ValueSource("sorters")] ISorter sorter,
            [ValueSource("testData")] SortTestData testData)
		{
            CollectionAssert.AreEqual(testData.Sorted, sorter.Sort(testData.Unsorted));
		}
	}
    public class SortTestData{
        public int[] Unsorted { get; set; }
        public int[] Sorted { get; set; }

        public SortTestData(int[] unsorted, int[] sorted) {
            Unsorted = unsorted;
            Sorted = sorted;
        }
    }
}
