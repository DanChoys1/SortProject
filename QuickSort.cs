using System;
using System.Collections.Generic;
using System.Text;
using Sort;

namespace Quick
{
    class QuickSort : ISort
    {

        void Swap(ref List<int> arr, int FirstArgument, int SecondArgument)
        {
            var t = arr[FirstArgument];
            arr[FirstArgument] = arr[SecondArgument];
            arr[SecondArgument] = t;
            this.permutation++;
        }

        //метод возвращающий индекс опорного элемента
        int Partition(List<int> array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                this.comparison++;
                if (array[i] < array[maxIndex])
                {
                    pivot++;

                    Swap(ref array, pivot, i);
                }
            }

            pivot++;
            Swap(ref array, pivot, maxIndex);
            return pivot;
        }

        int PartitionDescending(List<int> array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                this.comparison++;
                if (array[i] > array[maxIndex])
                {
                    pivot++;

                    Swap(ref array, pivot, i);
                }
            }

            pivot++;
            Swap(ref array, pivot, maxIndex);
            return pivot;
        }

        //быстрая сортировка
        List<int> Quick_Sort(List<int> array, int minIndex, int maxIndex, bool isAscending)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            if (isAscending)
            {
                var pivotIndex = Partition(array, minIndex, maxIndex);
                Quick_Sort(array, minIndex, pivotIndex - 1, isAscending);
                Quick_Sort(array, pivotIndex + 1, maxIndex, isAscending);
            }
            else {
                var pivotIndex = PartitionDescending(array, minIndex, maxIndex);
                Quick_Sort(array, minIndex, pivotIndex - 1, isAscending);
                Quick_Sort(array, pivotIndex + 1, maxIndex, isAscending);
            }
            

            return array;
        }
        public override List<int> sort(List<int> arr, bool isAscending)
        {

            Quick_Sort(arr, 0, arr.Count - 1, isAscending);

            return arr;

        }

    }
}

