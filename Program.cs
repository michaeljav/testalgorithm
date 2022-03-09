using System;
using System.Diagnostics;
using System.Text;

namespace testalgorithm
{
    class Program
    {
        /**
         * 
         * 
         * BINARY SEARCH : IF YOU HAVE A ORGANISED ARRAY  YOU USE THIS.         * 
         * YOU BEGIN SEARCHING FROM THE MIDDLE.
         * EJE :with this method we're  assuming that the array is sorted
         * and  it is in ascending order.
         * bINARY SEARCH is a divide and conquer algorithm
         * 
         * 
         * 
         * Note: Linear search: no assumptions, O(n)times
         * Binary search: sorted assumption, O(log(n)) time
         */
      
          static Boolean BinarySearch(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (item == inputArray[mid])
                {
                    return true;
                }
                else if(item < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return false;


        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
           Console.WriteLine(BinarySearch(arr, 5));

            // C SHARP DOES HAVE A BUILT-IN FUNCTION FOR BINARY SEARCH
           int result= Array.BinarySearch(arr, 1);
            Console.WriteLine(result);


        }

      
    }
}
