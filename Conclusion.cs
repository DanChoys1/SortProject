using System;
using System.Collections.Generic;
using System.Text;
using Sort;

namespace SortProject {
    class Conclusion {
        public String WrittingConclusion(ISort []sorter) {
            int bubbleNumb = sorter[0].Permutation + sorter[0].Comparison;
            int quickNumb = sorter[1].Permutation + sorter[1].Comparison;
            int selectionNumb = sorter[2].Permutation + sorter[2].Comparison;
            int mergeNumb = sorter[3].Permutation + sorter[3].Comparison;

            int[] sortNumb = { bubbleNumb, quickNumb, selectionNumb, mergeNumb };
            int min = bubbleNumb;
            int max = bubbleNumb;
            for (int i = 1; i < 4; i++) {
                if (sortNumb[i] < min) {
                    min = sortNumb[i];
                }

                if (sortNumb[i] > max) {
                    max = sortNumb[i];
                }
            }
            String conclusion = "";

            if (min == bubbleNumb) {
                conclusion = "Самая оптимальная - пузырьком. ";
            } else if (min == quickNumb) {
                conclusion = "Самая оптимальная - быстрая. ";
            } else if (min == selectionNumb) {
                conclusion = "Самая оптимальная - выбором. ";
            } else {
                conclusion = "Самая оптимальная - слиянием. ";
            }

            if (max == bubbleNumb) {
                conclusion += "Самая неоптимальная - пузырьком.";
            } else if (max == quickNumb) {
                conclusion += "Самая неоптимальная - быстрая.";
            } else if (max == selectionNumb) {
                conclusion += "Самая неоптимальная - выбором.";
            } else {
                conclusion += "Самая неоптимальная - слиянием.";
            }

            return conclusion;
        }

    }
}
