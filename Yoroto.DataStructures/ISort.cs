using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoroto.DataStructures
{
    public interface ISort<T> where T : IComparable<T>
    {
        void Sort();

        int Status { }
    }
}
