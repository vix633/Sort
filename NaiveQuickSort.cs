using System.Linq;
namespace Sort
{
    //Super gross, not a practical solution, only a naive way to understand the algorithm
    public class NaiveQuickSort : ISorter
    {
        public int[] Sort(int[] input){
            if(input.Length < 2){
				return input;
			}
            int pivot = input[0];
            int[] high = input.Skip(1).Where(x => x > pivot).ToArray();
            int[] low = input.Skip(1).Where(x => x <= pivot).ToArray();
            return Sort(low).Concat(input.Take(1)).Concat(Sort(high)).ToArray();
		}
    }
}
