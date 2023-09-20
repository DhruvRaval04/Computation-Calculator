using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFunctionsSearchingSorting
{
    public static class Searching
    {
        #region Linear Search

        /// <summary>
        /// 'LinearSearch' Overload 1
        /// Uses the linear search algorithm to search for 'key' in a list of double values 'l'.
        /// Returns the the index of the first occurrence of 'key' if 'key' exists in 'l'.
        /// Otherwise, -1 is returned.
        /// </summary>
        /// 
        public static int LinearSearch(List<double> l, double key)
        {
            int index = -1, i = 0;

            while (i < l.Count && l[i] != key)
            {
                i++;
            }

            // The value of 'i' can only equal 'l.Count' if 'key' was not found
            if (i < l.Count)
            {
                index = i;
            }

            return index;
        }

        /// <summary>
        /// 'LinearSearch' Overload 2
        /// Uses the linear search algorithm to search for 'key' in an array of double values 'a'.
        /// Returns the the index of the first occurrence of 'key' if 'key' exists in 'a'.
        /// Otherwise, -1 is returned.
        /// </summary>
        /// 

        public static int LinearSearch(double[] a, double key)
        {
            int index = -1;

            // Insert your code here

            return index;
        }

        #endregion

        #region Binary Search
        
        /// <summary>
        /// 'BinarySearch' Overload 1
        /// Uses the binary search algorithm to search for 'key' in a list of double values 'l'.
        /// Returns the the index of the first occurrence of 'key' if 'key' exists in 'l'.
        /// Otherwise, -1 is returned.
        /// </summary>

        public static int BinarySearch(List<double> l, double key)
        {
            int index = -1;

            // Insert your code here
            
            int left = 0;
            int right = l.Count - 1;
            int mid = 0;

            //outer loop that continues until key is found 
            while (left<=right)
            {
                //calculating mid from left and right values 
                //for ex: left = 0, right = 5; 0 + (5+0)/2 = 2
                mid = left + ((right - left) / 2); 

                if (key == l[mid])
                {
                    index = mid;
                    return index;
                }
                //cuts the list to check in half (if its is bigger than mid, it checks values from mid + 1 to the end)
                else if (key > l[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return index;
            //binary search only works on sorted lists, and thus needs to be used after a sort method has already been called
            //if you try to sort inside the method, the indexes of the elements change, and the returned index will be different than the index of the "key" in the unsorted array
        }


        /// <summary>
        /// 'BinarySearch' Overload 2
        /// Uses the binary search algorithm to search for 'key' in an array of double values 'a'.
        /// Returns the the index of the first occurrence of 'key' if 'key' exists in 'a'.
        /// Otherwise, -1 is returned.
        /// </summary>

        public static int BinarySearch(double[] a, double key)
        {
            int index = -1;

            // Insert your code here
            
            int left = 0;
            int right = a.Length - 1;
            int mid = 0;

            while (right >= left)
            {
                mid = left + ((right - left) / 2);

                if (key == a[mid])
                {
                    index = mid;
                    return index;
                }
                else if (key > a[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return index;
        }
        #endregion
    }

}
