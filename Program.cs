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
      
          static int[] Reverse(int[] input)
        {

            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }
            return reversed;
        }

        static void ReverseInPlace(int[] input)
        {
            //loop untill mid because inside of for I swap the values.
            for (int i = 0; i < input.Length / 2; i++)
            {
                //Swap index(i) with index(input.Length-i-1)
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

        static void Main(string[] args)
        {
            //6,5,4,3,2,1=
            int[] arr = { 1,2,3,4,5,6 };

            //OPTION 1 REVERSE
            int[] eventArr = Reverse(arr);
            Array.ForEach(eventArr, Console.WriteLine);

            //OPTION 2 REVERSE WITH SWAP IN PLACE
            ReverseInPlace(arr);
            //THE REVERSE OF THE REVERSE IS THE ORIGINAL CONTENT
            //ReverseInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);
        }

      
    }
}
