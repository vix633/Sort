using System;
namespace Sort
{
    public class InsertionSort : ISorter
    {
        public InsertionSort()
        {
        }

        public int[] Sort(int[] input){
            for (int i = 1; i < input.Length; i++){
                Insert(input, i);
            }
            return input;
        }

        private void Insert(int[] input, int sortLine){
            for (int i = sortLine - 1; i >= 0; i--){
                if (!(input[sortLine] < input[i])){
                    InsertArray(input, i+1, sortLine);
                    return;
                }
            }
            InsertArray(input, 0, sortLine);
        }

        private void InsertArray(int[] input, int dest, int source) {
            int temp = input[source];
            for (int i = dest; i < source; i++) {
                input[i + 1] = input[i];
            }
            input[dest] = temp;
        }
    }
}
