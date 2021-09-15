using System;
using System.Collections.Generic;
using System.Text;

namespace Sort {
    abstract class ISort {
        protected int comparison = 0;
        protected int permutation = 0;

        public abstract List<int> sort(List<int> arr, bool isAscending);

        public int Comparison {
            get { return comparison; }
        }

        public int Permutation {
            get { return permutation; }
        }
    }
}
