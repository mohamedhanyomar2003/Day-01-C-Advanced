using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FixedSizeList<T>
    {
        #region attributes
        private T[] list;
        private int count;


        #endregion

        #region constructors
        public FixedSizeList(int fixedCapcity)
        {
            if (fixedCapcity <= 0) throw new ArgumentException("Invalid! Capcity Must Be Greater Than 0");
            FixedCapcity = fixedCapcity;
            list = new T[fixedCapcity];
            count = 0;
        }

        #endregion

        #region properties
        public int FixedCapcity { get; }
        public int Count
        {
            get { return count; }
        }

        #endregion

        #region methods
        public void Add(T value)
        {
            if (count >= FixedCapcity) throw new ArgumentException("Invalid! List is Full Cant Add Another Element");
            else
            {
                list[count++] = value;
            }
        }

        public T Get(int index)
        {
            if (index >= 0 && index < FixedCapcity)
                return list[index];
            else throw new ArgumentException("Invalid Index! Index Must Be In Range Of Size Of List");
        }
        #endregion



    }
}
