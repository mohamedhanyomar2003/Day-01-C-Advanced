using System.Collections;
using System.ComponentModel.Design;
using System.Formats.Tar;

namespace Assignment
{
    internal class Program
    {
        static void Reverse<T>(ref T []arr)
        {
            if (arr is not null)
           for (int i=0;i<arr.Length; ++i)
                {
                    for (int j = 0; j < arr.Length - 1 - i; ++j)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
        }

        static int[] ReturnEven(int[]arr)
        {
           
            if (arr is not null)
            {
                List<int> result = new List<int>();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 ) result.Add(arr[i]);
                }
                return result.ToArray();
            }
            return null!;
        }
        //static int ReturnNonRepeated(string x)
        //{
        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        bool flag = true;
        //        for (int j= i+1; j < x.Length-1; j++)
        //        {
        //            if (x[i] == x[j])
        //            {
        //                flag = false;
        //            }
        //        }
        //        if (flag)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        static int ReturnNonRepeated(string x)
        {
            x = x.ToLower();
            Dictionary<char,int> dic=new Dictionary<char, int>();
            for (int i = 0; i < x.Length; i++)
            {  
                if (dic.ContainsKey(x[i]))
                {
                    dic[x[i]]++;
                }
                else
                {
                    dic.Add(x[i], 1);
                }
                    
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (dic[x[i]] == 1) return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            #region Q1
            ///***
            // * create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
            // * The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            //Requirements:
            //Create a generic class named Range<T> where T represents the type of values.
            //Implement a constructor that takes the minimum and maximum values to define the range.
            //Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            //Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            //Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
            //*/

            //Range<int> r1 = new Range<int>(1, 8);
            //Console.WriteLine(r1.IsInRange(0));
            //Console.WriteLine(r1.Length());
            #endregion

            #region Q2
            ////You are given an ArrayList containing a sequence of elements.
            ////try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
            ////without using the built-in Reverse. Implement a function that takes the ArrayList as input
            ////and modifies it to have the reversed order of elements.

            //int []arr =[1,2,3,4,5,6];
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("******************After reversed*****************");
            //Reverse<int>(ref arr);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3
            ////You are given a list of integers.
            ////Your task is to find and return a new list containing only the even numbers from the given list.
            //int[] arr = [1, 2, 3, 4, 5, 6,100,20,33];
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //int []result=ReturnEven(arr);
            //Console.WriteLine("After return even only");
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Q4
            ////implement a custom list called FixedSizeList<T> with a predetermined capacity
            ////. This list should not allow more elements than its capacity and
            ////should provide clear messages if one tries to exceed it or access invalid indices

            //FixedSizeList<int> list1 = new FixedSizeList<int>(5);
            //for (int i = 0; i < list1.FixedCapcity; i++)
            //{
            //    list1.Add(i);
            //}
            //for (int i = 0; i < list1.FixedCapcity; i++)
            //{
            //    Console.WriteLine(list1.Get(i));
            //}

            #endregion

            #region Q5
            ////Given a string, find the first non-repeated character in it and return its index.
            ////If there is no such character, return 

            string x = "mohaMedooehad";
            Console.WriteLine(ReturnNonRepeated(x));
            #endregion

        }
    }
}
