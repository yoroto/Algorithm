﻿using System;
using System.Collections.Generic;

namespace Algorithm.Sort.QuickSort
{
    static class Utils
    {
        public static void Swap<T>(IList<T> items, int i, int j) where T : IComparable<T>
        {
            lock (items)
            {
                if (i < items.Count && j < items.Count)
                {
                    T temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
}
