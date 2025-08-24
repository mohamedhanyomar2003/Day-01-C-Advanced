using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Range<T> where T : IComparable<T>,INumber<T>
    {
        public Range(T minimum, T maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public T Minimum { get; set; }
        public T Maximum { get; set; }

        public bool IsInRange(T value)
        {
            if (value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0) return true;
            else return false;
        }

        public T Length()
        {
            return Maximum-Minimum;
        }

    }
}
