using System;
using System.Collections.Generic;
using System.Text;
using Sort;


namespace BubbleSort {
    class Bubble : ISort {

        public override List<int> sort(List<int> arr, bool isAscending) {
            int size = arr.Count;

            for (int k = 0; k < size; k++) {
                int checking = 0;

                for (int i = 0; i < size - 1; i++) {
                    this.comparison++;

                    if (isAscending == true) {

                        if (arr[i] > arr[i + 1]) {
                            int temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            checking++;
                            this.permutation++;
                        }
                    } else {

                        if (arr[i] < arr[i + 1]) {
                            int temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            checking++;
                            this.permutation++;
                        }
                    }
                }

                if (checking == 0) {
                    break;
                }

            }
            return arr;
        }
    }
}
