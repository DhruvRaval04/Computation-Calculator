using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFunctionsSearchingSorting
{
    public static class MathFunctions
    {
        // Below you will find several examples of OVERLOADING. Multiple procedures (called 
        // "methods" when they are defined within classes) can have the SAME NAME as long as 
        // their parameters differ in either NUMBER or TYPE.

        #region Measures of Central Tendency

        /// <summary>
        /// 'ArithmeticMean' Overload 1
        /// Returns the arithmetic mean (average) of a list of 'double' values.
        /// If the list is empty, 'NaN' is returned.
        /// </summary>
        /// 
        public static double ArithmeticMean(List<double> l)
        {
            double average = double.NaN; // Use this value to signal that the list 'l' is empty.

            // If the numbers in 'l' are very large, there is a risk that summing them will cause numeric  
            // overflow (i.e. the sum is greater than the largest value that can be represented as a 'double'
            // or the sum is smaller than the smallest negative value that can be represented as a 'double').
            // double.MaxValue = 1.79769313486232E+308 (1.79769313486232 x 10^308)
            // double.MinValue = -1.79769313486232E+308 (-1.79769313486232 x 10^308)
            // See https://stackoverflow.com/questions/1930454/what-is-a-good-solution-for-calculating-an-average-where-the-sum-of-all-values-e  
            // for a good discussion on how this problem can be tackled. The code examples are written in Java but
            // should be accessible to anyone with a working knowledge of C#.

            if (l.Count > 0)
            {
                double sum = 0;

                for (int i = 0; i < l.Count; i++)
                {
                    sum += l[i]; //Adding 'l[i]' to 'sum' could result in numeric overflow
                }
                average = sum / l.Count; // If 'sum' has a value of 'NaN', this division results in 'NaN'.
            }

            return average;
        }

        /// <summary>
        /// 'ArithmeticMean' Overload 2
        /// Returns the arithmetic mean (average) of an array of 'double' values.
        /// If the list is empty, 'NaN' is returned.
        /// </summary>

        public static double ArithmeticMean(double[] a)
        {
            // Unlike lists, arrays cannot be empty. Therefore, there is no need to check whether 
            // 'a' is empty. The number of elements in an array must be specified when the array
            // is created and naturally, the number of elements must be a positive whole number.

            double sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i]; //Adding 'a[i]' to 'sum' could result in numeric overflow
            }

            return sum / a.Length;
        }


        /// <summary>
        /// 'Median' Overload 1
        /// Returns the median of a list of 'double' values.
        /// If the list is empty, 'NaN' is returned.
        /// </summary>

        public static double Median(List<double> l)
        {
            double median = double.NaN;

            // Insert your code here

           
            List<double> sortedList = new List<double>(l);

            //sorted the list to put it into ascending order
            sortedList.Sort();

            double indexno = sortedList.Count/2;
            
            //if the value of the middle index has no decimal (the size of the list is even). Thus median will have two values; index no and index no - 1
            if (indexno % 1 == 0)
            {
                median = (sortedList[(int)indexno] + sortedList[((int)indexno - 1)]) / 2;
            }
            else
            {
                //the value of the index has a decimal and it is coverted to an int value, making sure that the value selected is the middle of the list 
                median = sortedList[(int)indexno];
            }


            return median;
        }

        /// <summary>
        /// 'Median' Overload 2
        /// Returns the median of an array of 'double' values.
        /// If the list is empty, 'NaN' is returned.
        /// </summary>

        public static double Median(double[] a)
        {
            double median = double.NaN;

            // Insert your code here

            double [] sortedlist = a;

            Array.Sort(sortedlist);

            double indexno = sortedlist.Length/2;
            
            if (indexno % 1 == 0)
            {
                median = (sortedlist[(int)indexno] + sortedlist[((int)indexno - 1)] / 2); 
            }
            else
            {
                median = sortedlist[(int)indexno];
            }

            return median;
        }


        /// <summary>
        /// 'Mode' Overload 1
        /// Returns a list containing all modes of a list of 'double' values.
        /// If the list 'l' is empty, an empty list is returned.
        /// </summary>

        public static List<double> Mode(List<double> l)
        {
            List<double> modeList = new List<double>();

            // Insert your code here
            double mosttimesrepeated = 0;

            for (int i = 0; i < l.Count; i++)
            {
                int currentreps = 0;

                for (int j = 0; j < l.Count; j++)
                {
                    //checking whether the value of the index is equal to the value of the other indexes - for repition 
                    if (l[i] == l[j])
                    {
                        currentreps++;
                    }
                }
                //checks if the current number is repeated more than the numbr which is repeated the most 
                if (mosttimesrepeated < currentreps)
                {
                    modeList.Clear();
                    modeList.Add(l[i]);
                    mosttimesrepeated = currentreps;
                }
                //if a number is repeated as much as another number, both of them are the mode 
                else if (mosttimesrepeated == currentreps)
                {
                    modeList.Add(l[i]);
                }
            }

            //this list removes duplicates in the original list 
            List<double> noRepeatModeList = modeList.Distinct().ToList();

            return noRepeatModeList;
        }

        

        // <summary>
        /// 'Mode' Overload 2
        /// Returns a list containing all modes of an array of 'double' values.
        /// </summary>

        public static List<double> Mode(double[] a)
        {
            List<double> modeList = new List<double>();

            // Insert your code here
            double mosttimesrepeated = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int currentreps = 0;

                for (int j = 0; j < a.Length; j++)
                {
                    
                    if (a[i] == a[j])
                    {
                        currentreps++;
                    }
                }
                 
                if (mosttimesrepeated < currentreps)
                {
                    modeList.Clear();
                    modeList.Add(a[i]);
                    mosttimesrepeated = currentreps;
                }
                
                else if (mosttimesrepeated == currentreps)
                {
                    modeList.Add(a[i]);
                }
            }
 
            List<double> noRepeatModeList = modeList.Distinct().ToList();

            return noRepeatModeList;
        }

        /// <summary>
        /// 'GeometricMean' Overload 1
        /// Returns the geometric mean of a list of 'double' values.
        /// If the list of 'double' values contains any nonpositive values 
        /// (i.e. values that are <= 0) or if the list is empty, 'NaN' is returned.
        /// </summary>

        public static double GeometricMean(List<double> l)
        {
            double geometricMean = double.NaN;

            // If the numbers in 'l' are large enough, the product l[0] x l[1] x ... x l[n-1], where n=l.Count, could 
            // result in numeric overflow. To prevent this from happening, it is better to calculate the geometric
            // mean by exploiting properties of logarithms: (1) log(x^n) = nlog(x)    (2) log(xy) = log(x) + log(y)
            //
            // GM = nth root of (l[0] x l[1] x ... x l[n-1])  (GM = geometric mean)
            //    = (l[0] x l[1] x ... x l[n-1])^(1/n)
            //
            // Therefore, log(GM) = log((l[0] x l[1] x ... x l[n-1])^(1/n))
            //                    = (1/n)log(l[0] x l[1] x ... x l[n-1])
            //                    = (1/n)(log(l[0]) + log(l[1]) + ... + log(l[n-1]))
            //                    = (log(l[0]) + log(l[1]) + ... + log(l[n-1])) / n
            // Then GM = base^((log(l[0]) + log(l[1]) + ... + log(l[n-1])) / n), where 'base' is the base used for log.
            //
            // Although this method prevents overflow, it could be susceptible to other problems such as 
            // (1) UNDERFLOW (i.e. produce values that are taken to be zero because they are smaller than the
            //     smallest value that can be represented as a 'double').
            // (2) Evaluating the logarithm is an "expensive" operation for the CPU
            //
            // double.Epsilon = 4.94065645841247E-324 = 4.94065645841247 x 10^(-324) = smallest positive value that
            // can be represented as a 'double'
            // -double.Epsilon = -4.94065645841247E-324 = -4.94065645841247 x 10^(-324) = largest negative value 
            // (i.e. closest to zero) that can be represented as a 'double'.
            // Any value between -double.Epsilon and double.Epsilon is taken to be zero

            // Insert your code here
            double sum = 0;

            for (int i = 0; i < l.Count; i++)
            {
                //add up the logs of every number
                if (l[i] > 0)
                {
                    sum += Math.Log(l[i]);
                }
                else
                {
                    return geometricMean;
                }
            }
            //use e as base and exponenet as sum divided by length of the list 
            geometricMean = Math.Pow(Math.E, sum / l.Count);
            return geometricMean;
        }


        /// <summary>
        /// 'GeometricMean' Overload 2
        /// Returns the geometric mean of an array of 'double' values.
        /// If the list of 'double' values contains any nonpositive values 
        /// (i.e. values that are <= 0) or if the list is empty, 'NaN' is returned.
        /// </summary>

        public static double GeometricMean(double[] a)
        {
            double geometricMean = double.NaN;


            // Insert your code here
            double sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    sum += Math.Log(a[i]);
                }
                else
                {
                    return geometricMean;
                }
            }
            geometricMean = Math.Pow(Math.E, sum / a.Length);

            return geometricMean;
        }

        /// <summary>
        /// 'HarmonicMean' Overload 1
        /// Returns the harmonic mean of a list of 'double' values.
        /// If the list of 'double' values contains any nonpositive values 
        /// (i.e. values that are <= 0) or if the list is empty, 'NaN' is returned.
        /// </summary>
        public static double HarmonicMean(List<double> l)
        {
            double harmonicMean = double.NaN;

            // Let n = l.Count and HM stand for "Harmonic Mean"
            // Then HM = n/(1/l[0] + 1/l[1] + ... + 1/l[n-1]) = n/(sum of reciprocals of values)
            // Overflow and underflow can be an issue for harmonic mean but it's less likely than
            // it is for geometric mean. If the values in the list are very large, then their reciprocals
            // are very small, making the sum of the reciprocals small. Dividing 'n' by a small value
            // can cause overflow in theory but only if 'n' is extremely large. In practice, 'n' has to be 
            // relatively small because of memory limitations. Overflow is more likely to happen if the 
            // values in 'l' are extremely small. For example, if one of the values in the list is double.Epsilon,
            // then 1/double.Epsilon = 1/(4.94065645841247E-324) = [4.94065645841247 x 10^(-324)]^(-1)
            // = (4.94065645841247)^(-1) x 10^[(-324)(-1)] > 5^(-1) x 10^324 = 0.2 x 10^324 = 2 x 10^323, which is
            // far greater than the largest 'double' value.

            // Insert your code here

            double totalreciprocal = 0;
            
            for (int i = 0; i < l.Count; i++)
            {
                //adds up reciprocal for each element 
                if (l[i] > 0)
                {
                    totalreciprocal += (1 / l[i]);
                }
                else
                {
                    return harmonicMean;
                }
            }
            harmonicMean = l.Count / totalreciprocal;
            return harmonicMean;
        }

        /// <summary>
        /// 'HarmonicMean' Overload 2
        /// Returns the harmonic mean of an array of 'double' values.
        /// If the list of 'double' values contains any nonpositive values 
        /// (i.e. values that are <= 0) or if the list is empty, 'NaN' is returned.
        /// </summary>
        public static double HarmonicMean(double[] a)
        {
            double harmonicMean = double.NaN;

            // Insert your code here
            double reciprocal = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    reciprocal += (1 / a[i]);
                }
                else
                {
                    return harmonicMean;
                }
            }
            harmonicMean = a.Length / reciprocal;
            return harmonicMean;
        }

        #endregion

        #region Min and Max
        /// <summary>
        /// 'Minimum' Overload 1
        /// Returns the smallest 'double' value found in a list of 'double' values.
        /// If the list is empty, 'PositiveInfinity' is returned.
        /// </summary>

        public static double Minimum(List<double> l)
        {
            double min = double.PositiveInfinity; //IEEE754 value that is greater than all 'double' values

            // < sign because we want to change the value of min when an element is smaller than it
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] < min)
                {
                    min = l[i];
                }
            }

            return min;
        }

        /// <summary>
        /// 'Minimum' Overload 2
        /// Returns the smallest 'double' value found in an array of 'double' values.
        /// Returns 'PositiveInfinity' if the array is empty.
        /// </summary>

        public static double Minimum(double[] a)
        {
            
            double min = double.PositiveInfinity;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }

        /// <summary>
        /// 'Minimum' Overload 3
        /// Returns the smallest 'int' value found in a list of 'int' values.
        /// If the list is empty, 'long.MaxValue' is returned because this value is  
        /// larger than all 'int' (Int32) values. 
        /// </summary>
        public static long Minimum(List<int> l)
        {
            // 'long' data type is used to ensure that this method will work   
            // even when 'int.MaxValue' is the smallest value in the list.
            long min = long.MaxValue;

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] < min)
                {
                    min = l[i];
                }
            }

            return min;
        }

        /// <summary>
        /// 'IndexOfMinimum' Overload 1
        /// Returns the index of the smallest 'double' value found in a list of 'double' values.
        /// If the list is empty, -1 is returned.
        /// </summary>

        public static int IndexOfMinimum(List<double> l)
        {
            int indexOfMin = -1;

            if (l.Count > 0)
            {
                indexOfMin = 0;

                for (int i = 1; i < l.Count; i++)
                {
                    if (l[i] < l[indexOfMin])
                    {
                        indexOfMin = i;
                    }
                }
            }

            return indexOfMin;
        }

        /// <summary>
        /// 'IndexOfMinimum' Overload 2
        /// Returns the index of the smallest 'double' value found in the sublist of a  
        /// list of 'double' values starting at index 'startIndex' and ending at index 'l.Count - 1'.
        /// If the list is empty, -1 is returned.
        /// </summary>
        /// 
        public static int IndexOfMinimum(List<double> l, int startIndex)
        {
            int minIndex = -1;

            if (l.Count > 0)
            {
                for (int i = startIndex + 1; i < l.Count; i++)
                {
                    if (l[i] < l[minIndex])
                    {
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }

        /// <summary>
        /// 'IndexOfMinimum' Overload 3
        /// Returns the index of the smallest 'double' value found in the sublist of a  
        /// list of 'double' values starting at index 'startIndex' and ending at 'endIndex'.
        /// If the list is empty, -1 is returned.
        /// </summary>

        public static int IndexOfMinimum(List<double> l, int startIndex, int endIndex)
        {
            int indexOfMin = -1;

            if (l.Count > 0)
            {
                indexOfMin = startIndex;

                for (int i = startIndex + 1; i <= endIndex; i++)
                {
                    if (l[i] < l[indexOfMin])
                    {
                        indexOfMin = i;
                    }
                }
            }

            return indexOfMin;
        }


        /// <summary>
        /// 'Maximum' Overload 1
        /// Returns the largest 'double' value found in a given list of 'double' values.
        /// If the list is empty, 'NegativeInfinity' is returned.
        /// </summary>
        public static double Maximum(List<double> l)
        {
            double max = double.NegativeInfinity; //IEEE754 value that is less than all 'double' values

            
            // need to check if the values are bigger than max, if so, then max is updated
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] > max)
                {
                    max = l[i];
                }
            }

            return max;
        }

        /// <summary>
        /// 'Maximum' Overload 2
        /// Returns the largest 'double' value found in an array of 'double' values.
        /// Returns 'NegativeInfinity' if the array is empty
        /// </summary>
        public static double Maximum(double[] a)
        {
            double max = double.NegativeInfinity;

            // Insert your code here
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        /// <summary>
        /// 'Maximum' Overload 3
        /// Returns the largest 'int' value found in a list of 'int' values.
        /// If the list is empty, 'long.MinValue' is returned (Int64 value) because this 
        /// value is smaller than all 'int' (Int32) values. 
        /// </summary>
        public static long Maximum(List<int> l)
        {
            // 'long' data type is used to ensure that this method will work   
            // even when 'int.MinValue' is the largest value in the list.
            long max = long.MinValue;

            // Insert your code here
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] > max)
                {
                    max = l[i];
                }
            }
            return max;
        }

        /// <summary>
        /// 'IndexOfMaximum' Overload 1
        /// Returns the index of the largest 'double' value found in a list of 'double' values.
        /// If the list is empty, -1 is returned.
        /// </summary>
        public static int IndexOfMaximum(List<double> l)
        {
            int indexOfMax = -1;

            // Insert your code here
            if (l.Count > 0)
            {
                indexOfMax = 0;

                for (int i = 1; i < l.Count; i++)
                {
                    if (l[i] > l[indexOfMax])
                    {
                        indexOfMax = i;
                    }
                }
            }
            return indexOfMax;
        }

        /// <summary>
        /// 'IndexOfMaximum' Overload 2
        /// Returns the index of the largest 'double' value found in the sublist of a  
        /// list of 'double' values starting at index 'startIndex' and ending at index 'l.Count - 1'.
        /// If the list is empty, -1 is returned.
        /// </summary>
        public static int IndexOfMaximum(List<double> l, int startIndex)
        {
            int maxIndex = -1;

            // Insert your code here
            if (l.Count > 0)
            {
                for (int i = startIndex + 1; i < l.Count; i++)
                {
                    if (l[i] > l[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// 'IndexOfMaximum' Overload 3
        /// Returns the index of the largest 'double' value found in the sublist of a  
        /// list of 'double' values starting at index 'startIndex' and ending at index 'endIndex'.
        /// If the list is empty, -1 is returned.
        /// </summary>

        public static int IndexOfMaximum(List<double> l, int startIndex, int endIndex)
        {
            int indexOfMax = -1;

            // Insert your code here
            if (l.Count > 0)
            {
                indexOfMax = startIndex;

                for (int i = startIndex + 1; i <= endIndex; i++)
                {
                    if (l[i] > l[indexOfMax])
                    {
                        indexOfMax = i;
                    }
                }
            }
            return indexOfMax;
        }

        /// <summary>
        /// 'QuickSelect' Overload 1
        /// Returns the kth smallest value in a list of 'double' values.
        /// The quickselect algorithm is similar to quicksort. This isn't a coincidence because  
        /// both algorithms were developed by C. A. R. (Tony) Hoare in the late 1950's. 'QuickSelect' 
        /// is easy to implement recursively (but would require two more parameters, 'left' and 'right').
        /// To avoid recursion for the moment, it is implemented iteratively (i.e. with a loop).
        /// </summary>
        public static double QuickSelect(List<double> l, int k)
        {
            double kthSmallest = double.NaN;
            int left = 0, right = l.Count - 1; // Begin with the entire list.

            if (l.Count > 0 && k >= 1 && k <= l.Count)
            {
                int pivotIndex = left - 1;
                int kthSmallestIndex = k - 1;

                // Keep partitioning 'l' from 'left' to 'right' until the kth smallest value is the pivot.
                // This happens when pivotIndex = k – 1 because the pivot will be >= all items from index
                // 0 to index k-2. Therefore, k-1 items are <= pivot, making the pivot the kth smallest item.

                while (left < right && kthSmallestIndex != pivotIndex)
                {
                    // Reorganize 'l' in such a way that l = (Left Partition) + pivot + (Right Partition), where
                    // all items in (Left Partition) <= pivot and all items in (Right Partition) >= pivot.
                    pivotIndex = Sorting.LomutoPartition(l, left, right);

                    if (kthSmallestIndex < pivotIndex)
                    {
                        right = pivotIndex - 1; // kth smallest value is between left and pivotIndex-1
                    }
                    else if (kthSmallestIndex > pivotIndex)
                    {
                        left = pivotIndex + 1; // kth smallest value is between pivotIndex+1 and right
                    }
                }

                if (kthSmallestIndex == pivotIndex)
                {
                    kthSmallest = l[kthSmallestIndex];
                }
                else
                {
                    kthSmallest = l[left];
                }
            }

            return kthSmallest;
        }

        /// <summary>
        /// 'QuickSelect' Overload 2
        /// Uses Hoare's algorithm to return the kth smallest value  
        /// in a list of 'double' values, from index 'left' to index 'right' inclusive, .
        /// </summary>
        public static double QuickSelect(List<double> l, int k, int left, int right)
        {
            double kthSmallest = double.NaN;

            if (l.Count > 0 && left >= 0 && left <= right && right < l.Count && k >= 1 && k <= right - left + 1)
            {
                int pivotIndex = left - 1;
                int kthSmallestIndex = left + k - 1;

                // Keep partitioning 'l' from 'left' to 'right' until the kth smallest value is the pivot.
                // This happens when pivotIndex = left + k – 1 because the pivot will be >= all items from index
                // left to index left + k - 2. Therefore, k-1 items are <= pivot, making the pivot the kth smallest 
                // item from index 'left' to index 'right'.

                while (left < right && kthSmallestIndex != pivotIndex)
                {
                    // Reorganize 'l' in such a way that l = (Left Partition) + pivot + (Right Partition), where
                    // all items in (Left Partition) <= pivot and all items in (Right Partition) >= pivot.
                    pivotIndex = Sorting.LomutoPartition(l, left, right);

                    if (kthSmallestIndex < pivotIndex)
                    {
                        right = pivotIndex - 1; // kth smallest value is between left and pivotIndex-1
                    }
                    else if (kthSmallestIndex > pivotIndex)
                    {
                        left = pivotIndex + 1; // kth smallest value is between pivotIndex+1 and right
                    }
                }

                if (kthSmallestIndex == pivotIndex)
                {
                    kthSmallest = l[kthSmallestIndex];
                }
                else
                {
                    kthSmallest = l[left];
                }
            }

            return kthSmallest;
        }
        #endregion

        #region Rounding

        /// <summary>
        /// 'RoundOff' returns 'number' rounded off to 'decimalPlaces' places.
        /// There is a high risk of overflow with this method! No overflow checking
        /// has been included.
        /// </summary>

        public static double RoundOff(double number, int decimalPlaces)
        {
            double moveDecPtFactor = Math.Pow(10, decimalPlaces);
            double numDecPtMoved = number * moveDecPtFactor;
            double roundedDown = Math.Floor(numDecPtMoved);
            double roundedValue = Math.Floor(numDecPtMoved + 0.5d) / moveDecPtFactor;

            // Check whether "numDecPtMoved" ends in 0.5 and "roundedDown" is even
            // In this case, the returned value always needs to be rounded down.
            // e.g. 3.45 to 1 decimal place: 3.45 -> 34.5 -> 34 -> 3.4 (round to even rule)
            if (numDecPtMoved - roundedDown == 0.5d && roundedDown % 2 == 0)
            {
                roundedValue = Math.Floor(numDecPtMoved) / moveDecPtFactor;
            }

            return roundedValue;
        }

        #endregion

    }
}
