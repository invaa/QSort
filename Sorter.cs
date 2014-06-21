using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QSort
{
    public static class Sorter
    {
        public static void QSort(ref ArrayList array)
        {

            QSort(ref array, 0, array.Count - 1);
        }
        private static void QSort(ref ArrayList array, int l, int r)
        {
            int i = l;
            int j = r;
            Object m = array[r - (r - l)/2];

            while (i <= j)
            {
                while (((IComparable)array[i]).CompareTo(m) < 0) i++;
                while (((IComparable)array[j]).CompareTo(m) > 0) j--;

                if (i <= j) { Swap(ref array, i, j); i++; j--; };
            }

            if (i < r) QSort(ref array, i, r);
            if (j > l) QSort(ref array, l, j);

        }

        private static void Swap(ref ArrayList array, int i, int j)
        {
            Object c = array[i];
            array[i] = array[j];
            array[j] = c;
        }
     }
}
