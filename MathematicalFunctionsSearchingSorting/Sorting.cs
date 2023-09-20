using System;
using System.Collections.Generic;

namespace MathematicalFunctionsSearchingSorting
{
    #region Purpose of this Class
    /*
    * The 'Sorting' class is being used only as a storage place for sorting methods. It is not intended to be
    * used as a template for making objects. In fact, it CANNOT be used as such because it does not contain
    * any constructor methods (done intentionally). Recall that constructor methods are called to initialize
    * objects. Since this class cannot be used to create objects, there is no need for any constructors.
    */
    #endregion

    public static class Sorting
    {
        // Constructor has been removed because of reasons specified in the last comment.
        //public Sort()
        //{
        //}

        #region Explanation of Time Complexity

        /**************************************************************************************************
         * 
         * The "time complexity" (sometimes also known informally as "running time") of an algorithm is a 
         * measure of "how fast" it is. For comparison-based sorting algorithms, time complexity generally 
         * refers to the number of comparisons required to sort a list/array containing n items. In general, 
         * it is extremely difficult to determine the exact number of comparisons needed to sort lists 
         * because this depends largely on the initial ordering of the data and other complicating factors. 
         *  
         * Because of this, computer scientists prefer to specify upper bounds on the number of comparisons
         * required. Most of the sorting algorithms that we have studied have an average time complexity
         * denoted by O(n^2). This is read "order n squared" and it means that to sort n items, no more
         * than an^2 + bn + c comparisons are required, where a, b and c are constants that differ from
         * one algorithm to another. That is, the number of comparisons is no greater than some quadratic
         * function of n.
         * 
         * The fastest comparison-based sorting algorithms have an average time complexity of O(nlogn). 
         * Even for such algorithms, worst-case performance can still be O(n^2).
         * 
         * See https://en.wikipedia.org/wiki/Sorting_algorithm#Comparison_of_algorithms for a detailed
         * comparison of the best-, worst- and average-case time complexity of a wide variety of different
         * sorting algorithms. This source also gives information on space complexity (memory requirements)
         * and stability (see next comment).
         * 
         **************************************************************************************************/
        #endregion

        #region General Comments on Sorting Algorithms

        /*
         * General Comments about the Sorting Algorithms Implemented Below
         *
         * The implementations have some desirable features.
         * 
         * 1. They are all "IN-PLACE" implementations, which means that the data are sorted entirely within the  
         *    given lists. No additional lists or arrays are used, which makes the most efficient use of memory.
         *    
         * 2. They do not RETURN sorted lists, because this would also require additional memory. Instead, they  
         *    directly alter the lists passed to them. This happens because 'List<>' is a reference type.
         * 
         *    e.g. Sorting.SelectionSort(numberList); 
         *
         *       → 'numberList' is A REFERENCE to the data stored in the list
         *       → This reference is copied to 'l' (the method's parameter)
         *       → Within the method, 'l' refers to the same list as 'numberList'
         *       → Any change made to the list IS A CHANGE in the SINGLE copy of the list stored in RAM.

         * 
         * STABLE versus UNSTABLE Sorting Algorithms
         * Stable sorting algorithms ALWAYS preserve the initial order of identical items/elements (i.e. the 
         * order of identical items/elements in the input). Unstable sorting algorithms, on the other hand, do
         * not always preserve this order. This isn't important at all when sorting records that contain only
         * one field. However, it is very important when records contain multiple fields. In the latter case,
         * stable sorts always preserve the initial order of records with identical keys.
         *   
         * e.g. Record: | lastName | firstName | address | telephone number | 
         *      Suppose that the key is 'lastName'. Stable sorts will maintain the initial order of the records 
         *      by 'lastName.' Unstable sorts don't necessarily preserve this order. 
         *      See https://en.wikipedia.org/wiki/Sorting_algorithm#Stability for more information.
         */

        #endregion

        #region Sorting Methods

