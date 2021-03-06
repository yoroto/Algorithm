﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public interface ISort<T> where T : IComparable<T>
    {
        void Sort();

        int Status { get; }
    }
}
