using System;
using System.Collections.Generic;
using System.Text;
using Sort;

namespace SortProject {
    class MergeSort : ISort {
        public override List<int> sort(List<int> arr, bool isAscending) {
            return real_sort(arr, 0, arr.Count - 1, isAscending);
        }

        List<int> real_sort(List<int> arr, int l, int r, bool isAscending) {
            if (l < r) {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                real_sort(arr, l, m, isAscending);
                real_sort(arr, m + 1, r, isAscending);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
            return arr;
        }

        void merge(List<int> arr, int l, int m, int r) {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            List<int> L = new List<int>();
            List<int> R = new List<int>();
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; i++)
                L.Add(arr[l + i]);
            for (j = 0; j < n2; j++)
                R.Add(arr[m + 1 + j]);

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2) {
                this.comparison++;
                this.permutation++;
                if (L[i] <= R[j]) {
                    arr[k] = L[i];
                    i++;
                } else {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1) {
                this.permutation++;
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2) {
                this.permutation++;
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
