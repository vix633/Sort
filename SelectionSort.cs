using System;
namespace Sort
{
    public class SelectionSort : ISorter
    {
        public int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++){
                int lowest = i;
                for (int j = i + 1; j < input.Length; j++){
                    if(input[j] < input[lowest]){
                        lowest = j;
                    }
                }
                int t = input[lowest];
                input[lowest] = input[i];
                input[i] = t;
            }
            return input;
        }
    }
}
