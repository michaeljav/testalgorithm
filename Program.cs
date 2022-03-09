using System;
using System.Collections;
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
      
          static int[] FindEvenNums(int[] arr1, int[] arr2)
        {

            ArrayList result = new ArrayList();

            foreach (var num in arr1)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }
            foreach (var num in arr2)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }

            return (int[])result.ToArray(typeof(int));
        }

        static void Main(string[] args)
        {
            int[] arr1 = { -8, 2, 3, -9, 11, -20 };
            int[] arr2 = { 0, -2, -9,-39, 39,10,7};

            int[] eventArr = FindEvenNums(arr1, arr2);
            Array.ForEach(eventArr, Console.WriteLine);
        }

      
    }
}
