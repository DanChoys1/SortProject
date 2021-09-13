using System;
using System.Collections.Generic;
using Sort;

namespace SelectionSort {
    /// <summary>
    /// The class implement abstract class ISort
    /// </summary>
    class Selection : ISort {

        public override List<int> sort(List<int> arr) {
            int size = arr.Count;
            for (int i = 0; i < size - 1; i++) {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < size; j++) {
                    if (arr[j] < arr[min_idx]) {
                        min_idx = j;
                    }
                }


                // Swap the found minimum element with the first
                // element
                if (min_idx != i) {
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                    this.permutation++;
                }
            }
            this.comparison = size * (size - 1) / 2;
            return arr;
        }
    }
}