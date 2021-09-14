using System;
using System.Collections.Generic;
using Sort;
using SortProject;

namespace SelectionSort {
    /// <summary>
    /// The class implement abstract class ISort
    /// </summary>
    class Selection : ISort {

        public override List<int> sort(List<int> arr, bool isAscending) {
            int size = arr.Count;
           
            for (int i = 0; i < size - 1; i++) {
                // Find the minimum (maximum) element in unsorted array
                int pivot_idx = i;
                for (int j = i + 1; j < size; j++) {
                    if (isAscending) {
                        if (arr[j] < arr[pivot_idx]) {
                            pivot_idx = j;
                        }
                    } else {
                        if (arr[j] > arr[pivot_idx]) {
                            pivot_idx = j;
                        }
                    }
                    
                }


                // Swap the found minimum (maximum) element with the first
                // element
                if (pivot_idx != i) {
                    int temp = arr[pivot_idx];
                    arr[pivot_idx] = arr[i];
                    arr[i] = temp;
                    this.permutation++;
                }
            }
            this.comparison = size * (size - 1) / 2;
            return arr;
        }
    }
}