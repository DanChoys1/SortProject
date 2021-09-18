using System;
using System.Collections.Generic;
using System.Text;
using Sort;
using BubbleSort;
using QuickSort;
using SelectionSort;
using System.Linq;

namespace SortProject {
    class Test  {

       public bool Tests() {
            List<int> arrTest = new List<int>();

            Random rand = new Random();
            int numberTests = rand.Next(1, 50);

            for (int i = 0; i < numberTests; i++) {
                arrTest.Add(rand.Next(-1000, 1000));
            }

            List<int> BubbleArr = new List<int>(arrTest);
            Bubble bubbleSorter = new Bubble();
            bubbleSorter.sort(BubbleArr, true);

            List<int> QuickArr = new List<int>(arrTest);
            Bubble quikSorter = new Bubble();
            quikSorter.sort(QuickArr, true);

            List<int> SelectionArr = new List<int>(arrTest);
            Bubble selectionSorter = new Bubble();
            selectionSorter.sort(SelectionArr, true);

            bool testPassed;

            if (BubbleArr.SequenceEqual(QuickArr) && SelectionArr.SequenceEqual(QuickArr)) {
                testPassed = true;
            } else {
                testPassed = false;
            }

            bubbleSorter.sort(BubbleArr, false);
            quikSorter.sort(QuickArr, false);
            selectionSorter.sort(SelectionArr, false);

            if (BubbleArr.SequenceEqual(QuickArr) && SelectionArr.SequenceEqual(QuickArr)) {

                if (testPassed) {
                    return true;
                } else {
                    return false;
                }

            } else {
                return false;
            }
       }

    }
}