        /// <summary>
        /// 'SelectionSort' uses the selection sort algorithm to sort the given list of double values in 
        /// ascending order. The average time complexity of selection sort is O(n^2) comparisons.
        /// Selection sort is UNSTABLE.
        /// </summary>
        public static void SelectionSort(List<double> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                //Find index of smallest value from index 'i' to index 'l.Count - 1'
                int minIndex = i;

                for (int j = i + 1; j < l.Count; j++)
                {
                    if (l[j] < l[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //Swap item 'i' with item 'minIndex'
                double copy = l[i];
                l[i] = l[minIndex];
                l[minIndex] = copy;
            }
        }

        /// <summary>
        /// 'BubbleSort' uses the bubble sort algorithm to sort the given list of double values in 
        /// ascending order. The average time complexity of bubble sort is O(n^2) comparisons.
        /// Bubble sort is STABLE.
        /// </summary>

        public static void BubbleSort(List<double> l)
        {
            // Insert your code here

            //variable that represents how many times each value is in order compared to its succesor 
            double inorder = 0;


            //outer loop runs until all values are in order 
            while (inorder < l.Count - 1)
            {
                for (int j = 0; j < l.Count - 1; j++)
                {
                    //checks if element in front is smaller, if so, then swap 
                    if (l[j] > l[(j + 1)])
                    {
                        double swapvalue = l[j];
                        l[j] = l[(j + 1)];
                        l[(j + 1)] = swapvalue;
                        //reset inorder to 0, since the list needed readjusting and since is not in ascending order 
                        inorder = 0;
                    }
                    
                    else
                    {
                        inorder += 1;
                    }

                }
            }

        }

        /// <summary>
        /// 'CocktailSort' uses the cocktail sort algorithm to sort the given list of double values in 
        /// ascending order. The average time complexity of cocktail sort is O(n^2) comparisons.
        /// Cocktail sort is STABLE.
        /// </summary>

        public static void CocktailSort(List<double> l)
        {
            // Insert your code here
            double inorder = 0;
            //needed to track when we need to check backwards 
            int reverseindexnum = l.Count;

            //outer loop 
            while (inorder < l.Count - 1)
            {
                reverseindexnum = l.Count;

                //instead of running once through the loop, it runs twice (j x 2)
                for (int j = 0; j < 2 * (l.Count - 1); j++)
                {
                    if (j < l.Count - 1)
                    {
                        if (l[j] > l[(j + 1)])
                        {

                            double swapvalue = l[j];
                            l[j] = l[(j + 1)];
                            l[(j + 1)] = swapvalue;
                            //reset inorder to 0, since the list needed readjusting and since is not in ascending order 
                            inorder = 0;
                        }
                        //adds one to inorder if the two values are in ascending order 
                        else
                        {
                            inorder += 1;
                        }
                    }
                    // j is bigger than the largest index, now we need to check in reverse 
                    else
                    {
                        reverseindexnum--;


                        //checks if the last index is smaller than the its predeccesor, if so swap
                        if (l[reverseindexnum] < l[reverseindexnum - 1])
                        {
                            double swapvalue = l[reverseindexnum];

                            l[reverseindexnum] = l[reverseindexnum - 1];

                            l[reverseindexnum - 1] = swapvalue;

                            inorder = 0;
                        }

                        else
                        {
                            inorder += 1;
                        }
                    }
                    //one iteration includes one forward run and one backward run 

                }
            }
        }

        /// <summary>
        /// 'InsertionSort' uses the insertion sort algorithm to sort the given list of double values in 
        /// ascending order. The average time complexity of insertion sort is O(n^2) comparisons.
        /// Insertion sort is STABLE.
        /// </summary>

        public static void InsertionSort(List<double> l)
        {
            // Insert your code here

            // Outer Loop
            for (int i = 1; i < l.Count; i++)
            {
                
                if (l[(i - 1)] > l[i])
                {
                    //save value of current value as the index will change 
                    double prevvalue = l[i];
                    int j = 1;

                    //inner loop that iterates every index before i, to check if the current value is smaller than each previous one, if so, swap
                    while (j <= i && prevvalue < l[i - j])
                    {
                        
                        l[i - j + 1] = l[i - j];

                        //when the smaller number is the smallest in the list, it is placed at the front 
                        if (j == i)
                        {
                            l[i - j] = prevvalue;

                        }
                        j++;
                    }
                    //keeps comparing the smaller value with previous values, until it is greater than a number, where it is placed (+1 from the number which it was greater than)
                    if (i >= j)
                    {
                        l[(i - j) + 1] = prevvalue;

                    }

                }

            }
        }

        // Shell sort is a generalization of insertion sort.
        // This implementation uses a triple-nested looping structure. It's possible to use a double-
        // nested looping structure but the logic is a little more difficult to comprehend.
        // Outermost Loop: Controls the value of h
        // Next Loop: Allows h-sorting to be performed for sublists starting at indices 0, 1, ..., h - 1
        // Next Loop: h-sorts sublist beginning at index 'start' using insertion sort
        // Innermost Loop: Shifts items h places to the right to make room for item to be inserted

        /// <summary>
        /// 'ShellSort' uses the Shell sort algorithm to sort the given list of double values in ascending
        /// order. The time complexity of Shell sort depends a great deal on the sequence of gap sizes
        /// (h-values) used. It's very difficult to determine the average time complexity of Shell sort
        /// but it's conjectured to be O(n^(5/4))=O(n^1.25) comparisons (much better than quadratic). 
        /// Shell sort is UNSTABLE.
        /// </summary>
        public static void ShellSort(List<double> l)
        {
            // Insert your code here

            //set the gap based on if the length of the code is even or odd, to make sure each number has a pair 
            int gap = 0;
            int inorder = 0;
            if (l.Count % 2 == 0)
            {
                gap = (l.Count / 2) - 1;
            }
            else
            {
                gap = (l.Count / 2);
            }
            int i = 0;

            //loop runs as the gap slowly decreases any value greater than 1 (ex: gap = 4, then gap =2)
            // checks whether the values are in order. Whenever swap occurs, inorder = 0. If no swaps occur, then in ordder = l.Count - 1
            while (gap >= 1 && inorder != l.Count - 1)
            {
                //outer condition checks if the number has a valid pair 
                if (i + gap < l.Count - 1)
                {
                    //swapping 
                    if (l[i] > l[i + gap])
                    {
                        double swapvalue = l[i];
                        l[i] = l[i + gap];
                        l[i + gap] = swapvalue;
                        inorder = 0;
                    }

                    else
                    {
                        inorder++;
                    }
                }

                //this is for the last number in the list, where the middle number actually has to check with the last number as well as the first number (has 2 pairs)
                else if (i + gap == l.Count - 1)
                {
                    if (l[i] > l[i + gap])
                    {
                        double swapvalue = l[i];
                        l[i] = l[i + gap];
                        l[i + gap] = swapvalue;
                        inorder = 0;
                    }
                    if (l[i] < l[i - gap])
                    {
                        double swapvalue = l[i];
                        l[i] = l[i - gap];
                        l[i - gap] = swapvalue;
                        inorder = 0;
                    }
                    else
                    {
                        inorder++;
                    }
                }
                else
                //decrease gap since the loop has been completed
                {
                    if (gap != 1)
                    {
                        gap = gap / 2;

                    }
                    i = -1;
                    inorder = 0;
                }
                i++;
            }




        }

        // The following method is an implementation of the quick sort algorithm.
        //
        // Description of Quick Sort Algorithm:
        // The first step is to divide the sublist of 'l' that runs from index 'left' to index 'right',
        // inclusive, into two parts about a "pivot" value. The pivot can be chosen in a variety of ways. This 
        // implementation uses the "middle" item of this sublist. (See comments below.) After partitioning is
        // completed, this sublist takes the following form: (Left Partition) + Pivot + (Right Partition), where
        // (Left Partition) consists of all items <= pivot and (Right Partition) consists of all items >= pivot.

        /// <summary>
        /// 'QuickSort' uses the quick sort algorithm to sort the given list of double values in ascending order.
        /// The average time complexity of quick sort is O(nlogn) comparisons. The worst-case performance of 
        /// QuickSort is still O(n^2) comparisons. QuickSort is UNSTABLE (although there are stable variants).
        /// </summary>
        public static void QuickSort(List<double> l, int left, int right)
        {
            // Insert your code here
            //partition the original list 
            int indexofpivot = DhruvPartition(l, left, right);

            //needed to move pivot position
            int indexreverse = 0;

            int newpivotindex;

            int inorder = 0;

            int i;

            int j;

            //smaller than pivot elements
            if (indexofpivot - indexreverse > 0)
            {
               //keeps going until elements are in order 
                while (inorder < indexofpivot - 1)
                {
                    //every iteration, the "right" value changes of the partition, making sure all elements get to be the pivot and get placed in their correct positions 
                    // last element = pivot, last element's index - 1 = pivot........
                    indexreverse++;
                    newpivotindex = DhruvPartition(l, 0, indexofpivot - indexreverse);
                    i = newpivotindex - 1;
                    j = indexofpivot - indexreverse - 1;

                    //if all values are smaller than it, thus it is in the right position
                    if (i == j)
                    {
                        inorder++;
                    }
                    //stops partitioning when pivot becomes index of pivot + 1
                    //resets value, so that the loop can start over, with the pivot being the last element 
                    if (indexreverse == indexofpivot - 1)
                    {
                        indexreverse = 0;
                        
                    }

                }
            }

            indexreverse = 0;

            //larger than pivot elements 
            if (indexofpivot + 1 < right - indexreverse)
            {      
                inorder = 0;

                indexreverse = -1;

                //sets how many passes needed to check if the list is in order (9 = right, index of pivot = 4)
                //9 - (4+1) - 1 = 3 passes needed 
                while (inorder < right - (indexofpivot + 1) - 1)
                {
                    //value to set new element as pivot 
                    indexreverse++;
                    newpivotindex = DhruvPartition(l, indexofpivot + 1, right - indexreverse);
                    i = newpivotindex - 1;
                    j = right - indexreverse - 1;

                    if (i == j)
                    {
                        inorder++;
                    }

                    //when indexofpivot is 0, indexreverse increases uncontrollably, this prevents that 
                    if (right - indexreverse <= indexofpivot+1)
                    {
                        indexreverse = 0;
                        inorder = 0;
                    }
                  
                }

            }

        }

        #endregion

        #region Partitioning Methods

        /// <summary>
        /// 'NaivePartition' divides the sublist of 'l' that runs from index 'left' to index 'right', inclusive, 
        /// into two parts about a "pivot" value. The pivot can be chosen in a variety of ways.  After partitioning is
        /// completed, this sublist takes the following form: (Left Partition) + Pivot + (Right Partition), where
        /// (Left Partition) consists of all items <= pivot and (Right Partition) consists of all items >= pivot.
        /// 
        /// This partitioning method is the first thing that occurred to me when I did my best to forget what I already
        /// knew about 'QuickSort'. Upon reflection, I realized that in spite of the simplicity of my algorithm, 
        /// it turned out to be very inefficient. Better algorithms, Lomuto partition and Hoare partition, are
        /// given below. The average time complexity of both algorithms is O(n) comparisons, although the Hoare method 
        /// can be shown to be the more efficient of the two. 
        /// 
        /// Unfortunately, it turns out that my naive algorithm's time complexity is O(n^2) comparisons, which 
        /// completely nullifies the speed advantages of QuickSort.
        /// </summary>

        // The pivot can be chosen in a variety of ways. For the sake of simplicity, all the methods below 
        // use the "middle" item of the sublist running from 'left' to 'right'. This turns out to be a 
        // good choice to prevent worst-case performance caused by applying 'QuickSort' to a list that's
        // already sorted. Even better choices are possible.
        // See https://en.wikipedia.org/wiki/Quicksort#Choice_of_pivot for details.


        public static int DhruvPartition(List<double> l, int left, int right)
        {
            int indexofpivot = 0;

            //partitions from left to right, checks whether right is greater than left
            if (left < right && left >= 0 && right < l.Count)
            {
                //pivot set at last number
                double pivot = l[right];

                //j set at first number, i set at j - 1
                int i = left - 1;
                int j = left;

                //loop continues till j element is one before right, or pivot - checks all elements before it 
                while (j <= right - 1)
                {
                    // swap elements at j and i indexes, since i will always be a number that is bigger than pivot and j will be a number smaller than pivot 
                    if (l[j] < pivot)
                    {
                        i++;
                        double swapvalue = l[j];
                        l[j] = l[i];
                        l[i] = swapvalue;
                        j++;
                    }
                    else
                    {
                        j++;
                    }


                }

                //set pivot at correct position, where all elements to the right are greater than it, all elements to the left are smaller than it 
                l[right] = l[i + 1];
                l[i + 1] = pivot;
                indexofpivot = i + 1;
                         
            }
            return (indexofpivot);
        }
        
            

        
        public static int NaivePartition(List<double> l, int left, int right)
        {
            int pivotIndex = -1;

            // Partition the sublist from index 'left' to index 'right' as described above.

            if (left < right && left >= 0 && right < l.Count)
            {
                pivotIndex = (left + right) / 2; // This could cause an overflow exception
                int smallerThanPivot = -1; // Don't count pivot itself
                double pivot = l[pivotIndex];

                // Count how many values are smaller than or equal to the pivot
                // Requires 'left - right + 1' comparisons (i.e. 'n' comparisons)
                for (int i = left; i <= right; i++)
                {
                    if (l[i] <= pivot)
                    {
                        smallerThanPivot++;
                    }
                }

                // Move the pivot to its final resting place by swapping
                int originalPivotIndex = pivotIndex;
                pivotIndex = left + smallerThanPivot;
                l[originalPivotIndex] = l[pivotIndex];
                l[pivotIndex] = pivot;

                // Now partition the list about pivot (which is found at index 'pivotIndex')
                // Outer loop requires 'pivotIndex - left' comparisons (i.e. n/2 comparsions on average)
                for (int i = left; i < pivotIndex; i++)
                {
                    if (l[i] > pivot)
                    {
                        //Find a value in the right partition that is smaller than pivot.
                        int j = pivotIndex + 1;

                        // This loop requires up to 'right - pivot' comparisons. On average, 
                        // it requires '(right - pivot)/2' comparisons (i.e. n/2 comparsions on average).
                        while (l[j] > pivot)
                        {
                            j++;
                        }

                        //Then exchange it with l[i].
                        double copy = l[j];
                        l[j] = l[i];
                        l[i] = copy;
                    }
                }
            }

            return pivotIndex;
        }

        /// <summary>
        /// 'LomutoPartition' divides the sublist of 'l' that runs from index 'left' to index 'right', inclusive, 
        /// into two parts about a "pivot" value. After partitioning is completed,
        /// this sublist takes the following form: (Left Partition) + Pivot + (Right Partition), where
        /// (Left Partition) consists of all items <= 'pivot' and (Right Partition) consists of all items >= 'pivot'.
        /// 
        /// The Lomuto partition algorithm, attributed to Nico Lomuto, is simpler and faster than the naive 
        /// algorithm used above. Unlike the above algorithm, it requires only one pass of the data. 
        /// The average time complexity of the Lomuto scheme is O(n) comparisons.
        /// </summary>
        public static int LomutoPartition(List<double> l, int left, int right)
        {
            int pivotIndex = -1;

            // Partition the sublist from index 'left' to index 'right' as described above.

            if (left < right && left >= 0 && right < l.Count)
            {
                pivotIndex = left + (right - left) / 2; // Immune from overflow exception
                double pivot = l[pivotIndex];

                // Move 'pivot' to the (right) end by swapping.
                l[pivotIndex] = l[right];
                l[right] = pivot;

                // Assume at first that the pivot's final resting place is at index 'left'
                pivotIndex = left;

                // Each time a value smaller than the 'pivot' is found, exchange it with 
                // l[pivotIndex] and increase 'pivotIndex' by 1.
                for (int i = left; i < right; i++)
                {
                    if (l[i] <= pivot)
                    {
                        double copy = l[pivotIndex];
                        l[pivotIndex] = l[i];
                        l[i] = copy;
                        pivotIndex++;
                    }
                }

                // Move the pivot to its final resting place by swapping 
                l[right] = l[pivotIndex];
                l[pivotIndex] = pivot;
            }

            return pivotIndex;
        }

        /// <summary>
        /// ****NOTE: The Hoare partitioning scheme is a little different from the previous two.****
        /// 'HoarePartition' divides the sublist of 'l' that runs from index 'left' to index 'right', inclusive, 
        /// into two parts called the 'Left Partition' and the 'Right Partition'. After partitioning is completed,
        /// this sublist takes the following form: (Left Partition) + (Right Partition), where each item in
        /// (Left Partition) is <= each item in (Right Partition).
        /// 
        /// The Hoare partition algorithm was introduced by C. A. R. Hoare (aka Tony Hoare), the inventor 
        /// of quick sort. It is even more efficient than the Lomuto method BUT is somewhat more difficult 
        /// to understand and implement. It uses two variables, 'i' and 'pivotIndex', to store index values   
        /// that are initially at opposite ends of the list. The values of these two variables "move" toward   
        /// each other, 'i' increasing by one whenever 'l[i]' < 'pivot' and 'pivotIndex' decreasing by one 
        /// whenever 'l[pivotIndex]' > 'pivot'. When values 'l[pivotIndex]' and 'l[i]' are found to be in the  
        /// wrong order relative to the pivot, they are swapped. This continues as long as 'i' < 'pivotIndex'.
        /// 
        /// ****VERY IMPORTANT NOTE!****
        /// The Hoare partitioning scheme does NOT necessarily return the index of the final resting place of the 
        /// pivot! It only guarantees that the all items with indices <= 'pivotIndex' are smaller than all items
        /// with indices > 'pivotIndex'.
        /// 
        /// The average time complexity of the Hoare partitioning scheme is O(n) comparisons.
        /// </summary>
        public static int HoarePartition(List<double> l, int left, int right)
        {
            // Partition the sublist from index 'left' to index 'right' as described above.
            int pivotIndex = -1;

            if (left < right && left >= 0 && right < l.Count)
            {
                double pivot = l[left + (right - left) / 2]; // Immune from overflow exception
                int i = left - 1;
                pivotIndex = right + 1;

                while (i < pivotIndex)
                {
                    // Starting from the left, loop until a value is found that is >= 'pivot'
                    do
                    {
                        i++;
                    } while (l[i] < pivot);

                    // Starting from the right, loop until a value is found that is <= 'pivot'
                    do
                    {
                        pivotIndex--;
                    } while (l[pivotIndex] > pivot);

                    if (i < pivotIndex)
                    {
                        // Swap l[i] with l[pivotIndex] because they are out of order relative to 'pivot'
                        double copy = l[i];
                        l[i] = l[pivotIndex];
                        l[pivotIndex] = copy;
                    }
                }
            }

            return pivotIndex;
        }

        #endregion

        #region Scrambling (Shuffling)

        /// <summary>
        /// 'Scramble' "shuffles" the list 'l', that is, it puts the items of 'l' in a random order.
        /// </summary>
        public static void Scramble(List<double> l)
        {
            // Create a 'Random' object
            Random randomNumberGenerator = new Random();

            for (int i = 0; i < l.Count; i++)
            {
                int randomIndex = randomNumberGenerator.Next(0, l.Count);

                // Swap item 'i' with item 'randomIndex'
                double copy = l[i];
                l[i] = l[randomIndex];
                l[randomIndex] = copy;
            }

        }

        #endregion
    }
}